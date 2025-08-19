using System;
using System.Globalization;

public class User
{
    public string Name;

    // Static field to keep count of users created
    public static int UserCount = 0;

    public User(string name)
    {
        Name = name;
        UserCount++;  // Increment count each time a new user is created
    }

    public static void ShowUserCount()
    {
        Console.WriteLine($"Total users created: {UserCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        User u1 = new User("Alice");
        User u2 = new User("Bob");

        User.ShowUserCount();

        User u3 = new User("Charlie");

        User.ShowUserCount();  

      
    }
}