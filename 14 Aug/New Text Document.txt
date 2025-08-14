using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using System.Transactions;


namespace Hello_World
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers =new int[n];
            
            for (int i = 0; i < n; i++)
            {
               Console.WriteLine("Enter element " + (i + 1) + ":");
               numbers[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Th sum of Array is :");
            int sum = 0;
            foreach (int j in numbers)
            {
                sum = sum + j;
            }
            Console.WriteLine(sum);
            
            double averge = sum/n;
            Console.WriteLine($"The average of the array is:{averge}");

            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Array.Reverse(numbers);
            Console.WriteLine("The reverse of the array is:");
            foreach(int k in numbers)
            {
                Console.Write(k + " ");
            }   





        }

    }
}
