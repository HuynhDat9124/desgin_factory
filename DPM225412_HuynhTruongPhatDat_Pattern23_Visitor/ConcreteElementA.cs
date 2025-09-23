
// Concrete Element 1
public class ConcreteElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void OperationA()
    {
        Console.WriteLine("Operation A in ConcreteElementA");
    }
}
