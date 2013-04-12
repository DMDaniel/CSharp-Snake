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
            SnakeMenu mySnakeGameMenu;                                                                    //GUI thread

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mySnakeGameMenu = new SnakeMenu());

        }
    }
}
