namespace DocumentProcessingApp
{
    // Concrete Element 2: Image
    public class Image : IElement
    {
        public string ImagePath { get; set; }

        public Image(string imagePath)
        {
            ImagePath = imagePath;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Render()
        {
            Console.WriteLine("Rendering Image from: " + ImagePath);
        }
    }
}
