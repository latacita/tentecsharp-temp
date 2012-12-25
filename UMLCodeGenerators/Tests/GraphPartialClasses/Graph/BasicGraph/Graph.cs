namespace GraphPartial
{
    using System.Collections.Generic;
    partial class Graph
    {
        List<Node> nodes = new List<Node>();
        List<Edge> edges = new List<Edge>();
        public virtual Edge BasicGraph_Add(Node n, Node m)
        {
            Edge e = new Edge(n, m);
            nodes.Add(n); nodes.Add(m);
            edges.Add(e);
            return e;
        }
        public virtual void BasicGraph_Print()
        {
            for (int i = 0; i < edges.Count; i++)
            {
                ((Edge)edges[i]).BasicGraph_Print();
                if (i < edges.Count - 1)
                    System.Console.Out.Write(", ");
            }
        }        
    }
}
