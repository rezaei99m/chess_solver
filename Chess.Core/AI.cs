using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core
{
    public static class AI
    {
        private static int[] blackPawnCount;
        private static int[] whitePawnCount;

        private static readonly Square[] pawnTable = new Square[]
        {
             new Square(1, 1, 0), new Square(1, 2, 0), new Square(1, 3, 0), new Square(1, 4, 0), new Square(1, 5, 0), new Square(1, 6, 0), new Square(1, 7, 0), new Square(1, 8, 0),
             new Square(2, 1, 50), new Square(2, 2, 50), new Square(2, 3, 50), new Square(2, 4, 50), new Square(2, 5, 50), new Square(2, 6, 50), new Square(2, 7, 50), new Square(2, 8, 50),
             new Square(3, 1, 10), new Square(3, 2, 10), new Square(3, 3, 20), new Square(3, 4, 30), new Square(3, 5, 30), new Square(3, 6, 20), new Square(3, 7, 10), new Square(3, 8, 10),
             new Square(4, 1, 5), new Square(4, 2, 5), new Square(4, 3, 10), new Square(4, 4, 27), new Square(4, 5, 27), new Square(4, 6, 10), new Square(4, 7, 5), new Square(4, 8, 5),
             new Square(5, 1, 0), new Square(5, 2, 0), new Square(5, 3, 0), new Square(5, 4, 25), new Square(5, 5, 25), new Square(5, 6, 0), new Square(5, 7, 0), new Square(5, 8, 0),
             new Square(6, 1, 5), new Square(6, 2, - 5), new Square(6, 3, - 10), new Square(6, 4, 0), new Square(6, 5, 0), new Square(6, 6, - 10), new Square(6, 7, - 5), new Square(6, 8, 5),
             new Square(7, 1, 5), new Square(7, 2, 10), new Square(7, 3, 10), new Square(7, 4, - 25), new Square(7, 5, - 25), new Square(7, 6, 10), new Square(7, 7, 10), new Square(7, 8, 5),
             new Square(8, 1, 0), new Square(8, 2, 0), new Square(8, 3, 0),  new Square(8, 4, 0), new Square(8, 5, 0), new Square(8, 6, 0), new Square(8, 7, 0), new Square(8, 8, 0)
        };

        private static readonly Square[] knightTable = new Square[]
        {
             new Square(1, 1, - 50), new Square(1, 2, - 40), new Square(1, 3, - 30), new Square(1, 4, - 30), new Square(1, 5, - 30), new Square(1, 6, - 30), new Square(1, 7, - 40), new Square(1, 8, - 50),
             new Square(2, 1, - 40), new Square(2, 2, - 20), new Square(2, 3, 0), new Square(2, 4, 0), new Square(2, 5, 0), new Square(2, 6, 0), new Square(2, 7, - 20), new Square(2, 8, - 40),
             new Square(3, 1, - 30), new Square(3, 2, 0), new Square(3, 3, 10), new Square(3, 4, 15), new Square(3, 5, 15), new Square(3, 6, 10), new Square(3, 7, 0), new Square(3, 8, - 30),
             new Square(4, 1, - 30), new Square(4, 2, 5), new Square(4, 3, 15), new Square(4, 4, 20), new Square(4, 5, 20), new Square(4, 6, 15), new Square(4, 7, 5), new Square(4, 8, - 30),
             new Square(5, 1, - 30), new Square(5, 2, 0), new Square(5, 3, 15), new Square(5, 4, 20), new Square(5, 5, 20), new Square(5, 6, 15), new Square(5, 7, 0), new Square(5, 8, - 30),
             new Square(6, 1, - 30), new Square(6, 2, 5), new Square(6, 3, 10), new Square(6, 4, 15), new Square(6, 5, 15), new Square(6, 6, 10), new Square(6, 7, 5), new Square(6, 8, - 30),
             new Square(7, 1, - 40), new Square(7, 2, - 20), new Square(7, 3, 0), new Square(7, 4, 5), new Square(7, 5, 5), new Square(7, 6, 0), new Square(7, 7, - 20), new Square(7, 8, - 40),
             new Square(8, 1, - 50), new Square(8, 2, - 40), new Square(8, 3, - 20), new Square(8, 4, - 30), new Square(8, 5, - 30), new Square(8, 6, - 20), new Square(8, 7, - 40), new Square(8, 8, - 50)
        };

        private static readonly Square[] bishopTable = new Square[]
        {
             new Square(1, 1, - 20), new Square(1, 2, - 10), new Square(1, 3, - 10), new Square(1, 4, - 10), new Square(1, 5, - 10), new Square(1, 6, - 10), new Square(1, 7, - 10), new Square(1, 8, - 20),
             new Square(2, 1, - 10), new Square(2, 2, 0), new Square(2, 3, 0), new Square(2, 4, 0), new Square(2, 5, 0), new Square(2, 6, 0), new Square(2, 7, 0), new Square(2, 8, - 10),
             new Square(3, 1, - 10), new Square(3, 2, 0), new Square(3, 3, 5), new Square(3, 4, 10), new Square(3, 5, 10), new Square(3, 6, 5), new Square(3, 7, 0), new Square(3, 8, - 10),
             new Square(4, 1, - 10), new Square(4, 2, 5), new Square(4, 3, 5), new Square(4, 4, 10), new Square(4, 5, 10), new Square(4, 6, 5), new Square(4, 7, 5), new Square(4, 8, - 10),
             new Square(5, 1, - 10), new Square(5, 2, 0), new Square(5, 3, 10), new Square(5, 4, 10), new Square(5, 5, 10), new Square(5, 6, 10), new Square(5, 7, 0), new Square(5, 8, - 10),
             new Square(6, 1, - 10), new Square(6, 2, 10), new Square(6, 3, 10), new Square(6, 4, 10), new Square(6, 5, 10), new Square(6, 6, 10), new Square(6, 7, 10), new Square(6, 8, - 10),
             new Square(7, 1, - 10), new Square(7, 2, 5), new Square(7, 3, 0), new Square(7, 4, 0), new Square(7, 5, 0), new Square(7, 6, 0), new Square(7, 7, 5), new Square(7, 8, - 10),
             new Square(8, 1, - 20), new Square(8, 2, - 10), new Square(8, 3, - 40), new Square(8, 4, - 10), new Square(8, 5, - 10), new Square(8, 6, - 40), new Square(8, 7, - 10), new Square(8, 8, - 20)
        };

        private static readonly Square[] kingTable = new Square[]
        {
             new Square(1, 1, - 30), new Square(1, 2, - 40), new Square(1, 3, - 40), new Square(1, 4, - 50), new Square(1, 5, - 50), new Square(1, 6, - 40), new Square(1, 7, - 40), new Square(1, 8, - 30),
             new Square(2, 1, - 30), new Square(2, 2, - 40), new Square(2, 3, - 40), new Square(2, 4, - 50), new Square(2, 5, - 50), new Square(2, 6, - 40), new Square(2, 7, - 40), new Square(2, 8, - 30),
             new Square(3, 1, - 30), new Square(3, 2, - 40), new Square(3, 3, - 40), new Square(3, 4, - 50), new Square(3, 5, - 50), new Square(3, 6, - 40), new Square(3, 7, - 40), new Square(3, 8, - 30),
             new Square(4, 1, - 30), new Square(4, 2, - 40), new Square(4, 3, - 40), new Square(4, 4, - 50), new Square(4, 5, - 50), new Square(4, 6, - 40), new Square(4, 7, - 40), new Square(4, 8, - 30),
             new Square(5, 1, - 20), new Square(5, 2, - 30), new Square(5, 3, - 30), new Square(5, 4, - 40), new Square(5, 5, - 40), new Square(5, 6, - 30), new Square(5, 7, - 30), new Square(5, 8, - 20),
             new Square(6, 1, - 10), new Square(6, 2, - 20), new Square(6, 3, - 20), new Square(6, 4, - 20), new Square(6, 5, - 20), new Square(6, 6, - 20), new Square(6, 7, - 20), new Square(6, 8, - 10),
             new Square(7, 1, 20), new Square(7, 2, 20), new Square(7, 3, 0), new Square(7, 4, 0), new Square(7, 5, 0), new Square(7, 6, 0), new Square(7, 7, 0), new Square(7, 8, 20),
             new Square(8, 1, 20), new Square(8, 2, 30), new Square(8, 3, 10), new Square(8, 4, 0), new Square(8, 5, 0), new Square(8, 6, 10), new Square(8, 7, 10), new Square(8, 8, 20)
        };

        private static readonly Square[] kingTableEndGame = new Square[]
        {
             new Square(1, 1, - 50), new Square(1, 2, - 40), new Square(1, 3, - 30), new Square(1, 4, - 20), new Square(1, 5, - 20), new Square(1, 6, - 30), new Square(1, 7, - 40), new Square(1, 8, - 50),
             new Square(2, 1, - 30), new Square(2, 2, - 20), new Square(2, 3, - 10), new Square(2, 4, 0), new Square(2, 5, 0), new Square(2, 6, - 10), new Square(2, 7, - 20), new Square(2, 8, - 30),
             new Square(3, 1, - 30), new Square(3, 2, - 10), new Square(3, 3, 20), new Square(3, 4, 30), new Square(3, 5, 30), new Square(3, 6, 20), new Square(3, 7, - 10), new Square(3, 8, - 30),
             new Square(4, 1, - 30), new Square(4, 2, - 10), new Square(4, 3, 30), new Square(4, 4, 40), new Square(4, 5, 40), new Square(4, 6, 30), new Square(4, 7, - 10), new Square(4, 8, - 30),
             new Square(5, 1, - 30), new Square(5, 2, - 10), new Square(5, 3, 30), new Square(5, 4, 40), new Square(5, 5, 40), new Square(5, 6, 30), new Square(5, 7, - 10), new Square(5, 8, - 30),
             new Square(6, 1, - 30), new Square(6, 2, - 10), new Square(6, 3, 20), new Square(6, 4, 30), new Square(6, 5, 30), new Square(6, 6, 20), new Square(6, 7, - 10), new Square(6, 8, - 30),
             new Square(7, 1, - 30), new Square(7, 2, - 30), new Square(7, 3, 0), new Square(7, 4, 0), new Square(7, 5, 0), new Square(7, 6, 0), new Square(7, 7, - 30), new Square(7, 8, - 30),
             new Square(8, 1, - 50), new Square(8, 2, - 30), new Square(8, 3, - 30), new Square(8, 4, - 30), new Square(8, 5, - 30), new Square(8, 6, - 30), new Square(8, 7, - 30), new Square(8, 8, - 50)
        };

        public static int convertRowAndColumnToPositionIndexArray(int row, int column)
        {
            return (column - 1) + ((row - 1) * 8);
        }

        public static int convertTableForBlack(int row, int column)
        {
            int position = convertRowAndColumnToPositionIndexArray(row, column);
            return (63 - position);
        }

        public static int evaluateChessPieceScore(Square square, bool endGamePhase,
                                                    ref int knightCount, ref int bishopCount, ref bool insufficientMaterial)
        {
            int score = 0;

            int index = convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn());

            if (square.piece.type == TypeOfChessPiece.b_bishop ||
                square.piece.type == TypeOfChessPiece.b_pawn ||
                square.piece.type == TypeOfChessPiece.b_rook ||
                square.piece.type == TypeOfChessPiece.b_knight ||
                square.piece.type == TypeOfChessPiece.b_queen ||
                square.piece.type == TypeOfChessPiece.b_king)
            {
                index = convertTableForBlack(square.getRow(), square.getColumn());
            }

            // Calculate Piece Values
            score += square.piece.pieceValue;
            score += square.piece.defendedValue;
            score -= square.piece.attackedValue;

            // Double Penalty for Hanging Pieces
            if (square.piece.defendedValue < square.piece.attackedValue)
            {
                score -= ((square.piece.attackedValue - square.piece.defendedValue) * 10);
            }

            // It means nothing can stop it.
            if (square.piece.validMoves != null)
            {
                score += square.piece.validMoves.Count;
            }

            if (square.piece.type == TypeOfChessPiece.b_pawn ||
                square.piece.type == TypeOfChessPiece.w_pawn)
            {
                insufficientMaterial = false;
                if (square.getColumn() == 1 ||
                    square.getColumn() == 8)
                {
                    // Rook Pawns are worth 15% less because they can only attack one way
                    score -= 15;
                }

                score += pawnTable[index].getScore();
                
                if (square.piece.type == TypeOfChessPiece.w_pawn)
                {
                    if (whitePawnCount[square.getColumn() - 1] > 0)
                    {
                        // Double Pawn
                        score -= 16;
                    }

                    if (convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn()) >= 8 &&
                        convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn()) <= 15)
                    {
                        if (square.piece.attackedValue == 0)
                        {
                            whitePawnCount[square.getColumn() - 1] += 200;

                            if (square.piece.defendedValue != 0)
                            {
                                whitePawnCount[square.getColumn() - 1] += 50;
                            }
                        }
                    }
                    else if (convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn()) >= 16 &&
                        convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn()) <= 23)
                    {
                        if (square.piece.attackedValue == 0)
                        {
                            whitePawnCount[square.getColumn() - 1] += 100;

                            if (square.piece.defendedValue != 0)
                            {
                                whitePawnCount[square.getColumn() - 1] += 25;
                            }
                        }
                    }

                    whitePawnCount[convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn()) % 8] += 10;

                }
                else
                {
                    if (blackPawnCount[square.getColumn() - 1] > 0)
                    {
                        // Double Pawn
                        score -= 16;
                    }

                    if (convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn()) >= 8 &&
                        convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn()) <= 15)
                    {
                        if (square.piece.attackedValue == 0)
                        {
                            blackPawnCount[square.getColumn() - 1] += 200;

                            if (square.piece.defendedValue != 0)
                            {
                                blackPawnCount[square.getColumn() - 1] += 50;
                            }
                        }
                    }
                    else if (convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn()) >= 16 &&
                        convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn()) <= 23)
                    {
                        if (square.piece.attackedValue == 0)
                        {
                            blackPawnCount[square.getColumn() - 1] += 100;

                            if (square.piece.defendedValue != 0)
                            {
                                blackPawnCount[square.getColumn() - 1] += 25;
                            }
                        }
                    }

                    blackPawnCount[convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn()) % 8] += 10;
                }
            }

            else if (square.piece.type == TypeOfChessPiece.b_knight ||
                square.piece.type == TypeOfChessPiece.w_knight)
            {
                knightCount++;

                score += knightTable[index].getScore();

                // In the End Game remove a few points for Knights sice they are worth less
                if (endGamePhase)
                {
                    score -= 10;
                }
            }

            else if (square.piece.type == TypeOfChessPiece.b_bishop ||
                square.piece.type == TypeOfChessPiece.w_bishop)
            {
                bishopCount++;

                if (bishopCount >= 2)
                {
                    // 2 Bishop recive a bounus
                    score += 10;
                }
                // In the End Game Bishops are worth more
                if (endGamePhase)
                {
                    score += 10;
                }
                score += bishopTable[convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn())].getScore();
            }

            else if (square.piece.type == TypeOfChessPiece.b_rook ||
                square.piece.type == TypeOfChessPiece.w_rook)
            {
                insufficientMaterial = false;
            }

            else if (square.piece.type == TypeOfChessPiece.b_queen ||
                square.piece.type == TypeOfChessPiece.w_queen)
            {
                insufficientMaterial = false;
                if (square.piece.moved && !endGamePhase)
                {
                    score -= 10;
                }
            }

            else if (square.piece.type == TypeOfChessPiece.b_king ||
                square.piece.type == TypeOfChessPiece.w_king)
            {
                if (square.piece.validMoves != null)
                {
                    if (square.piece.validMoves.Count < 2)
                    {
                        score -= 5;
                    }
                }

                if (endGamePhase)
                {
                    score += kingTableEndGame[convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn())].getScore();
                }
                else
                {
                    score += kingTable[convertRowAndColumnToPositionIndexArray(square.getRow(), square.getColumn())].getScore();
                }
            }
            return score;
        }

        public static void evaluateBoardScore(Board board)
        {
            // Black score -
            // White score +
            board.score = 0;

            bool insufficientMaterial = true;

            if (board.blackMate)
            {
                board.score = 32767;
                return;
            }
            if (board.whiteMate)
            {
                board.score = -32767;
            }
            if (board.blackCheck)
            {
                board.score += 75;
                if (board.endGamePhase)
                {
                    board.score += 10;
                }
            }
            else if (board.whiteCheck)
            {
                board.score -= 75;
                if (board.endGamePhase)
                {
                    board.score -= 10;
                }
            }
            if (board.blackCastled)
            {
                board.score -= 40;
            }
            if (board.whiteCastled)
            {
                board.score += 40;
            }
            // Add a Small bonus for tempo (turn)
            if (board.isWhiteTurn)
            {
                board.score += 10;
            }
            else
            {
                board.score -= 10;
            }

            int blackBishopCount = 0;
            int whiteBishopCount = 0;

            int blackKnightCount = 0;
            int whiteKnightCount = 0;

            int knightCount = 0;

            int remainingPieces = 0;

            blackPawnCount = new int[8];
            whitePawnCount = new int[8];
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square square = new Square(board.squares[i, j].getRow(), board.squares[i, j].getColumn());

                    if (square.piece.type == TypeOfChessPiece.NaP)
                    {
                        continue;
                    }

                    // Calculate remaining material for end game determination
                    remainingPieces++;
                    if (square.piece.type == TypeOfChessPiece.w_bishop ||
                        square.piece.type == TypeOfChessPiece.w_rook ||
                        square.piece.type == TypeOfChessPiece.w_pawn ||
                        square.piece.type == TypeOfChessPiece.w_queen ||
                        square.piece.type == TypeOfChessPiece.w_king ||
                        square.piece.type == TypeOfChessPiece.w_knight)
                    {
                        board.score += AI.evaluateChessPieceScore(board.squares[i, j], board.endGamePhase, ref whiteKnightCount, ref whiteBishopCount, ref insufficientMaterial);
                    }
                    else if (square.piece.type == TypeOfChessPiece.b_bishop ||
                        square.piece.type == TypeOfChessPiece.b_rook ||
                        square.piece.type == TypeOfChessPiece.b_pawn ||
                        square.piece.type == TypeOfChessPiece.b_queen ||
                        square.piece.type == TypeOfChessPiece.b_king ||
                        square.piece.type == TypeOfChessPiece.b_knight)
                    {
                        board.score -= AI.evaluateChessPieceScore(board.squares[i, j], board.endGamePhase, ref blackKnightCount, ref blackBishopCount, ref insufficientMaterial);
                    }

                    if (square.piece.type == TypeOfChessPiece.b_knight || 
                        square.piece.type == TypeOfChessPiece.w_knight)
                    {
                        knightCount++;

                        if (knightCount > 1)
                        {
                            insufficientMaterial = false;
                        }
                    }

                    if ((blackBishopCount + whiteBishopCount) > 1)
                    {
                        insufficientMaterial = false;
                    }
                    else if ((blackBishopCount + blackKnightCount) > 1)
                    {
                        insufficientMaterial = false;
                    }
                    else if ((whiteBishopCount + whiteKnightCount) > 1)
                    {
                        insufficientMaterial = false;
                    }
                }
                if (insufficientMaterial)
                {
                    board.score = 0;
                    board.insufficientMaterial = true;
                    return;
                }

                if (board.endGamePhase)
                {
                    if (board.blackCheck)
                    {
                        board.score += 10;
                    }
                    else if (board.whiteCheck)
                    {
                        board.score -= 10;
                    }
                }

                #region Isolated Pawns
                //Black Isolated Pawns
                if (blackPawnCount[0] >= 1 && blackPawnCount[1] == 0)
                {
                    board.score += 12;
                }
                if (blackPawnCount[1] >= 1 && blackPawnCount[0] == 0 &&
                    blackPawnCount[2] == 0)
                {
                    board.score += 14;
                }
                if (blackPawnCount[2] >= 1 && blackPawnCount[1] == 0 &&
                    blackPawnCount[3] == 0)
                {
                    board.score += 16;
                }
                if (blackPawnCount[3] >= 1 && blackPawnCount[2] == 0 &&
                    blackPawnCount[4] == 0)
                {
                    board.score += 20;
                }
                if (blackPawnCount[4] >= 1 && blackPawnCount[3] == 0 &&
                    blackPawnCount[5] == 0)
                {
                    board.score += 20;
                }
                if (blackPawnCount[5] >= 1 && blackPawnCount[4] == 0 &&
                    blackPawnCount[6] == 0)
                {
                    board.score += 16;
                }
                if (blackPawnCount[6] >= 1 && blackPawnCount[5] == 0 &&
                    blackPawnCount[7] == 0)
                {
                    board.score += 14;
                }
                if (blackPawnCount[7] >= 1 && blackPawnCount[6] == 0)
                {
                    board.score += 12;
                }

                //White Isolated Pawns
                if (whitePawnCount[0] >= 1 && whitePawnCount[1] == 0)
                {
                    board.score -= 12;
                }
                if (whitePawnCount[1] >= 1 && whitePawnCount[0] == 0 &&
                    whitePawnCount[2] == 0)
                {
                    board.score -= 14;
                }
                if (whitePawnCount[2] >= 1 && whitePawnCount[1] == 0 &&
                    whitePawnCount[3] == 0)
                {
                    board.score -= 16;
                }
                if (whitePawnCount[3] >= 1 && whitePawnCount[2] == 0 &&
                    whitePawnCount[4] == 0)
                {
                    board.score -= 20;
                }
                if (whitePawnCount[4] >= 1 && whitePawnCount[3] == 0 &&
                    whitePawnCount[5] == 0)
                {
                    board.score -= 20;
                }
                if (whitePawnCount[5] >= 1 && whitePawnCount[4] == 0 &&
                    whitePawnCount[6] == 0)
                {
                    board.score -= 16;
                }
                if (whitePawnCount[6] >= 1 && whitePawnCount[5] == 0 &&
                    whitePawnCount[7] == 0)
                {
                    board.score -= 14;
                }
                if (whitePawnCount[7] >= 1 && whitePawnCount[6] == 0)
                {
                    board.score -= 12;
                }
                #endregion

                #region Passed Pawns
                //Black Passed Pawns
                if (blackPawnCount[0] >= 1 && whitePawnCount[0] == 0)
                {
                    board.score -= blackPawnCount[0];
                }
                if (blackPawnCount[1] >= 1 && whitePawnCount[1] == 0)
                {
                    board.score -= blackPawnCount[1];
                }
                if (blackPawnCount[2] >= 1 && whitePawnCount[2] == 0)
                {
                    board.score -= blackPawnCount[2];
                }
                if (blackPawnCount[3] >= 1 && whitePawnCount[3] == 0)
                {
                    board.score -= blackPawnCount[3];
                }
                if (blackPawnCount[4] >= 1 && whitePawnCount[4] == 0)
                {
                    board.score -= blackPawnCount[4];
                }
                if (blackPawnCount[5] >= 1 && whitePawnCount[5] == 0)
                {
                    board.score -= blackPawnCount[5];
                }
                if (blackPawnCount[6] >= 1 && whitePawnCount[6] == 0)
                {
                    board.score -= blackPawnCount[6];
                }
                if (blackPawnCount[7] >= 1 && whitePawnCount[7] == 0)
                {
                    board.score -= blackPawnCount[7];
                }

                //White Passed Pawns
                if (whitePawnCount[0] >= 1 && blackPawnCount[1] == 0)
                {
                    board.score += whitePawnCount[0];
                }
                if (whitePawnCount[1] >= 1 && blackPawnCount[1] == 0)
                {
                    board.score += whitePawnCount[1];
                }
                if (whitePawnCount[2] >= 1 && blackPawnCount[2] == 0)
                {
                    board.score += whitePawnCount[2];
                }
                if (whitePawnCount[3] >= 1 && blackPawnCount[3] == 0)
                {
                    board.score += whitePawnCount[3];
                }
                if (whitePawnCount[4] >= 1 && blackPawnCount[4] == 0)
                {
                    board.score += whitePawnCount[4];
                }
                if (whitePawnCount[5] >= 1 && blackPawnCount[5] == 0)
                {
                    board.score += whitePawnCount[5];
                }
                if (whitePawnCount[6] >= 1 && blackPawnCount[6] == 0)
                {
                    board.score += whitePawnCount[6];
                }
                if (whitePawnCount[7] >= 1 && blackPawnCount[7] == 0)
                {
                    board.score += whitePawnCount[7];
                }
                #endregion
            }
        }

        public static Square alpha_betaPruning(List<Board> boardsWithScored)
        {
            Square bestSquareToMove = new Square(1, 1);

            return bestSquareToMove;
        }

        public static Square[] randomPlayingBlackPieces(Board board, bool isBlackChecked = false, bool isWhiteChecked = false)
        {
            Square res;
            // The first element is the square before choosing randomly
            // The second element is after choosing square randomly
            Square[] beforeAndAfterRandomChangeSquare = new Square[2];


            List<Square> possibleChessPieceToMove = new List<Square>();
            foreach (var square in board.allBlackChessPieceSquares(board))
            {
                if (Move.generateMoves(square, square.piece.type, board).Count != 0)
                {
                    //Console.WriteLine(square.piece.type);
                    possibleChessPieceToMove.Add(square);
                }
            }
            int randomNumber = (int)Math.Round((double)randomNumberGenerator(0, possibleChessPieceToMove.Count - 1));
            List<Square> squareCanMoveTo = Move.generateMoves(possibleChessPieceToMove[randomNumber], possibleChessPieceToMove[randomNumber].piece.type, board);
            int randomNumberForHighlitedSquares = (int)Math.Round((double)randomNumberGenerator(0, squareCanMoveTo.Count - 1));

            res = squareCanMoveTo[randomNumberForHighlitedSquares];
            res.piece.type = possibleChessPieceToMove[randomNumber].piece.type;

            TypeOfChessPiece typeOfChessPieceForExchanging = res.piece.type;
            beforeAndAfterRandomChangeSquare[0] = possibleChessPieceToMove[randomNumber];
            board.removeChessPiece(board, possibleChessPieceToMove[randomNumber]);
            beforeAndAfterRandomChangeSquare[1] = possibleChessPieceToMove[randomNumber];
            board.replaceChessPiece(board, res, typeOfChessPieceForExchanging);

            foreach (var square in board.squares)
            {
                if (square.getRow() == res.getRow() &&
                    square.getColumn() == res.getColumn())
                {
                    return beforeAndAfterRandomChangeSquare;
                }
            }
            return null;
        }

        public static int randomNumberGenerator(int min, int max)
        {
            Random random = new Random();
            int res = random.Next(min, max);
            return res;
        }



        
        
    }
}
