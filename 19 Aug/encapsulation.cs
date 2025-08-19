using System;
using System.Globalization;

public class Employee
{
    private string name;
    private int age;

    public  string Name
    {
        get { return name; }
        set { name = value; } // you could add validation here
    }

    public int Age
    {
        get { return age; }
        set
        {
            if(value>=18 && value < 120)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Enter a valid age");
            }
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Employee emp=new Employee();
        emp.Name = "Raaja";
        emp.Age = 18;

        emp.Age = 12; // eventhough it is an error which does not pass the validation it will execute but the value is not passed.
        Console.WriteLine($"Employee: {emp.Name} , {emp.Age}");
      
    }
}