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
            //Console.WriteLine("Enter the rows");
            //Console.WriteLine("Enter the columns");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //int columns = Convert.ToInt32(Console.ReadLine());
            int [,] matrix = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter the value for matrix[{i},{j}]:");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            foreach(int j in matrix)
            {
                
               sum +=j;
                
            }
            Console.WriteLine($"The sum of the matrix elements is: {sum}");

            int min = matrix[0,0];
            for (int i = 0; i < matrix.GetLength(0); i++) // Rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Columns
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Minimum value in the matrix: " + min);

            int max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++) // Rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Columns
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Maximum value in the matrix: " + max);

        }

    }
}
