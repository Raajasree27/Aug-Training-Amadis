using System;

public class Payroll
{
    public double basicPay { get; set; }
    public double hra { get; set; }
    public double deductions { get; set; }

    public double calculateNetsalary()
    {
        return basicPay + hra - deductions;
    }
}

class Program
{
    static void Main(string[] args)
    {
     Payroll employee = new Payroll();
        Console.WriteLine("enter the basic Pay:");
        employee.basicPay = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the HRA:");
        employee.hra = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the deductions:");
        employee.deductions = Convert.ToDouble(Console.ReadLine());

        double netsalary = employee.calculateNetsalary();
        Console.WriteLine("The net salary is: " + netsalary);

    }
}