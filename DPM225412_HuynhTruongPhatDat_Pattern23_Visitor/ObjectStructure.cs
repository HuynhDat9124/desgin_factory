
// ObjectStructure: A collection of elements
public class ObjectStructure
{
    private List<IElement> elements = new List<IElement>();

    public void AddElement(IElement element)
    {
        elements.Add(element);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var element in elements)
        {
            element.Accept(visitor);
        }
    }
}
