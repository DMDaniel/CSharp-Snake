using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using System.Threading;
using System.Collections;
using snake1._0._2.Model;

namespace snake1._0._2.View
{
    partial class SnakeGameForm : Form
    {
        private Boolean formIsClosed;
        private List<SnakePiecesView> snakeBody;
        private List<FoodView> foodList;
        private SyncEvents mySyncEvents;
        private Queue<SnakeModel.movement> queueOfMovement;
        private Queue<List<SnakePiecesModel>> queueOfLocationData;
        private Queue<List<SnakeFoodModel>> queueOfAppleLocation;
        private Queue<System.Windows.Forms.Panel> queueGameMap;
        private Thread updateFormThread;
        private Thread observeAreaThread;

        public SnakeGameForm(Queue<SnakeModel.movement> queue, Queue<List<SnakePiecesModel>> queueOfLocationData, Queue<List<SnakeFoodModel>> queueOfAppleLocation,
                            Queue<System.Windows.Forms.Panel> queueGameMap, SyncEvents mySyncEvents)
        {
            InitializeComponent();


            this.formIsClosed = false;

            this.snakeBody = new List<SnakePiecesView>();
            this.foodList = new List<FoodView>();
            this.queueOfMovement = queue;
            this.queueOfLocationData = queueOfLocationData;
            this.queueOfAppleLocation = queueOfAppleLocation;
            this.queueGameMap = queueGameMap;
            this.mySyncEvents = mySyncEvents;

            lock (((ICollection)queueGameMap).SyncRoot)
            {
                queueGameMap.Enqueue(this.GamePanel);
                mySyncEvents.MapSizeChanged.Set();
            }

            this.observeAreaThread = new Thread(new ThreadStart(observeAreaProc));
            this.observeAreaThread.Start();

            this.updateFormThread = new Thread(new ThreadStart(updateFormProc));
            this.updateFormThread.Start();

        }

        private delegate void AddItemControlDelegate(Control ControlToUpdate, SnakePiecesView item);
        private delegate void AddFoodItemControlDelegate(Control ControlToUpdate, FoodView item);

        private delegate void ChangeLocControlDelegate(System.Windows.Forms.Control ControlToUpdate, System.Drawing.Point newLoc);

        private delegate void RemoveItemControlDelegate(Control ControlToUpdate, System.Windows.Forms.Control item);
        //private delegate void RemoveItemControlDelegate(Control ControlToUpdate, SnakePiecesView item);
        private delegate void ClearGameAreaControlDelegate(Control ControlToUpdate);

        private void AddItemListOfViewFood(Control ControlToUpdate, FoodView item)
        {
            if (ControlToUpdate.InvokeRequired)
            {
                ControlToUpdate.Invoke(new AddFoodItemControlDelegate(AddItemListOfViewFood),
                    ControlToUpdate,
                    item);
            }
            else
            {
                ControlToUpdate.Controls.Add(item);
            }
        }
        private void AddItemListOfViewPieces(Control ControlToUpdate, SnakePiecesView item)
        {
            if (ControlToUpdate.InvokeRequired)
            {
                ControlToUpdate.Invoke(new AddItemControlDelegate(AddItemListOfViewPieces),
                    ControlToUpdate,
                    item);
            }
            else
            {
                ControlToUpdate.Controls.Add(item);
            }
        }
        private void ChangePiecesViewLoc(System.Windows.Forms.Control ControlToUpdate, System.Drawing.Point newLoc)
        {
            if (ControlToUpdate.InvokeRequired)
            {
                ControlToUpdate.Invoke(new ChangeLocControlDelegate(ChangePiecesViewLoc),
                    ControlToUpdate,
                    newLoc);
            }
            else
            {
                ControlToUpdate.Location = newLoc;
            } 
        }

