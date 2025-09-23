namespace DocumentProcessingApp
{
    // Document (Object Structure)
    public class Document
    {
        private List<IElement> _elements = new List<IElement>();

        public void AddElement(IElement element)
        {
            _elements.Add(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);  // Accept the visitor on each element
            }
        }
    }
}
