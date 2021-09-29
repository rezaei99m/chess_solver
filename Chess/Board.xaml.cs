using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Chess;
using Chess.BusinessLayer;
using Chess.Core;

namespace Chess
{
   
    public partial class Board : Window
    {
        public Core.Board board;
        
        private bool isWhiteTurn;
        private bool isBlackTurn;
        private bool isWhiteChessPieceSelected = false;
        private List<Square> highlitedSquaresForWhite = new List<Square>();
        private bool isWhiteHighlitedSquareSelected = false;
        private Square tempWhiteSquare;
        public Rectangle tempWhiteSquareRectangle;
        public Rectangle tempWhiteHighlitedSquareRectangle;
        
        #region Comment Area
        //private bool isWhiteSelectedForMove = false;

        //private bool isWhiteSelectedForMovingToNewSquare = false;

        //private Square whiteCurrentSquare;

        //private bool isBlackSelectedForMove = false;
        //private bool isBlackTurn = false;
        //private bool isBlackSelectedForMovingToNewSquare = false;
        //private List<Square> highlitedSquaresForBlack = new List<Square>();
        //private Square blackTempSquare;
        #endregion
        public Board()
        {
            isWhiteTurn = true;
            isBlackTurn = false;
            board = new Core.Board();
            InitializeComponent();
            initializeBoardForFirstTime(board);
        }
        