        private void RemoveItemListOfViewPieces(Control ControlToUpdate, System.Windows.Forms.Control item)
        //private void RemoveItemListOfViewPieces(Control ControlToUpdate, SnakePiecesView item)
        {
            if (ControlToUpdate.InvokeRequired)
            {
                ControlToUpdate.Invoke(
                    new RemoveItemControlDelegate(RemoveItemListOfViewPieces),
                    ControlToUpdate,
                    item);
            }
            else
            {
                ControlToUpdate.Controls.Remove(item);
            }
        }

        private void ClearGameArea(Control ControlToUpdate)
        {
            if (ControlToUpdate.InvokeRequired)
            {
                ControlToUpdate.Invoke(
                    new ClearGameAreaControlDelegate(ClearGameArea),
                    ControlToUpdate);
            }
            else
            {
                ControlToUpdate.Controls.Clear();
            }
        }
      
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
 
            switch(keyData)
            {
                case Keys.Left:
                    lock (((ICollection)queueOfMovement).SyncRoot)
                    {
                        queueOfMovement.Enqueue(SnakeModel.movement.LEFT);
                        mySyncEvents.MouvementChangeEvent.Set();
                    }
                    //this.myGame.TheSolidSnake.CurrentMove = SnakeModel.movement.LEFT;
                    break;
                case Keys.Right:
                    lock (((ICollection)queueOfMovement).SyncRoot)
                    {
                        queueOfMovement.Enqueue(SnakeModel.movement.RIGHT);
                        mySyncEvents.MouvementChangeEvent.Set();
                    }
                    //this.myGame.TheSolidSnake.CurrentMove = SnakeModel.movement.RIGHT;
                    break;
                case Keys.Up:
                    lock (((ICollection)queueOfMovement).SyncRoot)
                    {
                        queueOfMovement.Enqueue(SnakeModel.movement.UP);
                        mySyncEvents.MouvementChangeEvent.Set();
                    }
                    //this.myGame.TheSolidSnake.CurrentMove = SnakeModel.movement.UP;
                    break;
                case Keys.Down:
                    lock (((ICollection)queueOfMovement).SyncRoot)
                    {
                        queueOfMovement.Enqueue(SnakeModel.movement.DOWN);
                        mySyncEvents.MouvementChangeEvent.Set();
                    }
                    //this.myGame.TheSolidSnake.CurrentMove = SnakeModel.movement.DOWN;
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

#region "Event Methods"
        private void sequenceGameTimer_Tick(object sender, EventArgs e)
        {
            this.mySyncEvents.ProduceCollectionEvent.Set();               
        }

        private void SnakeGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.formIsClosed = true;
            mySyncEvents.ExitThreadEvent.Set();
        }
        private void SnakeGameForm_Resize(object sender, EventArgs e)
        {
            lock (((ICollection)queueGameMap).SyncRoot)
            {
                queueGameMap.Enqueue(this.GamePanel);
                mySyncEvents.MapSizeChanged.Set();
            }
        }
#endregion
 
        private void observeAreaProc()
        {
            //while (true)
            //{

            //}
        }

