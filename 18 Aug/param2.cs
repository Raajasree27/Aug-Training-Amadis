using System;



public class Program
{
    public static void Main()
    {
        int number;
        if (int.TryParse("456", out number))
        {
            Console.WriteLine("Success! Value is: " + number);
        }
        else
        {
            Console.WriteLine("Failed to parse.");
        }

    }
}
