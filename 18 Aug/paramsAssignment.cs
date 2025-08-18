using System;


public class Bank
{
   public void checkBalance( double balance)
    {
        Console.WriteLine($"Your current balance is: {balance}");
    }
    public void withdraw(double amount, ref double balance)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"You have withdrawn: {amount}. Your new balance is: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds for this withdrawal.");
        }
    }

    public void GetAccountDetails(out string accountHolderName, out string accountNumber)
    {
        accountHolderName = "John Doe";
        accountNumber = "123456789";
        Console.WriteLine($"Account Holder: {accountHolderName}, Account Number: {accountNumber}");
    }

    public void Receipt(double amount, bool printDate=true)
    {
        Console.WriteLine("Receipt:");
        Console.WriteLine($"Withdrawal: {amount}");

        if (printDate)
        {
            Console.WriteLine($"Date: {DateTime.Now.ToShortDateString()}");
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to simple ATM");
        Bank atm=new Bank();

        string accName, accNumber;
        atm.GetAccountDetails(out accName,out accNumber);

        double balance = 1000.00; 
        atm.checkBalance(balance);

        Console.WriteLine("Enter amount to withdraw:");
        double amount= Convert.ToDouble(Console.ReadLine());
        atm.withdraw(amount, ref balance);

        atm.Receipt(amount, printDate: true);
    }
}