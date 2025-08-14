using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Transactions;


namespace Hello_World
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            String input = Console.ReadLine();

            String[] words = input.Split(' ');// Split the input into words
            Console.WriteLine("You entered words."+ words.Length);

            //reverse the words
            StringBuilder reverse = new StringBuilder();
            for(int i = input.Length - 1; i >= 0; i--)
            {
                reverse.Append(input[i]);
            }
            Console.WriteLine("Reversed sentence: " + reverse.ToString());

            //replacing
            String replaced = input.Replace(" ", "-");
            Console.WriteLine("Replaced sentence: " + replaced);
        }

    }
}
