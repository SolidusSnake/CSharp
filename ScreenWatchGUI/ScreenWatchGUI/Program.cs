using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenWatchGUI
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

            SendWakeup();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            while (true)
            {
                SendWakeup();
                TimeSpan ts = watch.Elapsed;
                string elapsedTime = String.Format("{0:00}h {1:00}m", ts.Hours, ts.Minutes);
            }
        }

        static void SendWakeup()
        {
            System.Threading.Thread.Sleep(5000); // time in ms
            SendKeys.SendWait("{NUMLOCK}");
        }
    }
}
