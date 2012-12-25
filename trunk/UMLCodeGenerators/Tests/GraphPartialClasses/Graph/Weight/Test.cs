namespace GraphPartial
{
    partial class Test
    {
        public static void Weight_Test()
        {
            //original(args);
            System.Console.Out.WriteLine("========= WeightedGraph ========");
            Graph g = new Graph();
            g.Weight_Add(new Node(5), new Node(6), new Weight(1000));
            g.Weight_Add(new Node(7), new Node(8), new Weight(1001));
            g.BasicGraph_Print();
            System.Console.Out.WriteLine();
        }
	}
}
