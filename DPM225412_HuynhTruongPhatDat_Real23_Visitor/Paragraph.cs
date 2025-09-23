namespace DocumentProcessingApp
{
    // Concrete Element 1: Paragraph
    public class Paragraph : IElement
    {
        public string Text { get; set; }

        public Paragraph(string text)
        {
            Text = text;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Render()
        {
            Console.WriteLine("Rendering Paragraph: " + Text);
        }
    }
}
