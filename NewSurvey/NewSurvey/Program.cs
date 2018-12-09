using System;

namespace NewSurvey
{
    class Program
    {
        static public event Action Posted;
        static void Main(string[] args)
        {
            var stats = new Stats();
            stats.Start();
            var newParticipant = new Participant();

            Console.WriteLine("What is your name? ");
            newParticipant.Name = TryAnswer();

            Console.WriteLine("How old are you? ");
            newParticipant.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born? ");
            newParticipant.Birthday = TryAnswer();

            if(Posted != null)
                Posted();

            newParticipant.Display();
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

    class Participant
    {
        public string Name;
        public int Age;
        public string Birthday;

        public void Display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", Birthday);

            if (Birthday == "september")
            {
                Console.WriteLine("You are a libra");
            }
            else if (Birthday == "march")
            {
                Console.WriteLine("You are an aries");
            }
        }
    }
}