        private void updateFormProc()
        {
            try
            {
                //while (!mySyncEvents.ExitThreadEvent.WaitOne())
                while (!this.formIsClosed)
                {
                    List<SnakePiecesModel> items = new List<SnakePiecesModel>();
                    List<SnakeFoodModel> foodItems = new List<SnakeFoodModel>();

                    if (mySyncEvents.NewFoodLocationEvent.WaitOne(0))
                    {
                        lock (((ICollection)queueOfAppleLocation).SyncRoot)
                        {
                            foodItems = this.queueOfAppleLocation.Dequeue();
                        }

                        if (foodItems.Count > this.foodList.Count)
                        {
                            int itemsDiff = foodItems.Count - this.foodList.Count;
                            for (int i = 1; i < itemsDiff + 1; i++)
                            {
                                FoodView foodPieces = new FoodView(foodItems[foodItems.Count - i].AppleLocation);
                                this.foodList.Add(foodPieces);
                                AddItemListOfViewFood(this.GamePanel, foodPieces);
                            }
                        }
                        else if (items.Count < this.foodList.Count)
                        {
                            int itemsDiff = this.foodList.Count - foodItems.Count;
                            for (int i = 1; i < itemsDiff + 1; i++)
                            {
                                RemoveItemListOfViewPieces(this.GamePanel, this.foodList[this.foodList.Count - 1]);
                                this.snakeBody.RemoveAt(this.snakeBody.Count - 1);
                            }
                        }
                        for (int i = 0; i < foodItems.Count; i++)
                        {
                            ChangePiecesViewLoc(this.foodList[i], foodItems[i].AppleLocation);
                        }

                        //for (int i = 0; i < foodList.Count; i++)
                        //{
                        //    RemoveItemListOfViewPieces(this.GamePanel, foodList[i]);
                        //}
                        //for (int i = 0; i < foodItems.Count; i++)
                        //{
                        //    FoodView snakeFood = new FoodView(foodItems[i].AppleLocation);
                        //    foodList.Add(snakeFood);
                        //    AddItemListOfViewFood(this.GamePanel, snakeFood);
                        //}
                    }

                    if (mySyncEvents.ComsumeCollectionEvent.WaitOne(0))
                    {
                        lock (((ICollection)queueOfLocationData).SyncRoot)
                        {
                            items = this.queueOfLocationData.Dequeue();
                        }

                        //CleanGameAreaShowFood();
                        //Clean displayed pieces
                        //for (int i = 0; i < this.snakeBody.Count; i++)
                        //{
                        //    RemoveItemListOfViewPieces(this.GamePanel, this.snakeBody[i]);
                        //}

                        if (items.Count > this.snakeBody.Count)
                        {
                            int itemsDiff = items.Count - this.snakeBody.Count;
                            for(int i = 1; i < itemsDiff +1; i++)
                            {
                                SnakePiecesView snakePieces = new SnakePiecesView(items[items.Count -i].SnakePieceLocation);
                                this.snakeBody.Add(snakePieces);
                                AddItemListOfViewPieces(this.GamePanel, snakePieces);
                            }
                        }
                        else if (items.Count < this.snakeBody.Count)
                        {
                            int itemsDiff = this.snakeBody.Count - items.Count;
                            for (int i = 1; i < itemsDiff + 1; i++)
                            {
                                RemoveItemListOfViewPieces(this.GamePanel, this.snakeBody[this.snakeBody.Count - 1]);
                                this.snakeBody.RemoveAt(this.snakeBody.Count - 1);
                            }
                        }

                        for (int i = 0; i < items.Count; i++)
                        {
                            ChangePiecesViewLoc(this.snakeBody[i], items[i].SnakePieceLocation);
                            //this.snakeBody[i].Location = items[i].SnakePieceLocation;

                            //SnakePiecesView snakePieces = new SnakePiecesView(items[i].SnakePieceLocation);
                            //this.snakeBody.Add(snakePieces);
                            //AddItemListOfViewPieces(this.GamePanel, snakePieces);


                            //ClearGameArea(this.GamePanel);
                            //RemoveItemListOfViewPieces(this.GamePanel, new SnakePiecesView(items[i].SnakePieceLocation));
                            //this.snakeBody[i].Location = this.myGame.TheSolidSnake.SnakeBodyPieces[i].SnakePieceLocation;
                        }
                        //for (int i = 0; i < foodItems.Count; i++)
                        //{ 
                        //    FoodView snakeFood = new FoodView(foodItems[i].AppleLocation);
                        //    AddItemListOfViewFood(this.GamePanel, snakeFood);
                        //}
                    }
                }
            }
            catch
            {
                //an error occur
            }
        }

        private void CleanGameAreaShowFood()
        {
            //Clear all elements on the panel
            ClearGameArea(this.GamePanel);
            //Re-Display the food

        }





    }
}
