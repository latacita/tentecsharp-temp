namespace GraphPartial
{
    partial class Test
    {
        public static void Recursive_Test()
        {
            //original(args);
            System.Console.Out.WriteLine("========= SubGraph ========");
            Graph g = new Graph();
            Graph g1 = new Graph();
            g1.BasicGraph_Add(new Node(11), new Node(12));
            Graph g2 = new Graph();
            g2.BasicGraph_Add(new Node(21), new Node(22));
            Graph g3 = new Graph();
            g3.BasicGraph_Add(new Node(31), new Node(32));
            Graph g4 = new Graph();
            Node n41 = new Node(41);
            g4.BasicGraph_Add(n41, new Node(42));

            Graph g5 = new Graph();
            g5.BasicGraph_Add(new Node(51), new Node(52));
            n41.Recursive_SetChildGraph(g5);

            Node n1 = new Node(1);
            n1.Recursive_SetChildGraph(g1);
            Node n2 = new Node(2);
            n2.Recursive_SetChildGraph(g2);
            Node n3 = new Node(3);
            n3.Recursive_SetChildGraph(g3);
            Node n4 = new Node(4);
            n4.Recursive_SetChildGraph(g4);

            //
            n1.Recursive_Print();
            n2.Recursive_Print();
            n3.Recursive_Print();
            n4.Recursive_Print();
            //

            g.BasicGraph_Add(n1, n2);
            g.BasicGraph_Add(n3, n4);
            g.BasicGraph_Print();
            System.Console.Out.WriteLine();
        }
    }
}
