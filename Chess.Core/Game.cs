using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Chess.Core;

namespace Chess.Core
{
    public class Game
    {
        public Game(Board board)
        {
            this.board = board;
        }
        
        private Board board;

        public bool whiteTurn = false;
        public bool blackTurn = false;
        public bool whiteCheckMate = false;
        public bool blackCheckMate = false;
        public bool draw = false;

        // Here we must pass value to the function
        public string startGame(ref bool isWhiteTurn, ref bool isBlackTurn)
        {
            for (int i = 0; i < 100; i++)
            {
                if (!whiteCheckMate && !blackCheckMate && !draw)
                {
                    if (i%2 == 0)
                    {
                        if (isWhiteTurn)
                        {
                            whiteTurnToAct(ref isWhiteTurn, ref isBlackTurn);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        if (isBlackTurn)
                        {
                            blackTurnToAct(ref isWhiteTurn, ref isBlackTurn);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            if (whiteCheckMate == true)
            {
                return "Black wins"; 
            }
            else if (blackCheckMate == true)
            {
                return "White wins";
            }
            else
            {
                return "Draw";
            }
        }
        
        public void whiteTurnToAct(ref bool isWhiteTurn, ref bool isBlackTurn)
        {
            Console.WriteLine("white turn to act");
            isWhiteTurn = false;
            isBlackTurn = true;
        }

        public void blackTurnToAct(ref bool isWhiteTurn, ref bool isBlackTurn)
        {
            Console.WriteLine("Black turn to act");
            //Square moveSquare = AI.alpha_betaPruning(AI.evalutionFunction(board));
            //board.removeChessPiece(board, moveSquare);
            //board.replaceChessPiece(board, moveSquare, moveSquare.piece.type);
            isWhiteTurn = true;
            isBlackTurn = false;
        }
    }
}
