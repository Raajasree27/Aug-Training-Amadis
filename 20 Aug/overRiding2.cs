using System;

public class Order
{
    public virtual void ProcessOrder()
    {
        Console.WriteLine("Processing generic order...");
    }
}

public class DineInOrder : Order
{
    public override void ProcessOrder()
    {
        Console.WriteLine("Processing dine-in order with table setup...");
    }
}

public class TakeAwayOrder : Order
{
    public override void ProcessOrder()
    {
        Console.WriteLine("Processing takeaway order with packaging...");
    }
}

// Usage
class Program
{
    static void Main(string[] args)
    {
        Order dineIn = new DineInOrder();
        Order takeaway = new TakeAwayOrder();
        Order order = new Order();

        order.ProcessOrder();   

        dineIn.ProcessOrder();   

        takeaway.ProcessOrder();
    }
}

