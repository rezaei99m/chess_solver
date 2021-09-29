using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core
{
    public class Square
    {
        public Square(int row, int col, int score = 0)
        {
            this.row = row;
            this.col = col;
            this.score = score;
            piece = new Piece();
        }

        private int row;
        private int col;
        private int score;
        public Piece piece;

        public int getRow()
        {
            return row;
        }
        public void setRow(int row)
        {
            this.row = row;
        }

        public int getColumn()
        {
            return col;
        }
        public void setColumn(int column)
        {
            col = column;
        }


        public int getScore()
        {
            return score;
        }
        public void setScore(int score)
        {
            this.score = score;
        }
   
    }
}
