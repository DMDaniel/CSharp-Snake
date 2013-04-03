using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace snake1._0._2.Model
{
    class SnakePiecesModel
    {
        private Point snakePieceLocation;
        public static int defaultSnakeHeight = 12;
        public static int defaultSnakeWidth = 12;
        public Point SnakePieceLocation
        {
            get { return this.snakePieceLocation; }
            set { this.snakePieceLocation = value; }
        }

        public int SnakePieceLocationX
        {
            get{return this.snakePieceLocation.X;}
            set{this.snakePieceLocation.X = value;}
        }

        public int SnakePieceLocationY
        {
            get { return this.snakePieceLocation.Y; }
            set { this.snakePieceLocation.Y = value; }
        }

        public SnakePiecesModel()
        {
            this.snakePieceLocation.X = 0;
            this.snakePieceLocation.Y = 0;
        }

        public SnakePiecesModel(int x, int y)
        {
            this.snakePieceLocation.X = x;
            this.snakePieceLocation.Y = y;
        }
    }
}