using System;
using System.Globalization;

public class BankAccount
{
    // Private fields (not directly accessible from outside)
    private string accountNumber;
    private decimal balance;

    // Public property for account number (read-only)
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property for balance (read-only)
    public decimal Balance
    {
        get { return balance; }
    }

    // Constructor to initialize account
    public BankAccount(string accNumber, decimal initialBalance)
    {
        accountNumber = accNumber;

        if (initialBalance >= 0)
            balance = initialBalance;
        else
            balance = 0;
    }

    // Public method to deposit money
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("\n\nDeposit is successfulll");
            Console.WriteLine($"Balance after Deposit: {balance}");
        }
        else
            Console.WriteLine("\n\nDeposit amount must be positive.");
    }

    // Public method to withdraw money
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("\n\nWithdrawal was successfull");
            Console.WriteLine($"Balance after Withdrawing amount: {balance}");
        }
        else
            Console.WriteLine("\n\nInvalid withdrawal amount.");
    }
}



class Program
{
    static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount("12345678", 3000.2m);
        account1.Deposit(100m);
        account1.Withdraw(3000);

        BankAccount account2 = new BankAccount("2345678", 2000m);
        account2.Deposit(300);
        account2.Withdraw(3000);//Invalid

       
    }
}