        public void initializeBoardForFirstTime(Core.Board board)
        {
            var rectanglesList = returnAllRectangle();
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    #region White chess piece start position
                    if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.w_queen)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() ==  rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.w_queen);
                            }
                        }
                    }
                    else if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.w_bishop)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() == rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.w_bishop);
                            }
                        }
                    }
                    else if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.w_rook)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() == rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.w_rook);
                            }
                        }
                    }
                    else if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.w_king)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() == rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.w_king);
                            }
                        }
                    }
                    else if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.w_pawn)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() == rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.w_pawn);
                            }
                        }
                    }
                    else if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.w_knight)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() == rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.w_knight);
                            }
                        }
                    }
                    #endregion
                    #region Black chess piece start position
                    if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.b_queen)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() == rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.b_queen);
                            }
                        }
                    }
                    else if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.b_bishop)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() == rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.b_bishop);
                            }
                        }
                    }
                    else if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.b_rook)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() == rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.b_rook);
                            }
                        }
                    }
                    else if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.b_king)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() == rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.b_king);
                            }
                        }
                    }
                    else if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.b_pawn)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() == rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.b_pawn);
                            }
                        }
                    }
                    else if (board.squares[row, col].piece.type == Core.TypeOfChessPiece.b_knight)
                    {
                        for (int i = 0; i < rectanglesList.Count; i++)
                        {
                            var dummyRow = row + 1;
                            var dummyCol = col + 1;
                            string rectangleName = "_" + dummyRow + dummyCol + "r";
                            if (rectanglesList[i].Name.ToString() == rectangleName)
                            {
                                UI_Static.setSquareChessPiece(rectanglesList[i], Core.TypeOfChessPiece.b_knight);
                            }
                        }
                    }
                    #endregion
                }
            }
        }

        public void highlightPossibleMoveSquares(List<Square> squares)
        {
            var gridsList = returnAllGrids();
            foreach (var square in squares)
            {
                for (int i = 0; i < gridsList.Count; i++)
                {
                    if (gridsList[i].Name == ("_" + square.getRow() + square.getColumn()).ToString())
                    {
                        gridsList[i].Background = new SolidColorBrush(Color.FromArgb(255, 50, 120, 146)); //Beautiful color. 250, 54, 120, 146

                    }
                }
            }
        }

        public void clearBoard()
        {
            var gridsList = returnAllGrids();
            foreach (var grid in gridsList)
            {
                if (whiteBackgroundSquaresName().Contains(grid.Name))
                {
                    grid.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                }
                else if (blackBackgroundSquaresNames().Contains(grid.Name))
                {
                    grid.Background = new SolidColorBrush(Color.FromArgb(255,209,206,206));
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        
        public List<string> whiteBackgroundSquaresName()
        {
            List<string> whiteGrids = new List<string>();

            whiteGrids.Add("_11");
            whiteGrids.Add("_31");
            whiteGrids.Add("_51");
            whiteGrids.Add("_71");

            whiteGrids.Add("_22");
            whiteGrids.Add("_42");
            whiteGrids.Add("_62");
            whiteGrids.Add("_82");

            whiteGrids.Add("_13");
            whiteGrids.Add("_33");
            whiteGrids.Add("_53");
            whiteGrids.Add("_73");

            whiteGrids.Add("_24");
            whiteGrids.Add("_44");
            whiteGrids.Add("_64");
            whiteGrids.Add("_84");

            whiteGrids.Add("_15");
            whiteGrids.Add("_35");
            whiteGrids.Add("_55");
            whiteGrids.Add("_75");

            whiteGrids.Add("_26");
            whiteGrids.Add("_46");
            whiteGrids.Add("_66");
            whiteGrids.Add("_86");

            whiteGrids.Add("_17");
            whiteGrids.Add("_37");
            whiteGrids.Add("_77");
            whiteGrids.Add("_57");

            whiteGrids.Add("_28");
            whiteGrids.Add("_48");
            whiteGrids.Add("_68");
            whiteGrids.Add("_88");

            return whiteGrids;
        }

        public List<string> blackBackgroundSquaresNames()
        {
            List<string> blackGrids = new List<string>();
            blackGrids.Add("_21");
            blackGrids.Add("_41");
            blackGrids.Add("_61");
            blackGrids.Add("_81");

            blackGrids.Add("_12");
            blackGrids.Add("_32");
            blackGrids.Add("_52");
            blackGrids.Add("_72");

            blackGrids.Add("_23");
            blackGrids.Add("_43");
            blackGrids.Add("_63");
            blackGrids.Add("_83");

            blackGrids.Add("_14");
            blackGrids.Add("_34");
            blackGrids.Add("_54");
            blackGrids.Add("_74");

            blackGrids.Add("_25");
            blackGrids.Add("_45");
            blackGrids.Add("_65");
            blackGrids.Add("_85");

            blackGrids.Add("_16");
            blackGrids.Add("_36");
            blackGrids.Add("_56");
            blackGrids.Add("_76");

            blackGrids.Add("_27");
            blackGrids.Add("_47");
            blackGrids.Add("_67");
            blackGrids.Add("_87");

            blackGrids.Add("_18");
            blackGrids.Add("_38");
            blackGrids.Add("_58");
            blackGrids.Add("_78");
            return blackGrids;
        }

        public List<Rectangle> returnAllRectangle()
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            #region Rectangles List
            rectangles.Add(_11r);
            rectangles.Add(_12r);
            rectangles.Add(_13r);
            rectangles.Add(_14r);
            rectangles.Add(_15r);
            rectangles.Add(_16r);
            rectangles.Add(_17r);
            rectangles.Add(_18r);
            
            rectangles.Add(_21r);
            rectangles.Add(_22r);
            rectangles.Add(_23r);
            rectangles.Add(_24r);
            rectangles.Add(_25r);
            rectangles.Add(_26r);
            rectangles.Add(_27r);
            rectangles.Add(_28r);
            
            rectangles.Add(_31r);
            rectangles.Add(_32r);
            rectangles.Add(_33r);
            rectangles.Add(_34r);
            rectangles.Add(_35r);
            rectangles.Add(_36r);
            rectangles.Add(_37r);
            rectangles.Add(_38r);
            
            rectangles.Add(_41r);
            rectangles.Add(_42r);
            rectangles.Add(_43r);
            rectangles.Add(_44r);
            rectangles.Add(_45r);
            rectangles.Add(_46r);
            rectangles.Add(_47r);
            rectangles.Add(_48r);
            
            rectangles.Add(_51r);
            rectangles.Add(_52r);
            rectangles.Add(_53r);
            rectangles.Add(_54r);
            rectangles.Add(_55r);
            rectangles.Add(_56r);
            rectangles.Add(_57r);
            rectangles.Add(_58r);
            
            rectangles.Add(_61r);
            rectangles.Add(_62r);
            rectangles.Add(_63r);
            rectangles.Add(_64r);
            rectangles.Add(_65r);
            rectangles.Add(_66r);
            rectangles.Add(_67r);
            rectangles.Add(_68r);
            
            rectangles.Add(_71r);
            rectangles.Add(_72r);
            rectangles.Add(_73r);
            rectangles.Add(_74r);
            rectangles.Add(_75r);
            rectangles.Add(_76r);
            rectangles.Add(_77r);
            rectangles.Add(_78r);
            
            rectangles.Add(_81r);
            rectangles.Add(_82r);
            rectangles.Add(_83r);
            rectangles.Add(_84r);
            rectangles.Add(_85r);
            rectangles.Add(_86r);
            rectangles.Add(_87r);
            rectangles.Add(_88r);
            #endregion
            return rectangles;
        }

        public List<Grid> returnAllGrids()
        {
            List<Grid> gridsList = new List<Grid>();
            #region Grids List
            gridsList.Add(_11);
            gridsList.Add(_12);
            gridsList.Add(_13);
            gridsList.Add(_14);
            gridsList.Add(_15);
            gridsList.Add(_16);
            gridsList.Add(_17);
            gridsList.Add(_18);

            gridsList.Add(_21);
            gridsList.Add(_22);
            gridsList.Add(_23);
            gridsList.Add(_24);
            gridsList.Add(_25);
            gridsList.Add(_26);
            gridsList.Add(_27);
            gridsList.Add(_28);

            gridsList.Add(_31);
            gridsList.Add(_32);
            gridsList.Add(_33);
            gridsList.Add(_34);
            gridsList.Add(_35);
            gridsList.Add(_36);
            gridsList.Add(_37);
            gridsList.Add(_38);

            gridsList.Add(_41);
            gridsList.Add(_42);
            gridsList.Add(_43);
            gridsList.Add(_44);
            gridsList.Add(_45);
            gridsList.Add(_46);
            gridsList.Add(_47);
            gridsList.Add(_48);

            gridsList.Add(_51);
            gridsList.Add(_52);
            gridsList.Add(_53);
            gridsList.Add(_54);
            gridsList.Add(_55);
            gridsList.Add(_56);
            gridsList.Add(_57);
            gridsList.Add(_58);

            gridsList.Add(_61);
            gridsList.Add(_62);
            gridsList.Add(_63);
            gridsList.Add(_64);
            gridsList.Add(_65);
            gridsList.Add(_66);
            gridsList.Add(_67);
            gridsList.Add(_68);

            gridsList.Add(_71);
            gridsList.Add(_72);
            gridsList.Add(_73);
            gridsList.Add(_74);
            gridsList.Add(_75);
            gridsList.Add(_76);
            gridsList.Add(_77);
            gridsList.Add(_78);

            gridsList.Add(_81);
            gridsList.Add(_82);
            gridsList.Add(_83);
            gridsList.Add(_84);
            gridsList.Add(_85);
            gridsList.Add(_86);
            gridsList.Add(_87);
            gridsList.Add(_88);
            #endregion
            return gridsList;
        }
        
        public TypeOfChessPiece retrunChessPieceInGrid(string gridName)
        {
            return board.squares[int.Parse(gridName[1].ToString()) - 1, int.Parse(gridName[2].ToString()) - 1].piece.type;
        }

        public void mouseDownEvent(int row, int col, ref bool isWhiteTurn)
        {
            TypeOfChessPiece typeOfChessPiece = board.squares[row - 1, col - 1].piece.type;
            // Check whether selected square is white chess piece square or not
            foreach (var square in board.allWhiteChessPieceSquares(board))
            {
                if (square.getRow() == row && square.getColumn() == col)
                {
                    isWhiteChessPieceSelected = true;
                    isWhiteHighlitedSquareSelected = false;
                    tempWhiteSquare = square;
                }
            }

            // Check whether selected square is highlited square or not
            foreach (var square in highlitedSquaresForWhite)
            {
                if (square.getRow() == row && square.getColumn() == col)
                {
                    isWhiteHighlitedSquareSelected = true;
                    isWhiteChessPieceSelected = false;
                }
            }

            if (isWhiteChessPieceSelected)
            {
                clearBoard();
                highlightPossibleMoveSquares(Core.Move.generateMoves(new Square(row, col), typeOfChessPiece, board));
                foreach (var square in Move.generateMoves(new Square(row, col), typeOfChessPiece, board))
                {
                    highlitedSquaresForWhite.Add(square);
                }

                foreach (var rectangle in returnAllRectangle())
                {
                    if (rectangle.Name[1].ToString() == row.ToString() &&
                        rectangle.Name[2].ToString() == col.ToString())
                    {
                        tempWhiteSquareRectangle = rectangle;
                    }
                }
                isWhiteHighlitedSquareSelected = false;
                isWhiteChessPieceSelected = false;
                isWhiteTurn = true;
                showBoard(board);
            }
            else if (isWhiteHighlitedSquareSelected)
            {
                foreach (var rectangle in returnAllRectangle())
                {
                    if (rectangle.Name[1].ToString() == row.ToString() &&
                        rectangle.Name[2].ToString() == col.ToString())
                    {
                        tempWhiteHighlitedSquareRectangle = rectangle;
                    }
                }

                board.replaceChessPiece(board, new Square(row, col), tempWhiteSquare.piece.type);
                
                foreach (var rectangle in returnAllRectangle())
                {
                    if (rectangle.Name[1].ToString() == tempWhiteHighlitedSquareRectangle.Name[1].ToString() && rectangle.Name[2].ToString() == tempWhiteHighlitedSquareRectangle.Name[2].ToString())
                    {
                        UI_Static.setSquareChessPiece(rectangle, tempWhiteSquare.piece.type);
                    }
                }

                foreach (var square in board.squares)
                {
                    if (square.getRow() == tempWhiteSquare.getRow() && square.getColumn() == tempWhiteSquare.getColumn())
                    {
                        board.removeChessPiece(board, new Square(tempWhiteSquare.getRow(), tempWhiteSquare.getColumn()));
                        foreach (var rectangle in returnAllRectangle())
                        {
                            if (rectangle.Name[1].ToString() == tempWhiteSquare.getRow().ToString() &&
                                rectangle.Name[2].ToString() == tempWhiteSquare.getColumn().ToString())
                            {
                                UI_Static.setSquareChessPiece(rectangle, TypeOfChessPiece.NaP);
                            }
                        }
                    }
                }
                highlitedSquaresForWhite.Clear();
                isWhiteHighlitedSquareSelected = false;
                isWhiteChessPieceSelected = false;
                tempWhiteSquare = null;
                isWhiteTurn = false;
                clearBoard();
            }
            else
            {
                highlitedSquaresForWhite.Clear();
                clearBoard();
            }
        }
        
        public void setSideMoves(int row, int col, ref bool isWhiteTurn)
        {
            if (isWhiteTurn)
            {
                if (!board.isWhiteChecked(board))
                {
                    mouseDownEvent(row, col, ref isWhiteTurn);
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("White is checked");
                    }
                }
            }
            else
            {
                if (!board.isBlackChecked(board))
                {
                    Square randomSquareToMove = AI.randomPlayingBlackPieces(board)[1];
                    
                    foreach (var rectangle in returnAllRectangle())
                    {
                        if (rectangle.Name[1].ToString() == randomSquareToMove.getRow().ToString() &&
                            rectangle.Name[2].ToString() == randomSquareToMove.getColumn().ToString())
                        {
                            UI_Static.setSquareChessPiece(rectangle, randomSquareToMove.piece.type);
                            isWhiteTurn = true;
                        }
                    }
                    showBoard(board);
                }
                else
                {
                    Console.WriteLine("Black is checked");

                    Square tempForStoringPreviousChessPiece;
                    while (board.isBlackChecked(board))
                    {
                        Square[] randomSquaresToMove = AI.randomPlayingBlackPieces(board);
                        Square randomSquareToMove = randomSquaresToMove[1];
                        if (board.isBlackChecked(board))
                        {
                            //board.squares[randomSquaresToMove[0].getRow() - 1, randomSquaresToMove[0].getColumn() - 1].piece.type = randomSquaresToMove[0].piece.type;
                            board.removeChessPiece(board, board.squares[randomSquaresToMove[1].getRow() - 1, randomSquaresToMove[1].getColumn() - 1]);
                            board.replaceChessPiece(board, board.squares[randomSquaresToMove[0].getRow() - 1, randomSquaresToMove[0].getColumn() - 1], randomSquaresToMove[0].piece.type);
                            //board.squares[randomSquaresToMove[1].getRow() - 1, randomSquaresToMove[1].getColumn() - 1].piece.type = TypeOfChessPiece.NaP;
                            if (board.isBlackChecked(board))
                            {
                                //board.removeChessPiece(board, )
                            }
                        }
                        else
                        {

                            break;
                        }
                        showBoard(board);

                        //if (board.isBlackChecked(board))
                        //{
                        //    board.squares[randomSquareToMove.getRow() - 1, randomSquareToMove.getColumn() - 1].piece.type = randomSquaresToMove[0].piece.type;
                        //}

                        //foreach (var square in board.squares)
                        //{
                        //    if (randomSquareToMove.getRow().ToString() == square.getRow().ToString() &&
                        //        randomSquareToMove.getColumn().ToString() == square.getColumn().ToString())
                        //    {
                        //        tempForStoringPreviousChessPiece = board.squares[randomSquareToMove.getRow() - 1, square.getColumn() - 1];
                        //        board.squares[randomSquareToMove.getRow() - 1, randomSquareToMove.getColumn() - 1].piece.type = square.piece.type;
                        //        if (!board.isBlackChecked(board))
                        //        {
                        //            board.squares[randomSquareToMove.getRow() - 1, randomSquareToMove.getColumn() - 1].piece.type = tempForStoringPreviousChessPiece.piece.type;
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("The move which black done, cause for black to be out of check.");
                        //            Console.WriteLine(tempForStoringPreviousChessPiece.piece.type);
                        //        }
                        //    }
                        //}
                    }
                }

            }
        }

        public void showBoard(Core.Board board)
        {
            foreach (var rectangel in returnAllRectangle())
            {
                foreach (var square in board.squares)
                {
                    if (rectangel.Name[1].ToString() == square.getRow().ToString() &&
                        rectangel.Name[2].ToString() == square.getColumn().ToString())
                    {
                        UI_Static.setSquareChessPiece(rectangel, square.piece.type);
                    }
                }
            }
        }
        
        #region Grid MouseDown
        private void _11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(1, 1, ref isWhiteTurn);
        }

        private void _12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(1, 2, ref isWhiteTurn);
        }

        private void _13_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(1, 3, ref isWhiteTurn);
        }

        private void _14_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(1, 4, ref isWhiteTurn);
        }

        private void _15_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(1, 5, ref isWhiteTurn);
        }

        private void _16_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(1, 6, ref isWhiteTurn);
        }

        private void _17_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(1, 7, ref isWhiteTurn);
        }

        private void _18_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(1, 8, ref isWhiteTurn);
        }

        private void _21_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(2, 1, ref isWhiteTurn);
        }

        private void _22_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(2, 2, ref isWhiteTurn);
        }

        private void _23_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(2, 3, ref isWhiteTurn);
        }

        private void _24_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(2, 4, ref isWhiteTurn);
        }

        private void _25_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(2, 5, ref isWhiteTurn);
        }

        private void _26_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(2, 6, ref isWhiteTurn);
        }

        private void _27_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(2, 7, ref isWhiteTurn);
        }

        private void _28_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(2, 8, ref isWhiteTurn);
        }

        private void _31_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(3, 1, ref isWhiteTurn);
        }

        private void _32_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(3, 2, ref isWhiteTurn);
        }

        private void _33_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(3, 3, ref isWhiteTurn);
        }

        private void _34_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(3, 4, ref isWhiteTurn);
        }

        private void _35_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(3, 5, ref isWhiteTurn);
        }

        private void _36_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(3, 6, ref isWhiteTurn);
        }

        private void _37_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(3, 7, ref isWhiteTurn);
        }

        private void _38_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(3, 8, ref isWhiteTurn);
        }

        private void _41_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(4, 1, ref isWhiteTurn);
        }

        private void _42_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(4, 2, ref isWhiteTurn);
        }

        private void _43_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(4, 3, ref isWhiteTurn);
        }

        private void _44_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(4, 4, ref isWhiteTurn);
        }

        private void _45_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(4, 5, ref isWhiteTurn);
        }

        private void _46_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(4, 6, ref isWhiteTurn);
        }

        private void _47_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(4, 7, ref isWhiteTurn);
        }

        private void _48_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(4, 8, ref isWhiteTurn);
        }

        private void _51_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(5, 1, ref isWhiteTurn);
        }

        private void _52_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(5, 2, ref isWhiteTurn);
        }

        private void _53_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(5, 3, ref isWhiteTurn);
        }

        private void _54_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(5, 4, ref isWhiteTurn);
        }

        private void _55_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(5, 5, ref isWhiteTurn);
        }

        private void _56_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(5, 6, ref isWhiteTurn);
        }

        private void _57_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(5, 7, ref isWhiteTurn);
        }

        private void _58_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(5, 8, ref isWhiteTurn);
        }

        private void _61_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(6, 1, ref isWhiteTurn);
        }

        private void _62_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(6, 2, ref isWhiteTurn);
        }

        private void _63_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(6, 3, ref isWhiteTurn);
        }

        private void _64_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(6, 4, ref isWhiteTurn);
        }

        private void _65_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(6, 5, ref isWhiteTurn);
        }

        private void _66_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(6, 6, ref isWhiteTurn);
        }

        private void _67_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(6, 7, ref isWhiteTurn);
        }

        private void _68_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(6, 8, ref isWhiteTurn);
        }

        private void _71_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(7, 1, ref isWhiteTurn);
        }

        private void _72_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(7, 2, ref isWhiteTurn);
        }

        private void _73_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(7, 3, ref isWhiteTurn);
        }

        private void _74_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(7, 4, ref isWhiteTurn);
        }

        private void _75_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(7, 5, ref isWhiteTurn);
        }

        private void _76_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(7, 6, ref isWhiteTurn);
        }

        private void _77_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(7, 7, ref isWhiteTurn);
        }

        private void _78_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(7, 8, ref isWhiteTurn);
        }

        private void _81_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(8, 1, ref isWhiteTurn);
        }

        private void _82_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(8, 2, ref isWhiteTurn);
        }

        private void _83_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(8, 3, ref isWhiteTurn);
        }

        private void _84_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(8, 4, ref isWhiteTurn);
        }

        private void _85_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(8, 5, ref isWhiteTurn);
        }

        private void _86_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(8, 6, ref isWhiteTurn);
        }

        private void _87_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(8, 7, ref isWhiteTurn);
        }

        private void _88_MouseDown(object sender, MouseButtonEventArgs e)
        {
            setSideMoves(8, 8, ref isWhiteTurn);
        }
        #endregion
    }
}
