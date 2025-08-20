using System;

public class Products
{
    public string Name { get; set; }
    public decimal price { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine($"The product name: {Name} and price: {price}");
    }
}

public class Electronics:Products
{
    public int warrantyInMonths { get; set; }
    public void ShowWarranty()
    {
        Console.WriteLine($"Warranty: {warrantyInMonths}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       Electronics laptop= new Electronics();
        laptop.Name = "Vivo";
        laptop.price = 15000;
        laptop.warrantyInMonths = 12;
        laptop.ShowDetails();
        laptop.ShowWarranty();
    }
}