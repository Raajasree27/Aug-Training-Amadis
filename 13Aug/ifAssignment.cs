using System;


namespace Hello_World
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int totalAmount = 200;
            if(totalAmount >= 100)
            {
                Console.WriteLine("You are eligible for the discount of 10%");
                double percent = totalAmount * 0.10;
                double amount =totalAmount - percent;
                Console.WriteLine($"Now you need to pay {amount}");
            }
            else
            {
                Console.WriteLine($"you need to pay {totalAmount}");
            }

        }

    }
}
