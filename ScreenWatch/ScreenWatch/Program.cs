using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace ScreenWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ScreenWatch";
            Console.SetWindowSize(60, 15);
            Console.WriteLine("ScreenWatch running...\n");
            Console.Write("Run indefinitely (Y/N): ");
            var timeline = Console.ReadLine();

            if(timeline.ToLower() == "y")
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                while (true)
                {
                    SendWakeup();
                    TimeSpan ts = watch.Elapsed;
                    string elapsedTime = String.Format("{0:00}h {1:00}m", ts.Hours, ts.Minutes);
                    Console.Clear();
                    Console.WriteLine("Runtime " + elapsedTime);
                }
            }

            else if(timeline.ToLower() == "n")
            {
                Console.Write("Number of hours to run ScreenWatch: ");
                //var hoursInput = int.Parse(Console.ReadLine());
                string hoursInput = Console.ReadLine();
                if (String.IsNullOrEmpty(hoursInput))
                   hoursInput = "1";

                var timeDuration = TimeSpan.FromHours(int.Parse(hoursInput));
                int mm = timeDuration.Hours * 60;

                for (int i = mm; i >= 0; i--)
                {
                    SendWakeup();

                    Console.Clear();
                    Console.WriteLine("=================================================");
                    Console.WriteLine("                  DIFFUSE THE BOMB");
                    Console.WriteLine("");
                    Console.WriteLine("                Time Remaining:  " + i.ToString() + " minutes");
                    Console.WriteLine("");
                    Console.WriteLine("=================================================");

                    if (i == 1)
                    {
                        PlayWarning();
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
            System.Threading.Thread.Sleep(100); // time in ms
            SendKeys.SendWait("{NUMLOCK}");
        }

        static void PlayWarning()
        {
            // Built-in Windows 10 sound
            //SoundPlayer PlayWarning = new SoundPlayer("C:\\windows\\media\\Alarm02.wav");
            System.IO.Stream str = Properties.Resources.mario_06;
            System.Media.SoundPlayer warning = new System.Media.SoundPlayer(str);
            warning.Play();

            // PlayWarning.PlaySync();

            // Mario Bros. intro 
            //Console.Beep(659, 125);
            //Console.Beep(659, 125);
            //System.Threading.Thread.Sleep(125);
            //Console.Beep(659, 125);
            //System.Threading.Thread.Sleep(167);
            //Console.Beep(523, 125);
            //Console.Beep(659, 125);
            //System.Threading.Thread.Sleep(125);
            //Console.Beep(784, 125);
            //System.Threading.Thread.Sleep(375);
            //Console.Beep(392, 125);
        }
    }
}
