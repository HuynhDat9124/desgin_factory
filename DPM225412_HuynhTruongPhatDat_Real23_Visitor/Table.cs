namespace DocumentProcessingApp
{
    // Concrete Element 3: Table
    public class Table : IElement
    {
        public string TableName { get; set; }

        public Table(string tableName)
        {
            TableName = tableName;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Render()
        {
            Console.WriteLine("Rendering Table: " + TableName);
        }
    }
}
