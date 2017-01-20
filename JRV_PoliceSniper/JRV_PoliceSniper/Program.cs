/*
 * JRV_PoliceSniper by James R. Vaughan 
 * 
 * A simple game created in Visual C#
 * 
 * Bad guys have overrun the building!
 * Neutralize the bad guys by clicking on them.
 * If you click on a good guy, the game is over.
 * As time progresses, bad guys and good guys appear and disappear more quickly, making the game more challenging.
 *
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRV_PoliceSniper
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
            Application.Run(new Form1());
        }
    }
}
