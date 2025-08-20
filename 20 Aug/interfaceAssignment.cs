using System;

interface IVehicle
{
    void Start();
    void Stop();
}
 class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car is Starting");
    }
    public void Stop()
    {
        Console.WriteLine("Car is Stopping");
    }
}

class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike is Starting");
    }
    public void Stop()
    {
        Console.WriteLine("Bike is Stopping");
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<IVehicle> list = new List<IVehicle> { new Car(),new Bike() };
        foreach (IVehicle vehicle in list)
        {
            vehicle.Start();
            vehicle.Stop();
            Console.WriteLine();
        }

    }
}