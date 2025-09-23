using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create the elements
        ConcreteElementA elementA = new ConcreteElementA();
        ConcreteElementB elementB = new ConcreteElementB();

        // Add them to the object structure
        ObjectStructure objectStructure = new ObjectStructure();
        objectStructure.AddElement(elementA);
        objectStructure.AddElement(elementB);

        // Create the visitor
        ConcreteVisitor visitor = new ConcreteVisitor();

        // Accept the visitor (this is where the visiting happens)
        objectStructure.Accept(visitor);
    }
}
