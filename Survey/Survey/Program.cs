﻿using System;

namespace HSurvey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            var name = TryAnswer();

            Console.WriteLine("How old are you? ");
            var age = TryAnswer();

            Console.WriteLine("What month were you born? ");
            var month = TryAnswer();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if(month == "september")
            {
                Console.WriteLine("You are a libra");
            }
            else if(month == "march")
            {
                Console.WriteLine("You are an aries");
            }
        }

        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}
