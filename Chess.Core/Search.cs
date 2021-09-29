using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core
{
    public static class Search
    {
        private struct Position
        {
            internal Square srcPosition;
            internal Square dstPosition;
            internal int score;
            
        }

        private static int Sort(Position s1, Position s2)
        {
            return (s1.score).CompareTo(s2.score);
        }

        public static bool searchForMate(ChessPieceColor movingSide, Board examineBoard, ref bool blackMate,
            ref bool whiteMate)
        {
            bool foundNonCheckBlack = false;
            bool foundNonCheckWhite = false;
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square square = examineBoard.squares[i, j];
                    if (square.piece.type == TypeOfChessPiece.NaP)
                        continue;

                    // For making sure that the same color as the one we are moving
                    if (square.piece.type == TypeOfChessPiece.w_bishop ||
                        square.piece.type == TypeOfChessPiece.w_rook ||
                        square.piece.type == TypeOfChessPiece.w_pawn ||
                        square.piece.type == TypeOfChessPiece.w_queen ||
                        square.piece.type == TypeOfChessPiece.w_king ||
                        square.piece.type == TypeOfChessPiece.w_knight)
                    {
                        if (movingSide == ChessPieceColor.white)
                        {
                            continue;
                        }
                    }
                    else if (square.piece.type == TypeOfChessPiece.b_bishop ||
                        square.piece.type == TypeOfChessPiece.b_rook ||
                        square.piece.type == TypeOfChessPiece.b_pawn ||
                        square.piece.type == TypeOfChessPiece.b_queen ||
                        square.piece.type == TypeOfChessPiece.b_king ||
                        square.piece.type == TypeOfChessPiece.b_knight)
                    {
                        if (movingSide == ChessPieceColor.black)
                        {
                            continue;
                        }
                    }

                    foreach (var sqr in Move.generateMoves(square, square.piece.type, examineBoard))
                    {
                        Board board = examineBoard.copy();
                        board.replaceChessPiece(board, sqr, sqr.piece.type);

                        if (board.isBlackChecked(board) == false)
                        {
                            foundNonCheckBlack = true;
                        }
                        else if (square.piece.type == TypeOfChessPiece.b_bishop ||
                                 square.piece.type == TypeOfChessPiece.b_rook ||
                                 square.piece.type == TypeOfChessPiece.b_pawn ||
                                 square.piece.type == TypeOfChessPiece.b_queen ||
                                 square.piece.type == TypeOfChessPiece.b_king ||
                                 square.piece.type == TypeOfChessPiece.b_knight)
                        {
                            if (movingSide == ChessPieceColor.black)
                            {
                                continue;
                            }
                            
                        }

                        if (board.isWhiteChecked(board) == false)
                        {
                            foundNonCheckWhite = true;
                        }
                        else if (square.piece.type == TypeOfChessPiece.w_bishop ||
                                 square.piece.type == TypeOfChessPiece.w_rook ||
                                 square.piece.type == TypeOfChessPiece.w_pawn ||
                                 square.piece.type == TypeOfChessPiece.w_queen ||
                                 square.piece.type == TypeOfChessPiece.w_king ||
                                 square.piece.type == TypeOfChessPiece.w_knight)
                        {
                            if (movingSide == ChessPieceColor.white)
                            {
                                continue;
                            }

                        }
                    }

                    if (foundNonCheckBlack == false)
                    {
                        if (examineBoard.blackCheck)
                        {
                            blackMate = true;
                            return true;
                        }
                    }

                    if (foundNonCheckWhite == false)
                    {
                        if (examineBoard.whiteCheck)
                        {
                            whiteMate = true;
                            return true;
                        }
                    }

                    
                }
            }
            return false;
        }

        public static int SideToMoveScore(int score, ChessPieceColor color)
        {
            if (color == ChessPieceColor.black)
            {
                return -score;
            }
            else
            {
                return score;
            }
        }


        private static List<Position> EvaluteMoves(Board examinBoard, int depth, ChessPieceColor whoseMoving)
        {
            // We are going to store our result boards here
            List<Position> positions = new List<Position>();

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Piece piece = examinBoard.squares[row, col].piece;
                    Square pieceSquare = examinBoard.squares[row, col];

                    if (piece.type == TypeOfChessPiece.NaP)
                        continue;

                    if (piece.type == TypeOfChessPiece.w_bishop ||
                        piece.type == TypeOfChessPiece.w_king ||
                        piece.type == TypeOfChessPiece.w_rook ||
                        piece.type == TypeOfChessPiece.w_queen ||
                        piece.type == TypeOfChessPiece.w_pawn ||
                        piece.type == TypeOfChessPiece.w_knight)
                    {
                        if (whoseMoving != ChessPieceColor.white)
                        {
                            continue;
                        }
                    }
                    else if (piece.type == TypeOfChessPiece.b_bishop ||
                        piece.type == TypeOfChessPiece.b_king ||
                        piece.type == TypeOfChessPiece.b_rook ||
                        piece.type == TypeOfChessPiece.b_queen ||
                        piece.type == TypeOfChessPiece.b_pawn ||
                        piece.type == TypeOfChessPiece.b_knight)
                    {
                        if (whoseMoving != ChessPieceColor.black)
                        {
                            continue;
                        }
                    }

                    foreach (var square in Move.generateMoves(pieceSquare, piece.type, examinBoard))
                    {
                        Position move = new Position();
                        Piece pieceAttacked = null;

                        move.srcPosition = examinBoard.squares[row, col];
                        move.dstPosition = square;

                        foreach (var tempSquare in examinBoard.squares)
                        {
                            if (tempSquare == square)
                            {
                                pieceAttacked = tempSquare.piece;
                            }
                        }


                        if (pieceAttacked != null)
                        {
                            move.score += pieceAttacked.pieceValue;

                            if (piece.pieceValue < pieceAttacked.pieceValue)
                            {
                                move.score += pieceAttacked.pieceValue - piece.pieceValue;
                            }
                        }

                        if (!piece.moved)
                        {
                            move.score += 10;
                        }

                        move.score += piece.pieceActionValue;

                        // Add Score for Castling

                        if (!examinBoard.whiteCastled && whoseMoving == ChessPieceColor.white)
                        {
                            if (piece.type == TypeOfChessPiece.w_king)
                            {
                                if (move.dstPosition != new Square(1, 7) && move.dstPosition != new Square(1, 2))
                                {
                                    move.score -= 40;
                                }
                                else
                                {
                                    move.score += 40;
                                }
                            }
                            if (piece.type == TypeOfChessPiece.w_rook)
                            {
                                move.score -= 40;
                            }
                        }

                        if (!examinBoard.blackCastled && whoseMoving == ChessPieceColor.black)
                        {
                            if (piece.type == TypeOfChessPiece.b_king)
                            {
                                if (move.dstPosition != new Square(8, 7) && move.dstPosition != new Square(8, 2))
                                {
                                    move.score -= 40;
                                }
                                else
                                {
                                    move.score += 40;
                                }
                            }
                            if (piece.type == TypeOfChessPiece.b_rook)
                            {
                                move.score -= 40;
                            }
                        }

                        positions.Add(move);
                    }

                }
            }
            return positions;
        }

        public static int AlphaBeta(Board examinBoard, int depth, int alpha, int beta, ref int nodeSearch)
        {
            return 1;
        }
    }
}