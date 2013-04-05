using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using snake1._0._2.View;
using System.Collections;

namespace snake1._0._2.Model
{
    class SnakeGameModel
    {
        private SnakeModel theSolidSnake;
        private SnakeFoodModel theFreshFood;
        private Thread runningGameThread;
        private SyncEvents mySyncEvents;
        private Queue<SnakeModel.movement> queueOfMovement;
        private Queue<List<SnakePiecesModel>> queueOfLocationData;
        private Queue<List<SnakeFoodModel>> queueOfAppleLocation;
        private Queue<System.Windows.Forms.Panel> queueGameMap;
        private Map gameMap;
    
        public SnakeModel TheSolidSnake
        {
            get { return this.theSolidSnake; }
            set { this.theSolidSnake = value; }
        }

        public Thread RunningGameThread
        {
            get { return this.runningGameThread; }
            set { this.runningGameThread = value; }
        }

        public SnakeFoodModel TheFreshFood
        {
            get { return this.theFreshFood; }
            set { this.theFreshFood = value; }
        }

        public SnakeGameModel(Queue<SnakeModel.movement> queueOfMovement, Queue<List<SnakePiecesModel>> queueOfLocationData, Queue<List<SnakeFoodModel>> queueOfAppleLocation,
            Queue<System.Windows.Forms.Panel> queueGameMap, SyncEvents mySyncEvents)
        {
            this.theSolidSnake = new SnakeModel();
            this.theSolidSnake.CurrentMove = SnakeModel.movement.RIGHT;
            this.theFreshFood = new SnakeFoodModel();
            this.gameMap = new Map();

            //this.snakeBody = snakeBody;
            this.queueOfMovement = queueOfMovement;
            this.queueOfLocationData = queueOfLocationData;
            this.queueOfAppleLocation = queueOfAppleLocation;
            this.queueGameMap = queueGameMap;
            this.mySyncEvents = mySyncEvents;
            //this.myLaunchWorkEvent = new EventWaitHandle(false, EventResetMode.AutoReset);
            //this.myStopWorkEvent = new EventWaitHandle(false, EventResetMode.AutoReset);
            this.runningGameThread = new Thread(new ThreadStart(runningGameFlow));
            this.runningGameThread.Start();
        }

        private void runningGameFlow()
        {
            try
            {
                this.theFreshFood.putFoodOnTheMap(this.theSolidSnake.SnakeBodyPieces, this.gameMap);
                List<SnakeFoodModel> foodList = new List<SnakeFoodModel>();
                foodList.Add(this.theFreshFood);

                while (!mySyncEvents.ExitThreadEvent.WaitOne(0))
                {

                    if (mySyncEvents.MouvementChangeEvent.WaitOne(0))
                    {
                        lock (((ICollection)queueOfMovement).SyncRoot)
                        {
                            this.theSolidSnake.CurrentMove = queueOfMovement.Dequeue();
                        }
                    }

                    if (mySyncEvents.ProduceCollectionEvent.WaitOne(0))
                    {
                       
                        lock (((ICollection)queueOfLocationData).SyncRoot)
                        {

                            this.theSolidSnake.moveTheSnakeBody(this.theSolidSnake.CurrentMove, this.gameMap);
                            queueOfLocationData.Enqueue(this.theSolidSnake.SnakeBodyPieces);
                            mySyncEvents.ComsumeCollectionEvent.Set();
                        }
                        
                        
                        if (this.theFreshFood.VisibleTime.Equals(0))
                        {
                            this.theFreshFood.VisibleTime = SnakeFoodModel.defaultVisibleTime;
                            this.theFreshFood.putFoodOnTheMap(this.theSolidSnake.SnakeBodyPieces, this.gameMap);
                            foodList.Clear();
                            foodList.Add(this.theFreshFood);

                            lock (((ICollection)queueOfAppleLocation).SyncRoot)
                            {
                                queueOfAppleLocation.Enqueue(foodList);
                                mySyncEvents.NewFoodLocationEvent.Set();
                            }
                        }
                        else if (this.theFreshFood.VisibleTime > 0)
                        {
                            this.theFreshFood.VisibleTime -= 1;
                        }

                    }

                    if (mySyncEvents.FoodEatingEvent.WaitOne(0))
                    {
                        lock (((ICollection)queueOfLocationData).SyncRoot)
                        {
                            this.theSolidSnake.growUpTheSnake();
                            queueOfLocationData.Enqueue(this.theSolidSnake.SnakeBodyPieces);
                            //mySyncEvents.ComsumeCollectionEvent.Set();  The comsume event is not fire 
                        }
                    }

                    if (mySyncEvents.MapSizeChanged.WaitOne(0))
                    {
                        lock (((ICollection)queueGameMap).SyncRoot)
                        {
                            this.gameMap.UpdateMap(queueGameMap.Dequeue());
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(String.Format("An Error occur when running the game:{0}{1}", Environment.NewLine, ex.Message));
            }            
        }

        private Boolean DetectEatCollision()
        {
            Boolean result = false;
            System.Drawing.Point headLocation = this.theSolidSnake.SnakeBodyPieces[0].SnakePieceLocation;

            lock (((ICollection)queueOfAppleLocation).SyncRoot)
            {


            }


            return result;
        }

    }
}
