using System;
using System.Globalization;

public class Product
{
    public string Name;
    public double Price;
}

class Program
{
    static void Main(string[] args)
    {
        Product prod = new Product
        {
            Name = "Laptop",
            Price = 59999.99
        };
        Console.WriteLine($"Name and Price is {prod.Name},{prod.Price}");

    }
}