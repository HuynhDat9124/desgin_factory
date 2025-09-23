
// Concrete Element 2
public class ConcreteElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void OperationB()
    {
        Console.WriteLine("Operation B in ConcreteElementB");
    }
}
