namespace GraphPartial
{
    partial class Test
    {
        public static void BasicGraph_Test()
        {
            System.Console.Out.WriteLine("========= BasicGraph ========");
            Graph g = new Graph();
            g.BasicGraph_Add(new Node(1), new Node(2));
            g.BasicGraph_Add(new Node(3), new Node(4));
            g.BasicGraph_Print();
            System.Console.Out.WriteLine();
        }
    }
}
