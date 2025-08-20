using System;

interface IPaymentGateway
{
    void ProcessPayment(double amount);
}
class CreditCardPayment : IPaymentGateway
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }
}

class PayPalPayment : IPaymentGateway
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount}");
    }
}
class PaymentProcessor
{
    public void MakePayment(IPaymentGateway paymentMethod, double amount)
    {
        paymentMethod.ProcessPayment(amount);
    }
}

// Usage
class Program
{
    static void Main(string[] args)
    {
        PaymentProcessor processor = new PaymentProcessor();

        processor.MakePayment(new CreditCardPayment(), 150.00);
        processor.MakePayment(new PayPalPayment(), 200.00);
    }
}

