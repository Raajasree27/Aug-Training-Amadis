using System;


namespace Hello_World
{
    public class Class1
    {
        static void Main(string[] args)
        {
            String pass = "Openseasme";
            while(true)
            {
                Console.WriteLine("Enter the password");
                if(pass==Console.ReadLine())
                {
                    Console.WriteLine("Welcome to the program");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password, try again");
                }
            }


        }

    }
}
