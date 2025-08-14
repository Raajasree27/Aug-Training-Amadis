using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("How many numbers do you want to enter?");
        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            numbers.Add(num);
        }

        Console.WriteLine("\nNumbers entered: " + string.Join(", ", numbers));
        Console.WriteLine("Sum: " + numbers.Sum());
        Console.WriteLine("Average: " + numbers.Average());
        Console.WriteLine("Max: " + numbers.Max());
        Console.WriteLine("Min: " + numbers.Min());

        Console.WriteLine("List in reverse: " + string.Join(", ", numbers.AsEnumerable().Reverse()));

        Console.WriteLine("\nDo you want to remove a number from the list? (yes/no)");
        string response = Console.ReadLine().ToLower();

        if (response == "yes")
        {
            Console.Write("Enter the number to remove: ");
            int toRemove = Convert.ToInt32(Console.ReadLine());

            if (numbers.Remove(toRemove))
            {
                Console.WriteLine("Number removed.");
            }
            else
            {
                Console.WriteLine("Number not found in the list.");
            }

            Console.WriteLine("Updated list: " + string.Join(", ", numbers));
        }
    }
}
