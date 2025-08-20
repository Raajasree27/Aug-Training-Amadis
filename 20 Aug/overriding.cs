using System;

public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat says Meow");
    }
}

// Usage
class Program
{
    static void Main(string[] args)
    {
        Animal myCat = new Cat();
        myCat.Speak();  
    }
}

