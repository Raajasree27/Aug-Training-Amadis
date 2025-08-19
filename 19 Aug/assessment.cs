using System;
using System.Runtime.CompilerServices;

public class Student
{
    private string name;
    private int rollNumber;
    private char grade;

    public static int TotalStudent = 0;
    public string Name
    {
        get { return name; }
        set
        {
            name = value;
        }
    }
    public int RollNumber
    {
        get { return rollNumber; }
        set
        {
            rollNumber = value;
        }
    }
    public char Grade
    {
        get { return grade; }
    }
    public  Student(string name,int rollNumber,char grade)
    {
        Name = name;
        RollNumber = rollNumber;
        this.grade = grade;

        TotalStudent++;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Student Details: {name} {rollNumber} {grade}");
        Console.WriteLine("Students enrolled  " + TotalStudent);
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Student std1 = new Student("Raaja", 12, 'A');
        std1.DisplayInfo();

    }

}