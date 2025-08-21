using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Console.WriteLine(documentsPath);
        Console.WriteLine("Enter the fileName");
        string fileName = Console.ReadLine();

        string folderPath = Path.Combine(documentsPath, fileName);

        if (Directory.Exists(folderPath))
        {
            Console.WriteLine("THe folder is located at:" + folderPath);
        }
        else
        {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("The folder is created");
        }
    }
}