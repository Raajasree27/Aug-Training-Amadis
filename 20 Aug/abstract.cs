using System;

public abstract class BaseClass
{
    public abstract void MustImplement(); // No body

    public void SharedMethod() // Optional concrete method
    {
        Console.WriteLine("Common behavior");
    }
}

public class DerivedClass : BaseClass
{
    public override void MustImplement()
    {
        Console.WriteLine("Implemented in derived class");
    }
}

// Usage
class Program
{
    static void Main(string[] args)
    {
       BaseClass baseClass = new DerivedClass();
        baseClass.SharedMethod();
        baseClass.MustImplement();
    }
}

