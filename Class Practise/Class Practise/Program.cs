using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter your Name");
            String Name = Console.ReadLine();
            Console.WriteLine("Enter the email");
            String Mail = Console.ReadLine();

           

            //Validation
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(Mail, emailPattern))
            {
                Console.WriteLine("Please enter a valid email address.");

            }
            else
            {
                String DocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Console.WriteLine(DocumentPath);
                

                Console.WriteLine("Enter the folder Name");
                string folderPath = Console.ReadLine();

                string fullFolder=Path.Combine(DocumentPath, folderPath);

                if (Directory.Exists(fullFolder))
                {
                    Console.WriteLine("The folder already exists");
                }
                else
                {
                    Directory.CreateDirectory(fullFolder);
                    Console.WriteLine("The Folder Path is " + Path.GetFullPath( fullFolder));
                    
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}