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
#region "Attributs"
        private Boolean formIsClosed;
        private SnakeModel.movement currentMove = SnakeModel.movement.LEFT;
        private List<SnakePiecesView> snakeBody;
        private List<FoodView> foodList;
        private SyncEvents mySyncEvents;
        private Queue<SnakeModel.movement> queueOfMovement;
        private Queue<List<SnakePiecesModel>> queueOfLocationData;
        private Queue<List<SnakeFoodModel>> queueOfAppleLocation;
        private Queue<System.Windows.Forms.Panel> queueGameMap;
        private Thread updateFormThread;
        private SystemInfoProcessor mySysInfoCPU;
        private Queue<Player> thePlayerQueue;
        private Player thePlayer;
        private RemoteGameUserControl remoteGamePanel;

        private int displayCpuCounter = 10;

        private Boolean lockMove = true;
#endregion

#region Constructor
        public SnakeGameForm(Queue<SnakeModel.movement> queue, Queue<List<SnakePiecesModel>> queueOfLocationData, Queue<List<SnakeFoodModel>> queueOfAppleLocation,
                            Queue<System.Windows.Forms.Panel> queueGameMap, Queue<Player> thePlayerQueue, SyncEvents mySyncEvents)
        {
            InitializeComponent();

            this.remoteGamePanel = new RemoteGameUserControl();
            this.remoteGamePanel.Dock = DockStyle.Fill;
            this.groupBoxRemoteGame.Controls.Add(this.remoteGamePanel);
            

            this.formIsClosed = false;

            this.snakeBody = new List<SnakePiecesView>();
            this.foodList = new List<FoodView>();
            this.thePlayer = new Player();
            this.thePlayerQueue = thePlayerQueue;


            this.queueOfMovement = queue;
            this.queueOfLocationData = queueOfLocationData;
            this.queueOfAppleLocation = queueOfAppleLocation;
            this.queueGameMap = queueGameMap;
            this.mySyncEvents = mySyncEvents;
            this.mySysInfoCPU = new SystemInfoProcessor();

            lock (((ICollection)queueGameMap).SyncRoot)
            {
                queueGameMap.Enqueue(this.GamePanel);
                mySyncEvents.MapSizeChanged.Set();
            }


            this.updateFormThread = new Thread(new ThreadStart(updateFormProc));
            this.updateFormThread.Start();

        }
#endregion

#region "Delegate"
        private delegate void CloseFormControlDelagate(Form formToClose);

        private delegate void AddItemControlDelegate(Control ControlToUpdate, SnakePiecesView item);
        private delegate void AddFoodItemControlDelegate(Control ControlToUpdate, FoodView item);

        private delegate void UpdatePlayerScoreControlDelegate(Control ControlToUpdate, String score);

        private delegate void ChangeLocControlDelegate(System.Windows.Forms.Control ControlToUpdate, System.Drawing.Point newLoc);

        private delegate void RemoveItemControlDelegate(Control ControlToUpdate, System.Windows.Forms.Control item);
        //private delegate void RemoveItemControlDelegate(Control ControlToUpdate, SnakePiecesView item);
        private delegate void ClearGameAreaControlDelegate(Control ControlToUpdate);
