using System;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;

namespace DocumentProcessingApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create elements
            var paragraph1 = new Paragraph("This is the first paragraph.");
            var image1 = new Image("path/to/image.jpg");
            var table1 = new Table("Customer Data");

            // Create document and add elements
            var document = new Document();
            document.AddElement(paragraph1);
            document.AddElement(image1);
            document.AddElement(table1);

            // Create visitors
            var renderVisitor = new RenderVisitor();
            var exportPdfVisitor = new ExportToPdfVisitor();

            // Perform operations on the document using the visitors
            Console.WriteLine("Rendering Document:");
            document.Accept(renderVisitor);  // Render the document

            Console.WriteLine("\nExporting Document to PDF:");
            document.Accept(exportPdfVisitor);  // Export the document to PDF
        }
    }
}
namespace DocumentProcessingApp
{
}
namespace DocumentProcessingApp
{
}
namespace DocumentProcessingApp
{
}
namespace DocumentProcessingApp
{
}
namespace DocumentProcessingApp
{
}


namespace DocumentProcessingApp
{
}
namespace DocumentProcessingApp
{
}
namespace DocumentProcessingApp
{
}
