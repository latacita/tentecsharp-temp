namespace GraphPartial
{
    //refines class Node {
    partial class Node
    {
        private Graph childGraph = null;
        public void Recursive_SetChildGraph(Graph g)
        {
            childGraph = g;
        }
        Graph Recursive_GetChildGraph()
        {
            return childGraph;
        }
        public void Recursive_Print()
        {
            //BasicGraph_Print();
            if (childGraph != null)
            {
                System.Console.Out.Write(" ++ ");
                childGraph.BasicGraph_Print();
                System.Console.Out.Write(" -- ");
            }
        }
    }
}