#endregion
#region "Delegate Invoker Method"
        private void CloseForm(Form formToClose)
        {
            if (formToClose.InvokeRequired)
            {
                formToClose.Invoke(new CloseFormControlDelagate(CloseForm),
                    formToClose);
            }
            else
            {
                formToClose.Close();
            }
        }
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
        private void UpdatePlayerScore(Control ControlToUpdate, String score)
        {
            if (ControlToUpdate.InvokeRequired)
            {
                ControlToUpdate.Invoke(new UpdatePlayerScoreControlDelegate(UpdatePlayerScore),
                    ControlToUpdate
                    ,score);
            }
            else
            {
                ControlToUpdate.Text = score;
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
#endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (this.lockMove == true)
            {
                switch (keyData)
                {
                    case Keys.Left:
                        if (this.currentMove != SnakeModel.movement.RIGHT)
                        {
                            lock (((ICollection)queueOfMovement).SyncRoot)
                            {
                                queueOfMovement.Enqueue(SnakeModel.movement.LEFT);
                                mySyncEvents.MouvementChangeEvent.Set();
                            }
                            this.currentMove = SnakeModel.movement.LEFT;
                        }
                        break;
                    case Keys.Right:
                        if (this.currentMove != SnakeModel.movement.LEFT)
                        {
                            lock (((ICollection)queueOfMovement).SyncRoot)
                            {
                                queueOfMovement.Enqueue(SnakeModel.movement.RIGHT);
                                mySyncEvents.MouvementChangeEvent.Set();
                            }
                            this.currentMove = SnakeModel.movement.RIGHT;
                        }
                        break;
                    case Keys.Up:
                        if (this.currentMove != SnakeModel.movement.DOWN)
                        {
                            lock (((ICollection)queueOfMovement).SyncRoot)
                            {
                                queueOfMovement.Enqueue(SnakeModel.movement.UP);
                                mySyncEvents.MouvementChangeEvent.Set();
                            }
                            this.currentMove = SnakeModel.movement.UP;
                        }
                        break;
                    case Keys.Down:
                        if (this.currentMove != SnakeModel.movement.UP)
                        {
                            lock (((ICollection)queueOfMovement).SyncRoot)
                            {
                                queueOfMovement.Enqueue(SnakeModel.movement.DOWN);
                                mySyncEvents.MouvementChangeEvent.Set();
                            }
                            this.currentMove = SnakeModel.movement.DOWN;
                        }
                        break;
                    default:
                        break;
                }
                this.lockMove = false;
            }
            return base.ProcessCmdKey(ref msg, keyData);
            
        }

#region "Event Methods"
        private void sequenceGameTimer_Tick(object sender, EventArgs e)
        {
            this.mySyncEvents.ProduceCollectionEvent.Set();
            if (this.displayCpuCounter.Equals(0))
            {
                this.displayCpuCounter = 10;
                this.mySysInfoCPU.GetCPUusage();
                this.mySysInfoCPU.GetSysDateAndTime();
                this.toolStripStatusLabelCPUdata.Text = String.Format("{0}%", System.Math.Round(this.mySysInfoCPU.CpuUsage));
                this.toolStripStatusLabelDATEdata.Text = String.Format("{0} {1}", this.mySysInfoCPU.SysDate, this.mySysInfoCPU.SysTime);
            }
            else
            {
                this.displayCpuCounter -= 1;
            }
            this.toolStripStatusLabelScoreDATA.Text = thePlayer.Score.ToString();


            this.lockMove = true;
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

#region Updating form thread
        private void updateFormProc()
        {
            try
            {
                while (!this.formIsClosed)
                {

                    Thread.Sleep(10); //In order to let the CPU breathe

                    List<SnakePiecesModel> items = new List<SnakePiecesModel>();
                    List<SnakeFoodModel> foodItems = new List<SnakeFoodModel>();

                    if (mySyncEvents.SelfBodyEatingEvent.WaitOne(0))
                    {
                        MessageBox.Show(String.Format("YOU LOSE {0} !{1}Your score is {2}", this.thePlayer.Nickname, Environment.NewLine, this.thePlayer.Score), "Snake Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        CloseForm(this);
                        break;
                    }

                    if (mySyncEvents.AppleHaveBeenEatedEvent.WaitOne(0))
                    {
                        lock(((ICollection)thePlayerQueue).SyncRoot)
                        {
                            this.thePlayer = this.thePlayerQueue.Dequeue();
                        }
                    }
                    
                    
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
                    }

                    if (mySyncEvents.ComsumeCollectionEvent.WaitOne(0))
                    {
                        lock (((ICollection)queueOfLocationData).SyncRoot)
                        {
                            items = this.queueOfLocationData.Dequeue();
                        }

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
                        }
                    }
                }
            }
            catch
            {
                //an error occur
            }
        }
#endregion

#region Methodes
        private void CleanGameAreaShowFood()
        {
            //Clear all elements on the panel
            ClearGameArea(this.GamePanel);
        }

        private void theTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
#endregion

    }
}
