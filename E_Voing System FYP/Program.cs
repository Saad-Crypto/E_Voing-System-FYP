using E_Voing_System_FYP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new StartWindow());
            DBHandler dbHandler = new DBHandler();
            ArrayList array = dbHandler.getAllElections();
            foreach (Election i in array)
            {
                Console.WriteLine(i.electionName);
            }
            
        }

    }
}
