namespace DocumentProcessingApp
{
    // Concrete Visitor: Export to PDF Visitor
    public class ExportToPdfVisitor : IVisitor
    {
        public void Visit(Paragraph paragraph)
        {
            Console.WriteLine("Exporting Paragraph to PDF: " + paragraph.Text);
        }

        public void Visit(Image image)
        {
            Console.WriteLine("Exporting Image to PDF: " + image.ImagePath);
        }

        public void Visit(Table table)
        {
            Console.WriteLine("Exporting Table to PDF: " + table.TableName);
        }
    }
}
