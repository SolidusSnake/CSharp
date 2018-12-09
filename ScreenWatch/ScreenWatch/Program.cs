using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ScreenWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ScreenWatch running...\n");
            Console.Write("Run indefinitely (Y/N): ");
            var timeline = Console.ReadLine();

            if(timeline.ToLower() == "y")
            {
                while(true)
                {
                    SendWakeup();
                }
            }

            else if(timeline.ToLower() == "n")
            {
                Console.Write("Number of hours to run ScreenWatch: ");
                var hoursInput = int.Parse(Console.ReadLine());
                var timeDuration = TimeSpan.FromHours(hoursInput);
                int mm = timeDuration.Hours * 60;

                for (int i = mm; i >= 0; i--)
                {
                    SendWakeup();
                    //Console.WriteLine("Time left: {0} minutes", i);

                    Console.Clear();
                    Console.WriteLine("=================================================");
                    Console.WriteLine("                  DIFFUSE THE BOMB");
                    Console.WriteLine("");
                    Console.WriteLine("                Time Remaining:  " + i.ToString());
                    Console.WriteLine("");
                    Console.WriteLine("=================================================");

                    if (i == 1)
                    {
                        // Mario Bros. intro 
                        Console.Beep(659, 125);
                        Console.Beep(659, 125);
                        System.Threading.Thread.Sleep(125);
                        Console.Beep(659, 125);
                        System.Threading.Thread.Sleep(167);
                        Console.Beep(523, 125);
                        Console.Beep(659, 125);
                        System.Threading.Thread.Sleep(125);
                        Console.Beep(784, 125);
                        System.Threading.Thread.Sleep(375);
                        Console.Beep(392, 125);
                        //Console.WriteLine("ScreenWatch ending soon...");
                    }

                    if (i == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("==============================================");
                        Console.WriteLine("         B O O O O O M M M M M ! ! ! !");
                        Console.WriteLine("");
                        Console.WriteLine("               G A M E  O V E R");
                        Console.WriteLine("==============================================");
                        Console.ReadLine();
                    }
                }
            }
        }

        static void SendWakeup()
        {
            System.Threading.Thread.Sleep(500);
            SendKeys.SendWait("{NUMLOCK}");
        }
    }
}
