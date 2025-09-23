namespace DocumentProcessingApp
{
    // Visitor Interface
    public interface IVisitor
    {
        void Visit(Paragraph paragraph);
        void Visit(Image image);
        void Visit(Table table);
    }
}
