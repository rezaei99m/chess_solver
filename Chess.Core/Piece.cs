using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core
{
    public class Piece
    {
        public Piece()
        {
            type = TypeOfChessPiece.NaP;
        }

        public TypeOfChessPiece type;
        public int pieceValue;
        public int attackedValue;
        public int defendedValue;
        public int pieceActionValue;
        public bool selected;
        public bool moved;
        public List<Square> validMoves;


        public static int calulateChessPieceValue(TypeOfChessPiece typeOfChessPiece)
        {
            switch (typeOfChessPiece)
            {
                case TypeOfChessPiece.b_king:
                    return 32767;
                case TypeOfChessPiece.b_queen:
                    return 975;
                case TypeOfChessPiece.b_bishop:
                    return 325;
                case TypeOfChessPiece.b_knight:
                    return 320;
                case TypeOfChessPiece.b_rook:
                    return 500;
                case TypeOfChessPiece.b_pawn:
                    return 100;
                case TypeOfChessPiece.w_king:
                    return 32767;
                case TypeOfChessPiece.w_queen:
                    return 975;
                case TypeOfChessPiece.w_bishop:
                    return 325;
                case TypeOfChessPiece.w_knight:
                    return 320;
                case TypeOfChessPiece.w_rook:
                    return 500;
                case TypeOfChessPiece.w_pawn:
                    return 100;
                default:
                    return 0;
            }
        }

        public static int calculatePieceActionValue(TypeOfChessPiece typeOfChessPiece)
        {
            switch (typeOfChessPiece)
            {
                case TypeOfChessPiece.b_king:
                    return 1;
                case TypeOfChessPiece.b_queen:
                    return 1;
                case TypeOfChessPiece.b_bishop:
                    return 3;
                case TypeOfChessPiece.b_knight:
                    return 3;
                case TypeOfChessPiece.b_rook:
                    return 2;
                case TypeOfChessPiece.b_pawn:
                    return 6;
                case TypeOfChessPiece.w_king:
                    return 1;
                case TypeOfChessPiece.w_queen:
                    return 1;
                case TypeOfChessPiece.w_bishop:
                    return 3;
                case TypeOfChessPiece.w_knight:
                    return 3;
                case TypeOfChessPiece.w_rook:
                    return 2;
                case TypeOfChessPiece.w_pawn:
                    return 6;
                default:
                    return 0;
            }
        }
    }

    public enum TypeOfChessPiece
    {
        b_king, b_queen, b_bishop, b_knight, b_rook, b_pawn,
        w_king, w_queen, w_bishop, w_knight, w_rook, w_pawn,
        NaP
    }
    
    public enum ChessPieceColor
    {
        white, black
    }
}
