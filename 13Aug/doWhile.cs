using System;


namespace Hello_World
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int num = 6;
            int guess;
            do
            {
                Console.Write("Guess a number (1-10): ");
                string input = Console.ReadLine();
                if(!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }
                if (guess==num)
                {
                    Console.WriteLine("Congratulations! You guessed the number.");
                }
                else
                {
                    Console.WriteLine("Try again.");
                }
            } while (guess!=num);


        }

    }
}
