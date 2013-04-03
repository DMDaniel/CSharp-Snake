using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace snake1._0._2.Model
{
    class SnakeFoodModel
    {

        private Point appleLocation;
        public static int defaultAppleHeight = 12;
        public static int defaultAppleWidth = 12;
        
        private Color appleColor;
         
        public static int defaultVisibleTime = 50; //Number of Timer tick
        private int visibleTime;  

#region Acsessors
        public Color AppleColor
        {
            get { return this.appleColor; }
            set { this.appleColor = value; }

        }

        public int VisibleTime
        {
            get { return this.visibleTime; }
            set { this.visibleTime = value; }

        }

        public Point AppleLocation
        {
            get { return this.appleLocation; }
            set { this.appleLocation = value; }
        }

        public int AppleLocationX
        {
            get{return this.appleLocation.X;}
            set{this.appleLocation.X = value;}
        }

        public int AppleLocationY
        {
            get { return this.appleLocation.Y; }
            set { this.appleLocation.Y = value; }
        }

#endregion
#region Constructors
        public SnakeFoodModel()
        {
            this.appleLocation.X = 0;
            this.appleLocation.Y = 0;
            this.visibleTime = SnakeFoodModel.defaultVisibleTime;
        }

        public SnakeFoodModel(int x, int y)
        {
            this.appleLocation.X = x;
            this.appleLocation.Y = y;
            this.visibleTime = SnakeFoodModel.defaultVisibleTime;
        }
#endregion

        public void putFoodOnTheMap(List<SnakePiecesModel> snakeBody, Map gameMap)
        {
            Random myRandObj = new Random();
            int xRandNumber;
            int yRandNumber;
            do
            {
                xRandNumber = myRandObj.Next(0, (gameMap.BottomRight.X / SnakeFoodModel.defaultAppleWidth)) + SnakeFoodModel.defaultAppleWidth;
                yRandNumber = myRandObj.Next(0, (gameMap.BottomRight.Y / SnakeFoodModel.defaultAppleHeight)) + SnakeFoodModel.defaultAppleHeight;
            } while (!isNotSnakeBodyLocation(snakeBody, xRandNumber, yRandNumber));

            this.appleLocation.X = xRandNumber;
            this.appleLocation.Y = yRandNumber;
        }

        private Boolean isNotSnakeBodyLocation(List<SnakePiecesModel> snakeBody, int xRandNumber, int yRandNumber)
        {
            Boolean result = false;
            foreach (SnakePiecesModel piece in snakeBody)
            {
                if (!piece.SnakePieceLocationX.Equals(xRandNumber) && !piece.SnakePieceLocationY.Equals(yRandNumber))
                    result = true;
                else
                    result = false;
            }
            return result;
        }

    }
}
