
// Concrete Visitor
public class ConcreteVisitor : IVisitor
{
    public void Visit(ConcreteElementA elementA)
    {
        Console.WriteLine("Visiting ConcreteElementA and performing an operation.");
        elementA.OperationA();
    }

    public void Visit(ConcreteElementB elementB)
    {
        Console.WriteLine("Visiting ConcreteElementB and performing an operation.");
        elementB.OperationB();
    }
}
