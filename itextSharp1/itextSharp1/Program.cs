using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

class Program
{
    static void Main()
    {
        // Your text content
        string textToConvert = "This PDF was saved to a specific path using iTextSharp.";

        // ✅ Specify your desired output path
        // Make sure the folder exists!
        string outputPath = @"C:\Users\raaja\Documents\Sample.pdf";

        // Create a Document object
        Document pdfDoc = new Document(PageSize.A4);

        try
        {
            // Ensure the directory exists
            string directory = Path.GetDirectoryName(outputPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Create a PDF writer that writes to the specified path
            PdfWriter.GetInstance(pdfDoc, new FileStream(outputPath, FileMode.Create));

            // Open the Document for writing
            pdfDoc.Open();

            // Add your content
            pdfDoc.Add(new Paragraph(textToConvert));

            Console.WriteLine("PDF created successfully at: " + outputPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // Close the document
            if (pdfDoc.IsOpen())
                pdfDoc.Close();
        }
    }
}