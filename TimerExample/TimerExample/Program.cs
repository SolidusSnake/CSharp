//using System;
//using System.Threading;

//class TimerExample
//{
//    static public void Tick(Object stateInfo)
//    {
//        Console.WriteLine("Tick: {0}", DateTime.Now.ToString("h:mm:ss"));
//    }

//    static void Main()
//    {
//        TimerCallback callback = new TimerCallback(Tick);

//        Console.WriteLine("Creating timer: {0}\n",
//                           DateTime.Now.ToString("h:mm:ss"));

//        // create a one second timer tick
//        Timer stateTimer = new Timer(callback, null, 0, 1000);

//        // loop here forever
//        for (; ; )
//        {
//            // add a sleep for 100 mSec to reduce CPU usage
//            Thread.Sleep(100);
//        }
//    }
//}

using System;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static Timer timer = new Timer(1000);
        static int i = 10;

        static void Main(string[] args)
        {
            timer.Elapsed += timer_Elapsed;
            timer.Start();
            Console.Read();
        }

        private static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            i--;

            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("                  DIFFUSE THE BOMB");
            Console.WriteLine("");
            Console.WriteLine("                Time Remaining:  " + i.ToString());
            Console.WriteLine("");
            Console.WriteLine("=================================================");

            if (i == 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("==============================================");
                Console.WriteLine("         B O O O O O M M M M M ! ! ! !");
                Console.WriteLine("");
                Console.WriteLine("               G A M E  O V E R");
                Console.WriteLine("==============================================");

                timer.Close();
                timer.Dispose();
            }

            GC.Collect();
        }
    }
}