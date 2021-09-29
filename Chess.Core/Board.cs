using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Core;

namespace Chess.Core
{
    public class Board
    {
        public Board()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    squares[row, col] = new Square(row + 1, col + 1);
                }
            }
            initializeBoard();
        }

        public Square[,] squares = new Square[8, 8];

        //public float square;

        public bool insufficientMaterial;



        public void initializeBoard()
        {
            #region Black start position
            squares[0, 0].piece.type = TypeOfChessPiece.b_rook;
            squares[0, 1].piece.type = TypeOfChessPiece.b_knight;
            squares[0, 2].piece.type = TypeOfChessPiece.b_bishop;
            squares[0, 3].piece.type = TypeOfChessPiece.b_queen;
            squares[0, 4].piece.type = TypeOfChessPiece.b_king;
            squares[0, 5].piece.type = TypeOfChessPiece.b_bishop;
            squares[0, 6].piece.type = TypeOfChessPiece.b_knight;
            squares[0, 7].piece.type = TypeOfChessPiece.b_rook;

            squares[1, 0].piece.type = TypeOfChessPiece.b_pawn;
            squares[1, 1].piece.type = TypeOfChessPiece.b_pawn;
            squares[1, 2].piece.type = TypeOfChessPiece.b_pawn;
            squares[1, 3].piece.type = TypeOfChessPiece.b_pawn;
            squares[1, 4].piece.type = TypeOfChessPiece.b_pawn;
            squares[1, 5].piece.type = TypeOfChessPiece.b_pawn;
            squares[1, 6].piece.type = TypeOfChessPiece.b_pawn;
            squares[1, 7].piece.type = TypeOfChessPiece.b_pawn;

            
            
            #endregion
            #region White start position
            squares[7, 0].piece.type = TypeOfChessPiece.w_rook;
            squares[7, 1].piece.type = TypeOfChessPiece.w_knight;
            squares[7, 2].piece.type = TypeOfChessPiece.w_bishop;
            squares[7, 3].piece.type = TypeOfChessPiece.w_queen;
            squares[7, 4].piece.type = TypeOfChessPiece.w_king;
            squares[7, 5].piece.type = TypeOfChessPiece.w_bishop;
            squares[7, 6].piece.type = TypeOfChessPiece.w_knight;
            squares[7, 7].piece.type = TypeOfChessPiece.w_rook;

            squares[6, 0].piece.type = TypeOfChessPiece.w_pawn;
            squares[6, 1].piece.type = TypeOfChessPiece.w_pawn;
            squares[6, 2].piece.type = TypeOfChessPiece.w_pawn;
            squares[6, 3].piece.type = TypeOfChessPiece.w_pawn;
            squares[6, 4].piece.type = TypeOfChessPiece.w_pawn;
            squares[6, 5].piece.type = TypeOfChessPiece.w_pawn;
            squares[6, 6].piece.type = TypeOfChessPiece.w_pawn;
            squares[6, 7].piece.type = TypeOfChessPiece.w_pawn;
            #endregion
        }

        public List<Square> allWhiteChessPieceSquares(Core.Board chessBoard)
        {
            List<Square> whiteChessPieceSquares = new List<Square>();
            foreach (var square in chessBoard.squares)
            {
                if (square.piece.type == TypeOfChessPiece.w_bishop ||
                    square.piece.type == TypeOfChessPiece.w_rook ||
                    square.piece.type == TypeOfChessPiece.w_queen ||
                    square.piece.type == TypeOfChessPiece.w_king ||
                    square.piece.type == TypeOfChessPiece.w_pawn ||
                    square.piece.type == TypeOfChessPiece.w_knight)
                {
                    whiteChessPieceSquares.Add(square);
                }
            }
            return whiteChessPieceSquares;
        }

        public List<Square> allBlackChessPieceSquares(Core.Board chessBoard)
        {
            List<Square> blackChessPieceSquares = new List<Square>();
            foreach (var square in chessBoard.squares)
            {
                if (square.piece.type == TypeOfChessPiece.b_bishop ||
                    square.piece.type == TypeOfChessPiece.b_rook ||
                    square.piece.type == TypeOfChessPiece.b_queen ||
                    square.piece.type == TypeOfChessPiece.b_king ||
                    square.piece.type == TypeOfChessPiece.b_pawn ||
                    square.piece.type == TypeOfChessPiece.b_knight)
                {
                    blackChessPieceSquares.Add(square);
                }
            }
            return blackChessPieceSquares;
        }
        
        public bool isBlackChecked(Board board)
        {
            foreach (var square in board.squares)
            {
                // TODO: Remember that pawn has a diffrent story
                if (square.piece.type == TypeOfChessPiece.w_bishop ||
                    square.piece.type == TypeOfChessPiece.w_rook ||
                    square.piece.type == TypeOfChessPiece.w_knight ||
                    square.piece.type == TypeOfChessPiece.w_queen ||
                    square.piece.type == TypeOfChessPiece.w_king
                    )

                {
                    List<Square> squaresCanAttack = Move.generateMoves(square, square.piece.type, board);
                    
                    foreach (var squareCanAttack in squaresCanAttack)
                    {
                        foreach (var tempSquare in board.squares)
                        {
                            if (tempSquare.getRow() == squareCanAttack.getRow() &&
                                tempSquare.getColumn() == squareCanAttack.getColumn())
                            {
                                if (tempSquare.piece.type == TypeOfChessPiece.b_king)
                                {
                                    return true;
                                }
                            }
                        }
                        
                    }
                }
                else if (square.piece.type == TypeOfChessPiece.w_pawn)
                {
                    if (square.getRow() - 1 > 0 && square.getColumn() - 1 > 0)
                    {
                        if (board.squares[square.getRow() - 2, square.getColumn() - 2].piece.type == TypeOfChessPiece.b_king)
                        {
                            return true;
                        }
                    }

                    if (square.getRow() - 1 > 0 && square.getColumn() + 1 < 9)
                    {
                        if (board.squares[square.getRow() - 2, square.getColumn()].piece.type == TypeOfChessPiece.b_king)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool isWhiteChecked(Board board)
        {
            foreach (var square in board.squares)
            {
                // TODO: Remember that pawn has a diffrent story
                if (square.piece.type == TypeOfChessPiece.b_bishop ||
                    square.piece.type == TypeOfChessPiece.b_rook ||
                    square.piece.type == TypeOfChessPiece.b_knight ||
                    square.piece.type == TypeOfChessPiece.b_queen ||
                    square.piece.type == TypeOfChessPiece.b_king
                    )

                {
                    List<Square> squaresCanAttack = Move.generateMoves(square, square.piece.type, board);

                    foreach (var squareCanAttack in squaresCanAttack)
                    {
                        foreach (var tempSquare in board.squares)
                        {
                            if (tempSquare.getRow() == squareCanAttack.getRow() &&
                                tempSquare.getColumn() == squareCanAttack.getColumn())
                            {
                                if (tempSquare.piece.type == TypeOfChessPiece.w_king)
                                {
                                    return true;
                                }
                            }
                        }

                    }
                }
                else if (square.piece.type == TypeOfChessPiece.b_pawn)
                {
                    if (square.getRow() + 1 < 9 && square.getColumn() - 1 > 0)
                    {
                        if (board.squares[square.getRow(), square.getColumn() - 2].piece.type == TypeOfChessPiece.b_king)
                        {
                            return true;
                        }
                    }

                    if (square.getRow() + 1 < 9 && square.getColumn() + 1 < 9)
                    {
             
                        if (board.squares[square.getRow(), square.getColumn()].piece.type == TypeOfChessPiece.b_king)
                        {
             
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void removeChessPiece(Board board, Square square)
        {
            foreach (var tempSquare in board.squares)
            {
                if (tempSquare.getRow() == square.getRow() &&
                    tempSquare.getColumn() == square.getColumn())
                {
                    tempSquare.piece.type = TypeOfChessPiece.NaP;
                }
            }
        }

        public void replaceChessPiece (Board board, Square square, TypeOfChessPiece typeOfChessPieceWantToReplaceWith)
        {
            foreach (var tempSquare in board.squares)
            {
                if (tempSquare.getRow() == square.getRow() &&
                    tempSquare.getColumn() == square.getColumn())
                {
                    tempSquare.piece.type = typeOfChessPieceWantToReplaceWith;
                }
            }
        }

        internal bool blackCastled;
        internal bool whiteCastled;
        internal bool blackMate;
        internal bool whiteMate;
        internal bool whiteCheck;
        internal bool blackCheck;
        internal bool endGamePhase;
        internal bool isWhiteTurn;
        public int score;
        public int fiftyMvoeCount;
        
        public Board copy()
        {
            Board temp = new Board();
            temp.blackCastled = blackCastled;
            temp.whiteCastled = whiteCastled;
            temp.blackMate = blackMate;
            temp.whiteMate = whiteMate;
            temp.whiteCheck = whiteCheck;
            temp.blackCheck = blackCheck;
            temp.endGamePhase = endGamePhase;
            temp.isWhiteTurn = isWhiteTurn;
            temp.score = score;
            temp.fiftyMvoeCount = fiftyMvoeCount;
            return temp;
        }
        
        //public bool isBlackCheckedMate(Board board)
        //{ }

        //public bool isWhiteCheckedMate(Board board)
        //{ }
        


    }
}