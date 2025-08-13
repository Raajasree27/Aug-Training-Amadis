using System;


namespace Hello_World
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int choice = 2;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Start Game");
                    break;
                case 2:
                    Console.WriteLine("Load Game");
                    break;
                case 3:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }


        }

    }
}
