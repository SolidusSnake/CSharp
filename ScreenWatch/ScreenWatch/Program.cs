using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ScreenWatch running...");

            for (int i = 0; i < 3; i++)
            {
                System.Threading.Thread.Sleep(5000);
               
            }

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

            Console.WriteLine("ScreenWatch ending...");
        }
    }
}
