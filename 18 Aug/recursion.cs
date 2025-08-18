using System;


public class SumExample
{
    public int sum(int x)
    {
        if (x == 1)
        {
            return 1;
        }
        else
        {
            return x + sum(x-1);
        }
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        SumExample example = new SumExample();
        int sum=example.sum(5);
        Console.WriteLine($"THe sum is {sum}");
    }
}