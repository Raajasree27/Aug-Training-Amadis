using System;
using System.Transactions;

//public class Tax
//{
//    public double ApplyTax(ref double price)
//    {
//        double taxs=price*0.18;
//        price += taxs;
//        return price;

//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Tax tax = new Tax();
//        Console.WriteLine("Enter the price");
//        double price = Convert.ToDouble(Console.ReadLine());
//        double finalPrice = tax.ApplyTax(ref price);
//        Console.WriteLine("The final price after tax is: " + finalPrice);

//    }
//}

public class Name
{
    public void SplitName(string fullName, out string first_name, out string last_name)
    {
        string[] names = fullName.Split(' ');

        first_name = names[0];
        last_name = names.Length > 1 ? names[1] : "";
    }   
}
class Program
{
    public  static void Main(string[] args)
    {
        Name n = new Name();
        Console.WriteLine("Enter your full Name:");
        string name=Console.ReadLine();
        string first, last;
        n.SplitName(name, out first, out last);
        Console.WriteLine("First Name: " + first);
        Console.WriteLine("Last Name: " + last);
    }
}