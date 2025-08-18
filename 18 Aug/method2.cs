using System;
using System.Runtime.CompilerServices;


public class AuthProgram
{
    public decimal balance { get; private set; } = 1000m;
    public bool withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

}
public class Program
{
    public static void Main()
    {
        AuthProgram bank=new AuthProgram();
        Console.WriteLine("Initial Balance: " + bank.balance);
        Console.WriteLine("Enter the amount to be withdrawn:");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        bool success = bank.withdraw(amount);
        if (success)
        {
            Console.WriteLine("Withdrawal successful. New Balance: " + bank.balance);
        }
        else
        {
            Console.WriteLine("Withdrawal failed. Insufficient balance.");
        }

    }
}
