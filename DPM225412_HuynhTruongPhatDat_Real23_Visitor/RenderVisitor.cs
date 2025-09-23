namespace DocumentProcessingApp
{
    // Concrete Visitor: Rendering Visitor
    public class RenderVisitor : IVisitor
    {
        public void Visit(Paragraph paragraph)
        {
            paragraph.Render();  // Render the paragraph
        }

        public void Visit(Image image)
        {
            image.Render();  // Render the image
        }

        public void Visit(Table table)
        {
            table.Render();  // Render the table
        }
    }
}
