using System;
using System.Globalization;

public class Vehicle
{
    private string engineNumber; // can be accessible inside this class
    protected int fuelCapacity; //can be accessible inside vechile class and the class which inherits this class
    public string Brand;

    // Constructor
    public Vehicle(string brand, string engNumber, int fuel)
    {
        Brand = brand;
        engineNumber = engNumber;
        fuelCapacity = fuel;
    }
    //  PUBLIC: Can be called from any object
    public void ShowDetails()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Fuel Capacity: {fuelCapacity} liters");

        // Can access private field inside the class
        Console.WriteLine($"Engine Number: {engineNumber}");
    }

    //  PRIVATE: Internal use only
    private void StartEngine()
    {
        Console.WriteLine("Engine started!");
    }

    //  PUBLIC method to call the private method
    public void Start()
    {
        StartEngine(); // Allowed here
    }
}

public class Bike : Vehicle
{
    public Bike(string brand, string engNumber, int fuel)
        : base(brand, engNumber, fuel)
    {
    }

    public void DisplayFuel()
    {
        // ✅ Can access protected member from base class
        Console.WriteLine($"Fuel capacity from subclass: {fuelCapacity} liters");

        // ❌ engineNumber is private in base class — cannot access here
        // Console.WriteLine(engineNumber);  // ❌ ERROR
    }
}


class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Vehicle("Toyota", "ENG123XYZ", 45);
        car.ShowDetails();         // public method
        car.Start();               // calls private StartEngine internally

        Console.WriteLine(car.Brand);  // ✅ public field

        // ❌ The following are not allowed:
        // Console.WriteLine(car.engineNumber);    // ❌ private
        // Console.WriteLine(car.fuelCapacity);    // ❌ protected

        Bike bike = new Bike("Yamaha", "ENG789ABC", 15);
        bike.DisplayFuel();        // ✅ Shows fuelCapacity (protected)

    }
}