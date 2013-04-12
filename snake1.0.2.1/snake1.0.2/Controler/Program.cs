using System;
using System.Collections.Generic;
using System.Windows.Forms;
using snake1._0._2.View;
using snake1._0._2.Model;

namespace snake1._0._2
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Queue<SnakeModel.movement> queueOfMovement = new Queue<SnakeModel.movement>();
            Queue<List<SnakePiecesModel>> queueOfLocationData = new Queue<List<SnakePiecesModel>>();
            Queue<List<SnakeFoodModel>> queueOfAppleLocation = new Queue<List<SnakeFoodModel>>();
            Queue<System.Windows.Forms.Panel> gameMap = new Queue<Panel>();
            Queue<Player> thePlayer = new Queue<Player>();
            thePlayer.Enqueue(new Player());

            SyncEvents mySyncEvents = new SyncEvents();

            SnakeGameModel myGame = new SnakeGameModel(queueOfMovement, queueOfLocationData, queueOfAppleLocation, gameMap, thePlayer, mySyncEvents);   //Running game thread
            SnakeGameForm mySnakeGameForm;                                                                    //GUI thread

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mySnakeGameForm = new SnakeGameForm(queueOfMovement, queueOfLocationData, queueOfAppleLocation, gameMap, thePlayer, mySyncEvents));

            //mySyncEvents.ExitThreadEvent.Set();
            myGame.RunningGameThread.Join();

        }
    }
}
