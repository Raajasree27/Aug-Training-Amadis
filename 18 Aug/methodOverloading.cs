using System;

public class Calculator
{
    // 1. Add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // 2. Add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // 3. Add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }

    // 4. Add int and double (different order)
    public double Add(int a, double b)
    {
        return a + b;
    }

    public double Add(double a, int b)
    {
        return a + b;
    }
}
public class Program
{
    public static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Add(2, 3) = " + calc.Add(2, 3));                   // Uses int Add(int, int)
        Console.WriteLine("Add(2, 3, 4) = " + calc.Add(2, 3, 4));             // Uses int Add(int, int, int)
        Console.WriteLine("Add(2.5, 3.5) = " + calc.Add(2.5, 3.5));           // Uses double Add(double, double)
        Console.WriteLine("Add(2, 3.5) = " + calc.Add(2, 3.5));               // Uses double Add(int, double)
        Console.WriteLine("Add(2.5, 3) = " + calc.Add(2.5, 3));               // Uses double Add(double, int)
    }
}
