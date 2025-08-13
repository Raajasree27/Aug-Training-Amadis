using System;


namespace Hello_World
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= (2 * n - 1); j++)
                {
                    if(j>=n-(i-1)&& j <= n + (i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            

        }

    }
}
