using System;

public abstract class Document
{
    public string Title { get; set; }
    public abstract void Print();
}
public  class WordDocument : Document
{
    public override void Print()
    {
        Console.WriteLine($"Printing the Word Document with Title: {Title}");
    }
}
public class PdfDocument : Document
{
    public override void Print()
    {
        Console.WriteLine($"Printing the pdf Document with Title: {Title}");
    }
}

// Usage
class Program
{
    static void Main(string[] args)
    {
        
        Document word = new WordDocument { Title = "Fundamentals of AI" };
        word.Print();
        Document pdf= new PdfDocument { Title="Introduction to Cloud"};
        pdf.Print();


    }
}

