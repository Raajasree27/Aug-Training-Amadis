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
            List<string> fruits = new List<string>();

            // Add elements
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");

            // Access elements
            Console.WriteLine(fruits[0]);  // Apple

            // Count
            Console.WriteLine(fruits.Count); // 3

            // Remove
            fruits.Remove("Banana");

            // Insert at index
            fruits.Insert(1, "Mango");

            // Check if item exists
            if (fruits.Contains("Cherry"))
            {
                Console.WriteLine("Cherry is in the list.");
            }

            // Loop through list
            foreach (string fruit in fruits)
            {
                Console.Write(fruit+" ");
            }
        }

    }
}
