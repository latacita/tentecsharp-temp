namespace GraphPartial
{
    partial class Edge
    {
        Node a, b;
        public Edge(Node _a, Node _b) { a = _a; b = _b; }
        public virtual void BasicGraph_Print()
        {
            System.Console.Out.Write("edge (");
            a.BasicGraph_Print();
            System.Console.Out.Write(", ");
            b.BasicGraph_Print();
            System.Console.Out.Write(") ");
        }
    }
}
