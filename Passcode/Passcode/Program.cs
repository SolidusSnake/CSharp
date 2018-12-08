using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";
            while (code != "secret")
            {
                Console.WriteLine("\nWhat's the 'secret' passcode?");
                code = Console.ReadLine();

                if (code != "secret")
                {
                    Console.WriteLine("Not authenticated!");
                }
            }
            Console.WriteLine("Authenticated");
        }
    }
}
