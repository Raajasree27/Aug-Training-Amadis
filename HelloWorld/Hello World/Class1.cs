using System;


namespace Hello_World
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, -3, 7, -1, 0, 4 };
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    sum += num;
                }
               
            }
            Console.WriteLine("The sum of positive numbers is: " + sum);

        }

    }
}
