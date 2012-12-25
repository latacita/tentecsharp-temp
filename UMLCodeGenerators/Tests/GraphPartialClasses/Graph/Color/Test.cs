namespace GraphPartial
{
    partial class Test
    {
        public static void Color_Test()
        {            
            //BasicGraph_Main(args);
            System.Console.Out.WriteLine("========= ColorGraph ========");
            Graph g = new Graph();
            g.BasicGraph_Add(new Node(5), new Node(6));
            g.BasicGraph_Add(new Node(7), new Node(8));
            g.BasicGraph_Print();
            System.Console.Out.WriteLine();
        }
    }
}
