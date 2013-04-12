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
        public enum screenMode { BEGENING = 1, CREATENET, JOINNET, SELECTNETROLE, WAITINGMODE, LOOSE};

        private Queue<SnakeModel.movement> queueOfMovement = new Queue<SnakeModel.movement>();
        private Queue<List<SnakePiecesModel>> queueOfLocationData = new Queue<List<SnakePiecesModel>>();
        private Queue<List<SnakeFoodModel>> queueOfAppleLocation = new Queue<List<SnakeFoodModel>>();
        private Queue<System.Windows.Forms.Panel> gameMap = new Queue<Panel>();
        private Queue<Player> thePlayerQueue = new Queue<Player>();
        private Player thePlayer = new Player();

        private SyncEvents mySyncEvents = new SyncEvents();

        private SnakeGameModel myGame;

        private SnakeGameForm mySnakeGameForm;
        
          
        
        public SnakeMenu()
        {
            InitializeComponent();
            InitializeScreenToMode(screenMode.BEGENING);
        }

        private void buttonSinglePlayer_Click(object sender, EventArgs e)
        {
            if (("Solo Mode").Equals(this.buttonSinglePlayer.Text))
            {
                this.thePlayer.Nickname = this.textBoxPlayerName.Text;
                this.thePlayerQueue.Enqueue(this.thePlayer);

                this.myGame = new SnakeGameModel(this.queueOfMovement, this.queueOfLocationData, this.queueOfAppleLocation, this.gameMap, this.thePlayerQueue, this.mySyncEvents);   //Running game thread

                this.mySnakeGameForm = new SnakeGameForm(this.queueOfMovement, this.queueOfLocationData, this.queueOfAppleLocation, this.gameMap, this.thePlayerQueue, this.mySyncEvents);
                

                this.Visible = false;

                mySnakeGameForm.ShowDialog();
                myGame.RunningGameThread.Join();

                this.Visible = true;
            }
            //else if (("Create Network").Equals(this.buttonSinglePlayer.Text))
            //{
            //    this.InitializeScreenToMode(screenMode.CREATENET);
            //}
        }

        private void buttonMultiPlayer_Click(object sender, EventArgs e)
        {
            if (("Dual Mode").Equals(this.buttonMultiPlayer.Text))
            {
                this.InitializeScreenToMode(screenMode.SELECTNETROLE);
            }
            else if(("Join Network").Equals(this.buttonMultiPlayer.Text))
            {

            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeScreenToMode(screenMode theScreenMode)
        {
            switch(theScreenMode)
            {
                case screenMode.BEGENING:
                    this.buttonQuit.Visible = true;
                    this.labelPlayerName.Visible = true;
                    this.textBoxPlayerName.Visible = true;
                    this.buttonSinglePlayer.Visible = true;
                    this.buttonMultiPlayer.Visible = false;

                    this.groupBoxIPServer.Visible = false;
                    this.labelMessage.Visible = false;
                    this.buttonBack.Visible = false;

                    break;

                case screenMode.CREATENET:
                    this.buttonQuit.Visible = true;
                    this.labelPlayerName.Visible = false;
                    this.textBoxPlayerName.Visible = false;
                    this.buttonSinglePlayer.Visible = false ;
                    this.buttonMultiPlayer.Visible = false;

                    this.groupBoxIPServer.Visible = false;

                    this.labelMessage.Text = "Waiting for Client ...";
                    this.labelMessage.Visible = true;

                    this.buttonBack.Visible = true;

                    break;

                case screenMode.JOINNET:
                    this.buttonQuit.Visible = true;
                    this.labelPlayerName.Visible = false;
                    this.textBoxPlayerName.Visible = false;
                    this.buttonSinglePlayer.Visible = false ;
                    this.buttonMultiPlayer.Visible = false;

                    this.groupBoxIPServer.Visible = true;
                    this.buttonBack.Visible = true;

                    this.labelMessage.Text = "Waiting for connection ...";
                    this.labelMessage.Visible = false;
                    
                    break;

                case screenMode.SELECTNETROLE:
                    this.buttonQuit.Visible = true;
                    this.labelPlayerName.Visible = false;
                    this.textBoxPlayerName.Visible = false;

                    this.buttonSinglePlayer.Text = "Create Network";
                    this.buttonMultiPlayer.Text = "Join Network";
                    this.buttonSinglePlayer.Visible = true ;
                    this.buttonMultiPlayer.Visible = true;

                    this.groupBoxIPServer.Visible = false;
                    this.buttonBack.Visible = true;

                    this.labelMessage.Text = "Waiting for connection ...";
                    this.labelMessage.Visible = false;

                    break;

                case screenMode.WAITINGMODE:
                    this.buttonQuit.Visible = true;
                    this.labelPlayerName.Visible = false;
                    this.textBoxPlayerName.Visible = false;

                    this.buttonSinglePlayer.Text = "Create Network";
                    this.buttonMultiPlayer.Text = "Join Network";
                    this.buttonSinglePlayer.Visible = true ;
                    this.buttonMultiPlayer.Visible = true;

                    this.groupBoxIPServer.Visible = false;
                    this.buttonBack.Visible = true;

                    this.labelMessage.Text = "Waiting for connection ...";
                    this.labelMessage.Visible = false;
                    break;

                case screenMode.LOOSE:
                    break;

                default:
                    break;
            }
        }

    }
}
