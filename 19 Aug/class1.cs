using System;

public class BankAccount
{
    private string accountHolder;
    private decimal balance;

    public BankAccount(string name,decimal initialBalance)
    {
        accountHolder = name;
        balance = initialBalance;
        Console.WriteLine($"Intial Balance: {balance}");
    }
    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"\n\nDeposited Amount: {amount}");
        Console.WriteLine($"Balance after deposit: {balance}");
    }
    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"\nWithdrawn Amount: {amount}");
            Console.WriteLine($"Balance after withdrawn: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
    public void PrintBalance()
    {
        Console.WriteLine($"\n\nBalance: {balance}");
    }
}
class program
{
    static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount("Alice",1000);
        account1.Deposit(100);
        account1.Withdraw(200);
        account1.PrintBalance();



    }
}