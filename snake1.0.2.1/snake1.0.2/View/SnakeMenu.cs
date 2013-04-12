using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using snake1._0._2.View;
using snake1._0._2.Model;

namespace snake1._0._2.View
{
    public partial class SnakeMenu : Form
    {
        public SnakeMenu()
        {
            InitializeComponent();
        }

        private void buttonSinglePlayer_Click(object sender, EventArgs e)
        {
            this.Close();

            Queue<SnakeModel.movement> queueOfMovement = new Queue<SnakeModel.movement>();
            Queue<List<SnakePiecesModel>> queueOfLocationData = new Queue<List<SnakePiecesModel>>();
            Queue<List<SnakeFoodModel>> queueOfAppleLocation = new Queue<List<SnakeFoodModel>>();
            Queue<System.Windows.Forms.Panel> gameMap = new Queue<Panel>();
            Queue<Player> thePlayer = new Queue<Player>();
            thePlayer.Enqueue(new Player());

            SyncEvents mySyncEvents = new SyncEvents();

            SnakeGameModel myGame = new SnakeGameModel(queueOfMovement, queueOfLocationData, queueOfAppleLocation, gameMap, thePlayer, mySyncEvents);   //Running game thread
            SnakeGameForm mySnakeGameForm;                                                                    //GUI thread

            mySnakeGameForm = new SnakeGameForm(queueOfMovement, queueOfLocationData, queueOfAppleLocation, gameMap, thePlayer, mySyncEvents);
           
            myGame.RunningGameThread.Join();
        }
    }
}
