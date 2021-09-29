using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Chess.Core
{
    public static class Move
    {
        public static List<Square> generateMoves(Square currentSquare, TypeOfChessPiece typeOfChessPiece, Board board)
        {
            List<Square> squareCanMove = new List<Square>();
            #region Chess pieces movable squares
            if (typeOfChessPiece == TypeOfChessPiece.b_bishop || typeOfChessPiece == TypeOfChessPiece.w_bishop)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.getRow() + i < 9 && currentSquare.getColumn() + i < 9)
                    {
                        if (typeOfChessPiece == TypeOfChessPiece.b_bishop)
                        {
                            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {

                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() + i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() + i));
                                }
                            }

                        }
                        else if (typeOfChessPiece == TypeOfChessPiece.w_bishop)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() + i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() + i));
                                }
                            }

                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.getRow() - i > 0 && currentSquare.getColumn() + i < 9)
                    {
                        if (typeOfChessPiece == TypeOfChessPiece.b_bishop)
                        {
                            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight
                                    )
                                {

                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() + i));


                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() + i));
                                }
                            }
                        }
                        else if (typeOfChessPiece == TypeOfChessPiece.w_bishop)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight
                                    )
                                {

                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() + i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() + i));
                                }
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.getRow() + i < 9 && currentSquare.getColumn() - i > 0)
                    {
                        if (typeOfChessPiece == TypeOfChessPiece.b_bishop)
                        {
                            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() - i));
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() - i));
                                }
                            }
                        }
                        else if (typeOfChessPiece == TypeOfChessPiece.w_bishop)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight
                                    )
                                {

                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() - i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() - i));
                                }
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }

                }

                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.getRow() - i > 0 && currentSquare.getColumn() - i > 0)
                    {
                        if (typeOfChessPiece == TypeOfChessPiece.b_bishop)
                        {
                            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() - i));
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() - i));
                                }
                            }
                        }
                        else if (typeOfChessPiece == TypeOfChessPiece.w_bishop)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight
                                    )
                                {

                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() - i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() - i));
                                }
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            else if (typeOfChessPiece == TypeOfChessPiece.b_queen || typeOfChessPiece == TypeOfChessPiece.w_queen)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.getRow() + i < 9 && currentSquare.getColumn() + i < 9)
                    {
                        if (typeOfChessPiece == TypeOfChessPiece.b_queen)
                        {
                            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() + i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() + i));
                                }
                            }

                        }
                        else if (typeOfChessPiece == TypeOfChessPiece.w_queen)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() + i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() + i));
                                }
                            }

                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    #region code for generating all movable squares
                    //if (currentSquare.getRow() + i < 9 && currentSquare.getColumn() + i < 9)
                    //{
                    //    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow() + i, currentSquare.getColumn() + i))
                    //    {
                    //        squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() + i));
                    //        //DEBUG: Console.WriteLine("Add 1: " + (currentSquare.getRow() + i).ToString() + " " + (currentSquare.getColumn() + i).ToString() + "  i = " + i);
                    //    }
                    //}
                    #endregion
                }

                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.getRow() - i > 0 && currentSquare.getColumn() + i < 9)
                    {
                        if (typeOfChessPiece == TypeOfChessPiece.b_queen)
                        {
                            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() + i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() + i));
                                }
                            }

                        }
                        else if (typeOfChessPiece == TypeOfChessPiece.w_queen)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    //squareCanMove.Add(searchSquares(board, currentSquare.getRow(), currentSquare.getColumn()));
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() + i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() + i));
                                }
                            }

                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.getRow() + i < 9 && currentSquare.getColumn() - i > 0)
                    {
                        if (typeOfChessPiece == TypeOfChessPiece.b_queen)
                        {
                            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() - i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() - i));
                                }
                            }

                        }
                        else if (typeOfChessPiece == TypeOfChessPiece.w_queen)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() - i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn() - i));
                                }
                            }

                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.getRow() - i > 0 && currentSquare.getColumn() - i > 0)
                    {
                        if (typeOfChessPiece == TypeOfChessPiece.b_queen)
                        {
                            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() - i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() - i));
                                }
                            }

                        }
                        else if (typeOfChessPiece == TypeOfChessPiece.w_queen)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight
                                    )
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() - i));

                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn() - i));
                                }
                            }

                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    if (i != 0)
                    {
                         
                        if (currentSquare.getRow() - i > 0)
                        {
                            if (typeOfChessPiece == TypeOfChessPiece.w_queen)
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow() - i, currentSquare.getColumn()))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));
                                }
                            }
                            else if (typeOfChessPiece == TypeOfChessPiece.b_queen)
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow() - i, currentSquare.getColumn()))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));
                                }
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.getRow() + i < 9)
                    {
                        if (i != 0)
                        {
                            if (typeOfChessPiece == TypeOfChessPiece.w_queen)
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow() + i, currentSquare.getColumn()))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));
                                }
                            }
                            else if (typeOfChessPiece == TypeOfChessPiece.b_queen)
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow() + i, currentSquare.getColumn()))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));
                                }
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.getColumn() - i > 0)
                    {
                        if (i != 0)
                        {
                            if (typeOfChessPiece == TypeOfChessPiece.w_queen)
                            {
                                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow(), currentSquare.getColumn() - i))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));
                                }
                            }
                            else if (typeOfChessPiece == TypeOfChessPiece.b_queen)
                            {
                                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow(), currentSquare.getColumn() - i))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));
                                }
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    if (currentSquare.getColumn() + i < 9)
                    {
                        if (i != 0)
                        {
                            if (typeOfChessPiece == TypeOfChessPiece.w_queen)
                            {
                                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow(), currentSquare.getColumn() + i))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                                }
                            }
                            else if (typeOfChessPiece == TypeOfChessPiece.b_queen)
                            {
                                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow(), currentSquare.getColumn() + i))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                                }
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                }
                #region Commnet

                //for (int i = 0; i < 8; i++)
                //{
                //    if (currentSquare.getRow() - i > 0)
                //    {

                //        if (typeOfChessPiece == TypeOfChessPiece.b_queen || !isWhiteTurnToMove)
                //        {
                //            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                //            {
                //                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight
                //                    )
                //                {
                //                    break;
                //                }
                //                else if (board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight)
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));

                //                    break;
                //                }
                //                else
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));
                //                }
                //            }

                //        }
                //        else if (typeOfChessPiece == TypeOfChessPiece.w_queen || isWhiteTurnToMove)
                //        {
                //            if (i != 0)
                //            {
                //                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight
                //                    )
                //                {
                //                    break;
                //                }
                //                else if (board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                //                    board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight)
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));

                //                    break;
                //                }
                //                else
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));
                //                }
                //            }

                //        }
                //        else
                //        {
                //            throw new Exception();
                //        }
                //    }

                //    if (currentSquare.getRow() + i < 9)
                //    {
                //        if (typeOfChessPiece == TypeOfChessPiece.b_queen)
                //        {
                //            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                //            {
                //                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight
                //                    )
                //                {
                //                    break;
                //                }
                //                else if (board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight)
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));

                //                    break;
                //                }
                //                else
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));
                //                }
                //            }

                //        }
                //        else if (typeOfChessPiece == TypeOfChessPiece.w_queen)
                //        {
                //            if (i != 0)
                //            {
                //                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight
                //                    )
                //                {
                //                    break;
                //                }
                //                else if (board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                //                    board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight)
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));

                //                    break;
                //                }
                //                //else
                //                //{
                //                //    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));
                //                //}
                //            }

                //        }
                //    }
                //}

                //for (int i = 0; i < 8; i++)
                //{
                //    if (currentSquare.getColumn() - i > 0)
                //    {
                //        if (typeOfChessPiece == TypeOfChessPiece.b_queen || !isWhiteTurnToMove)
                //        {
                //            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                //            {
                //                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight
                //                    )
                //                {
                //                    break;
                //                }
                //                else if (board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight)
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));

                //                    break;
                //                }
                //                else
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));
                //                }
                //            }

                //        }
                //        else if (typeOfChessPiece == TypeOfChessPiece.w_queen || isWhiteTurnToMove)
                //        {
                //            if (i != 0)
                //            {
                //                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight
                //                    )
                //                {
                //                    break;
                //                }
                //                else if (board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight)
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));

                //                    break;
                //                }
                //                else
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));
                //                }
                //            }

                //        }
                //        else
                //        {
                //            throw new Exception();
                //        }

                //    }
                //    if (currentSquare.getColumn() + i < 9)
                //    {
                //        if (typeOfChessPiece == TypeOfChessPiece.b_queen)
                //        {
                //            if (i != 0) // because i = 0 return the current square of the chessPiece and if we don't use this, then 
                //            {
                //                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight
                //                    )
                //                {
                //                    break;
                //                }
                //                else if (board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight)
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));

                //                    break;
                //                }
                //                else
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                //                }
                //            }

                //        }
                //        else if (typeOfChessPiece == TypeOfChessPiece.w_queen)
                //        {
                //            if (i != 0)
                //            {
                //                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight
                //                    )
                //                {
                //                    break;
                //                }
                //                else if (board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                //                    board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight)
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));

                //                    break;
                //                }
                //                else
                //                {
                //                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                //                }
                //            }

                //        }
                //        else
                //        {
                //            if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow(), currentSquare.getColumn() + i))
                //            {
                //                squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                //            }
                //        }
                //        //if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow(), currentSquare.getColumn() + i))
                //        //    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                //    }
                //}

                #endregion
            }
            else if (typeOfChessPiece == TypeOfChessPiece.b_king || typeOfChessPiece == TypeOfChessPiece.w_king)
            {
                if (currentSquare.getRow() + 1 < 9)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_king)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn()));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_king)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn()));
                        }
                    }
                }
                if (currentSquare.getRow() - 1 > 0)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_king)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn()));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_king)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn()));
                        }
                    }
                }
                if (currentSquare.getColumn() + 1 < 9)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_king)
                    {
                        if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + 1));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_king)
                    {
                        if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + 1));
                        }
                    }
                }
                if (currentSquare.getColumn() - 1 > 0)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_king) 
                    {
                        if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - 1));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_king)
                    {
                        if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - 1));
                        }
                    }
                }
                if (currentSquare.getRow() + 1 < 9 && currentSquare.getColumn() + 1 < 9)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_king)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() + 1));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_king)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() + 1));
                        }
                    }
                }
                if (currentSquare.getRow() - 1 > 0 && currentSquare.getColumn() + 1 < 9)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_king)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() + 1));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_king)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() + 1));
                        }
                    }
                }
                if (currentSquare.getRow() - 1 > 0 && currentSquare.getColumn() - 1 > 0)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_king)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() - 1));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_king)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() - 1));
                        }
                    }
                }
                if (currentSquare.getRow() + 1 < 9 && currentSquare.getColumn() - 1 > 0)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_king)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() - 1));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_king)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() - 1));
                        }
                    }
                }
            }
            else if (typeOfChessPiece == TypeOfChessPiece.b_pawn || typeOfChessPiece == TypeOfChessPiece.w_pawn)
            {
                if (typeOfChessPiece == TypeOfChessPiece.b_pawn)
                {
                    if (currentSquare.getRow() == 2)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight
                                )
                        {
                        }
                        else if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight
                                )
                        {

                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn()));
                            if (board.squares[currentSquare.getRow() + 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight
                                    )
                            {

                            }
                            else if (board.squares[currentSquare.getRow() + 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight
                                    )
                            {

                            }
                            else
                            {
                                squareCanMove.Add(new Square(currentSquare.getRow() + 2, currentSquare.getColumn()));
                            }
                        }
                    }
                    else if (currentSquare.getRow() < 8)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                        }
                        else if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight
                                    )
                        {

                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn()));
                        }
                    }
                    //TODO: when pawn reach the last square of chess board then it must converted to anything that user want
                    else
                    {
                        //throw new Exception(); // Pawn here must be converted to a queen already
                        Console.WriteLine("Pawn here must be converted to queen.");

                    }
                    if (currentSquare.getRow() + 1 < 9 &&
                        currentSquare.getColumn() - 1 > 0)
                    {
                        foreach (var square in board.squares)
                        {
                            if (square.getRow() == currentSquare.getRow() + 1 &&
                                square.getColumn() == currentSquare.getColumn() - 1)
                            {
                                if (square.piece.type == TypeOfChessPiece.w_pawn ||
                                    square.piece.type == TypeOfChessPiece.w_bishop ||
                                    square.piece.type == TypeOfChessPiece.w_queen ||
                                    square.piece.type == TypeOfChessPiece.w_king ||
                                    square.piece.type == TypeOfChessPiece.w_rook ||
                                    square.piece.type == TypeOfChessPiece.w_knight
                                    )
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() - 1));
                                }
                            }
                        }
                    }

                    if (currentSquare.getRow() + 1 < 9 &&
                        currentSquare.getColumn() + 1 < 9)
                    {
                        foreach (var square in board.squares)
                        {
                            if (square.getRow() == currentSquare.getRow() + 1 &&
                                square.getColumn() == currentSquare.getColumn() + 1)
                            {
                                if (square.piece.type == TypeOfChessPiece.w_pawn ||
                                    square.piece.type == TypeOfChessPiece.w_bishop ||
                                    square.piece.type == TypeOfChessPiece.w_queen ||
                                    square.piece.type == TypeOfChessPiece.w_king ||
                                    square.piece.type == TypeOfChessPiece.w_rook ||
                                    square.piece.type == TypeOfChessPiece.w_knight
                                    )
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() + 1));
                                }
                            }
                        }
                    }

                    #region Code for generating all moves
                    //if (currentSquare.getRow() == 2)
                    //{
                    //    squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn()));
                    //    squareCanMove.Add(new Square(currentSquare.getRow() + 2, currentSquare.getColumn()));
                    //}
                    //else
                    //{
                    //    squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn()));
                    //}
                    #endregion
                }
                else if (typeOfChessPiece == TypeOfChessPiece.w_pawn)
                {
                    if (currentSquare.getRow() == 7)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight
                                )
                        {
                        }
                        else if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight
                                )
                        {

                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn()));
                            if (board.squares[currentSquare.getRow() - 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                    board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                    board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                    board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                    board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                    board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight
                                    )
                            {

                            }
                            else if (board.squares[currentSquare.getRow() - 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight
                                    )
                            {

                            }
                            else
                            {
                                squareCanMove.Add(new Square(currentSquare.getRow() - 2, currentSquare.getColumn()));
                            }
                        }
                    }
                    else if (currentSquare.getRow() > 1)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                        }
                        else if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                    board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                    board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                    board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                    board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                    board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight
                                    )
                        {

                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn()));
                        }
                    }
                    else
                    {
                        board.replaceChessPiece(board, currentSquare, TypeOfChessPiece.w_queen);
                    }

                    if (currentSquare.getRow() - 1 > 0 &&
                        currentSquare.getColumn() - 1 > 0)
                    {
                        foreach (var square in board.squares)
                        {
                            if (square.getRow() == currentSquare.getRow() - 1 &&
                                square.getColumn() == currentSquare.getColumn() - 1)
                            {
                                if (square.piece.type == TypeOfChessPiece.b_pawn ||
                                    square.piece.type == TypeOfChessPiece.b_bishop ||
                                    square.piece.type == TypeOfChessPiece.b_queen ||
                                    square.piece.type == TypeOfChessPiece.b_king ||
                                    square.piece.type == TypeOfChessPiece.b_rook ||
                                    square.piece.type == TypeOfChessPiece.b_knight
                                    )
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() - 1));
                                }
                            }
                        }
                    }

                    if (
                        currentSquare.getRow() - 1 > 0 &&
                        currentSquare.getColumn() + 1 < 9)
                    {
                        foreach (var square in board.squares)
                        {
                            if (square.getRow() == currentSquare.getRow() - 1 &&
                                square.getColumn() == currentSquare.getColumn() + 1)
                            {
                                if (square.piece.type == TypeOfChessPiece.b_pawn ||
                                    square.piece.type == TypeOfChessPiece.b_bishop ||
                                    square.piece.type == TypeOfChessPiece.b_queen ||
                                    square.piece.type == TypeOfChessPiece.b_king ||
                                    square.piece.type == TypeOfChessPiece.b_rook ||
                                    square.piece.type == TypeOfChessPiece.b_knight
                                    )
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() + 1));
                                }
                            }
                        }
                    }
                    #region Code for generating all Moves
                    //if (currentSquare.getRow() == 7)
                    //{
                    //    squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn()));
                    //    squareCanMove.Add(new Square(currentSquare.getRow() - 2, currentSquare.getColumn()));
                    //}
                    //else
                    //{
                    //    squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn()));
                    //}
                    #endregion
                }
                else
                {
                    throw new Exception();
                }

            }
            else if (typeOfChessPiece == TypeOfChessPiece.b_knight || typeOfChessPiece == TypeOfChessPiece.w_knight)
            {
                if (currentSquare.getRow() + 2 < 9 && currentSquare.getColumn() + 1 < 9)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_knight)
                    {
                        if (board.squares[currentSquare.getRow() + 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() + 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 2, currentSquare.getColumn() + 1));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 2, currentSquare.getColumn() + 1));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_knight)
                    {
                        if (board.squares[currentSquare.getRow() + 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() + 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 2, currentSquare.getColumn() + 1));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 2, currentSquare.getColumn() + 1));
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

                if (currentSquare.getRow() + 2 < 9 && currentSquare.getColumn() - 1 > 0)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_knight)
                    {
                        if (board.squares[currentSquare.getRow() + 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() + 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 2, currentSquare.getColumn() - 1));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 2, currentSquare.getColumn() - 1));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_knight)
                    {
                        if (board.squares[currentSquare.getRow() + 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() + 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 2, currentSquare.getColumn() - 1));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 2, currentSquare.getColumn() - 1));
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }

                }

                if (currentSquare.getRow() - 2 > 0 && currentSquare.getColumn() + 1 < 9)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_knight)
                    {
                        if (board.squares[currentSquare.getRow() - 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() - 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 2, currentSquare.getColumn() + 1));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 2, currentSquare.getColumn() + 1));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_knight)
                    {
                        if (board.squares[currentSquare.getRow() - 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() - 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() + 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 2, currentSquare.getColumn() + 1));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 2, currentSquare.getColumn() + 1));
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

                if (currentSquare.getRow() - 2 > 0 && currentSquare.getColumn() - 1 > 0)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_knight)
                    {
                        if (board.squares[currentSquare.getRow() - 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() - 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 2, currentSquare.getColumn() - 1));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 2, currentSquare.getColumn() - 1));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_knight)
                    {
                        if (board.squares[currentSquare.getRow() - 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() - 2 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 2 - 1, currentSquare.getColumn() - 1 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 2, currentSquare.getColumn() - 1));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 2, currentSquare.getColumn() - 1));
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

                if (currentSquare.getRow() + 1 < 9 && currentSquare.getColumn() + 2 < 9)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_knight)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() + 2));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() + 2));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_knight)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() + 2));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() + 2));
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }

                }

                if (currentSquare.getRow() - 1 > 0 && currentSquare.getColumn() + 2 < 8)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_knight)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() + 2));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() + 2));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_knight)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() + 2 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() + 2));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() + 2));
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

                if (currentSquare.getRow() + 1 < 8 && currentSquare.getColumn() - 2 > 0)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_knight)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() - 2));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() - 2));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_knight)
                    {
                        if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() + 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() + 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() - 2));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() + 1, currentSquare.getColumn() - 2));
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

                if (currentSquare.getRow() - 1 > 0 && currentSquare.getColumn() - 2 > 0)
                {
                    if (typeOfChessPiece == TypeOfChessPiece.b_knight)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() - 2));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() - 2));
                        }
                    }
                    else if (typeOfChessPiece == TypeOfChessPiece.w_knight)
                    {
                        if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.w_knight
                            )
                        {

                        }
                        else if (board.squares[currentSquare.getRow() - 1 - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_bishop ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_pawn ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_rook ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_queen ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_king ||
                            board.squares[currentSquare.getRow() - 1 - 1, currentSquare.getColumn() - 2 - 1].piece.type == TypeOfChessPiece.b_knight
                            )
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() - 2));
                        }
                        else
                        {
                            squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() - 2));
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }

                    //squareCanMove.Add(new Square(currentSquare.getRow() - 1, currentSquare.getColumn() - 2));
                }
            }
            else if (typeOfChessPiece == TypeOfChessPiece.b_rook || typeOfChessPiece == TypeOfChessPiece.w_rook)
            {
                if (typeOfChessPiece == TypeOfChessPiece.b_rook)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (currentSquare.getRow() - i > 0)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));
                                }
                            }
                        }
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        if (currentSquare.getRow() + i < 9)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow() + i, currentSquare.getColumn()))
                                    {

                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));
                                }
                            }
                        }
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        if (currentSquare.getColumn() - i > 0)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow(), currentSquare.getColumn() - i))
                                    {

                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));
                                }
                            }
                        }
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        if (currentSquare.getColumn() + i < 9)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow(), currentSquare.getColumn() + i))
                                    {

                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                                }
                            }
                        }

                    }
                    
                }
                else if (typeOfChessPiece == TypeOfChessPiece.w_rook)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (i != 0)
                        {

                            if (currentSquare.getRow() - i > 0)
                            {
                                if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() - i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow() - i, currentSquare.getColumn()))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() - i, currentSquare.getColumn()));
                                }
                            }
                        }
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        if (currentSquare.getRow() + i < 9)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() + i - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() + i - 1, currentSquare.getColumn() - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow() + i, currentSquare.getColumn()))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow() + i, currentSquare.getColumn()));
                                }
                            }
                        }
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        if (currentSquare.getColumn() - i > 0)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow(), currentSquare.getColumn() - i))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() - i));
                                }
                            }
                        }
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        if (currentSquare.getColumn() + i < 9)
                        {
                            if (i != 0)
                            {
                                if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.w_knight)
                                {
                                    break;
                                }
                                else if (board.squares[currentSquare.getRow() - 1 /*we use this -1 because array start with 0 and we should minus it by one.*/, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_bishop ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_rook ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_pawn ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_queen ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_king ||
                                        board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() + i - 1].piece.type == TypeOfChessPiece.b_knight)
                                {
                                    if (!isSomeItemExistInPossibleMoveList(squareCanMove, currentSquare.getRow(), currentSquare.getColumn() + i))
                                    {
                                        squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                                    }
                                    break;
                                }
                                else
                                {
                                    squareCanMove.Add(new Square(currentSquare.getRow(), currentSquare.getColumn() + i));
                                }
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            #endregion
            return squareCanMove;
        }

        private static bool isSomeItemExistInPossibleMoveList(List<Square> searchSquareCanMove, int row, int col)
        {
            foreach (var item in searchSquareCanMove)
            {
                if (item.getRow() == row && item.getColumn() == col)
                {
                    return true;
                }
            }
            return false;
        }

        public static void moveChessPieceToChoosenSquare(Board board, TypeOfChessPiece typeOfChessPiece, Square choosenSquare, Square currentSquare)
        {
            board.squares[currentSquare.getRow() - 1, currentSquare.getColumn() - 1].piece.type = TypeOfChessPiece.NaP;
            board.squares[choosenSquare.getRow() - 1, choosenSquare.getColumn() - 1].piece.type = typeOfChessPiece;

        }
        
        public static List<Square> attackableSquares(Board board, Square currentSquare, TypeOfChessPiece typeOfChessPiece)
        {
            List<Square> attackableSquares = new List<Square>();
            if (typeOfChessPiece == TypeOfChessPiece.b_pawn)
            {
                if (currentSquare.getRow() + 1 < 9 && currentSquare.getColumn() - 1 > 0)
                {
                    attackableSquares.Add(board.squares[currentSquare.getRow(), currentSquare.getColumn() - 2]);
                }
                if (currentSquare.getRow() + 1 < 9 && currentSquare.getColumn() + 1 < 9)
                {
                    attackableSquares.Add(board.squares[currentSquare.getRow(), currentSquare.getColumn()]);
                }
                return attackableSquares;
            }
            else if (typeOfChessPiece == TypeOfChessPiece.w_pawn)
            {
                if (currentSquare.getRow() - 1 > 0 && currentSquare.getColumn() - 1 > 0)
                {
                    attackableSquares.Add(board.squares[currentSquare.getRow() - 2, currentSquare.getColumn() - 2]);
                }
                if (currentSquare.getRow() - 1 > 0 && currentSquare.getColumn() + 1 < 9)
                {
                    attackableSquares.Add(board.squares[currentSquare.getRow() - 2, currentSquare.getColumn()]);
                }
                return attackableSquares;
            }
            else if (typeOfChessPiece == TypeOfChessPiece.NaP)
            {
                return null;
            }
            else
            {
                attackableSquares = generateMoves(currentSquare, typeOfChessPiece, board);
            }
                
            return attackableSquares;
        }

    }
}
