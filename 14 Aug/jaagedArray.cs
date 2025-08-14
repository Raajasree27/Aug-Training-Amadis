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
            Console.WriteLine("Enter the number of rows in jagged Array");
            int n=Convert.ToInt32(Console.ReadLine());
            int[][] jaggedArray=new int[n][];
            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the number of columns in jagged Array");
                int columns = Convert.ToInt32(Console.ReadLine());
                jaggedArray[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Enter the element{i} {j}");
                    jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("The jagged array is:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            foreach (var row in jaggedArray)
            {
                foreach (var element in row)
                {
                    sum += element;
                }
            }
            Console.WriteLine($"The sum of all elements in the jagged array is: {sum}");
        }

    }
}
