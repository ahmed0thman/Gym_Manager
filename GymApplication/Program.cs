using GymApp.Logic.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace GymApplication
{
    static class Program
    {
        public static Captin captinLogedIN = new Captin();
        public static Form1 main;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
