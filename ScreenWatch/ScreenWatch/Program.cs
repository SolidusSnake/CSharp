using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ScreenWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ScreenWatch";
            Console.SetWindowSize(60, 15);
            Console.WriteLine("ScreenWatch running...\n");
            
            Stopwatch watch = new Stopwatch();
            watch.Start();
            while (true)
            {
                SendWakeup();
                TimeSpan ts = watch.Elapsed;
                string elapsedTime = String.Format("{0:00}h {1:00}m", ts.Hours, ts.Minutes);
                Console.Clear();
                Console.WriteLine("Runtime: " + elapsedTime);
            }
        }

        static void SendWakeup()
        {
            System.Threading.Thread.Sleep(60000); // time in ms
            SendKeys.SendWait("{NUMLOCK}");
        }
    }
}
