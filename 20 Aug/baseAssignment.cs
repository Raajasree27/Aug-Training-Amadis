using System;
using System.Collections.Specialized;
using System.Globalization;

public class Employee
{
    public string Name { get; set; }
    public void Work()
    {
        Console.WriteLine($"Employee Name: {Name}");
    }
}
public class Manager : Employee
{
    public string Position { get; set; }
    public void ConductMeeting()
    {
        Console.WriteLine($"Employee Position: {Position}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager();
        manager.Name = "Mano";
        manager.Position = "Product Manager";

        manager.Work();
        manager.ConductMeeting();

    }
}