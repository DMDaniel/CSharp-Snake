﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace snake1._0._2.Model
{
    
    class SnakeModel
    {
        public enum movement { LEFT = 1, DOWN, RIGHT, UP };
        private List<SnakePiecesModel> snakeBodyPieces;
        private movement currentMove = movement.RIGHT;
        public const int snakePiecesViewSize = 12;

        public movement CurrentMove
        {
            get { return this.currentMove; }
            set { this.currentMove = value; }
        }

        public List<SnakePiecesModel> SnakeBodyPieces
        {
            get { return this.snakeBodyPieces; }
            set { this.snakeBodyPieces = value; }
        }

        public SnakeModel()
        {
            SnakePiecesModel snakeSinglePiece = new SnakePiecesModel(60,50);
            SnakePiecesModel snakeSinglePiece2 = new SnakePiecesModel(50, 50);
            SnakePiecesModel snakeSinglePiece3 = new SnakePiecesModel(40, 50);
            this.snakeBodyPieces = new List<SnakePiecesModel>();
            this.snakeBodyPieces.Add(snakeSinglePiece);
            this.snakeBodyPieces.Add(snakeSinglePiece2);
            this.snakeBodyPieces.Add(snakeSinglePiece3);
        }

        public void growUpTheSnake()
        {
            SnakePiecesModel snakeSinglePiece;
            if (this.snakeBodyPieces.Count > 0)
            {
                SnakePiecesModel headPiece = this.snakeBodyPieces[this.snakeBodyPieces.Count - 1];
                switch (this.currentMove)
                {
                    case movement.LEFT:
                        snakeSinglePiece = new SnakePiecesModel(headPiece.SnakePieceLocation.X + snakePiecesViewSize, headPiece.SnakePieceLocation.Y);
                        this.snakeBodyPieces.Add(snakeSinglePiece);
                        break;
                    case movement.DOWN:
                        snakeSinglePiece = new SnakePiecesModel(headPiece.SnakePieceLocation.X, headPiece.SnakePieceLocation.Y + snakePiecesViewSize);
                        this.snakeBodyPieces.Add(snakeSinglePiece);
                        break;
                    case movement.RIGHT:
                        snakeSinglePiece = new SnakePiecesModel(headPiece.SnakePieceLocation.X - snakePiecesViewSize, headPiece.SnakePieceLocation.Y);
                        this.snakeBodyPieces.Add(snakeSinglePiece);
                        break;
                    case movement.UP:
                        snakeSinglePiece = new SnakePiecesModel(headPiece.SnakePieceLocation.X, headPiece.SnakePieceLocation.Y - snakePiecesViewSize);
                        this.snakeBodyPieces.Add(snakeSinglePiece);
                        break;

                    default:
                        break;
                }
            }
        }
        public void SetSnakeLocation()
        {

        }

        //public void ChangeSnakeBorderLocation(Map gameMap)
        //{
        //    switch (this.currentMove)
        //    {
        //        case movement.LEFT:
        //            this.snakeBodyPieces[0].SnakePieceLocationX = gameMap.BottomRight.X;
        //            break;
        //        case movement.RIGHT:
        //            this.snakeBodyPieces[0].SnakePieceLocationX = gameMap.TopLeft.X;
        //            break;
        //        case movement.UP:
        //            this.snakeBodyPieces[0].SnakePieceLocationY = gameMap.BottomRight.Y;
        //            break;
        //        case movement.DOWN:
        //            this.snakeBodyPieces[0].SnakePieceLocationY = gameMap.TopLeft.Y;
        //            break;
        //        default:
        //            break;
        //    }
        //}

        public void moveTheSnakeBody(movement moveTo, Map gameMap)
        {
            if (this.snakeBodyPieces.Count > 1)
            {
                for (int i = this.snakeBodyPieces.Count - 1; i > 0; i--)
                {
                    this.snakeBodyPieces[i].SnakePieceLocation = this.snakeBodyPieces[i - 1].SnakePieceLocation;
                }
            }
            switch (moveTo)
            {
                case movement.LEFT:
                    if (this.snakeBodyPieces[0].SnakePieceLocationX <= gameMap.TopLeft.X)
                    {
                        this.snakeBodyPieces[0].SnakePieceLocationX = gameMap.BottomRight.X;
                    }
                    else{
                        this.snakeBodyPieces[0].SnakePieceLocationX -= snakePiecesViewSize;
                    }
                    break;

                case movement.DOWN:
                    if (this.snakeBodyPieces[0].SnakePieceLocationY >= gameMap.BottomRight.Y)
                    {
                        this.snakeBodyPieces[0].SnakePieceLocationY = gameMap.TopLeft.Y;
                    }
                    else
                    {
                        this.snakeBodyPieces[0].SnakePieceLocationY += snakePiecesViewSize;
                    }
                    break;

                case movement.RIGHT:
                    if (this.snakeBodyPieces[0].SnakePieceLocationX >= gameMap.BottomRight.X)
                    {
                        this.snakeBodyPieces[0].SnakePieceLocationX = gameMap.TopLeft.X;
                    }
                    else
                    {
                        this.snakeBodyPieces[0].SnakePieceLocationX += snakePiecesViewSize;
                    }
                    break;

                case movement.UP:
                    if (this.snakeBodyPieces[0].SnakePieceLocationY <= gameMap.TopLeft.Y)
                    {
                        this.snakeBodyPieces[0].SnakePieceLocationY = gameMap.BottomRight.Y;
                    }
                    else
                    {
                        this.snakeBodyPieces[0].SnakePieceLocationY -= snakePiecesViewSize;
                    }
                    break;

                default:
                    break;
            }

        }

    }
}
