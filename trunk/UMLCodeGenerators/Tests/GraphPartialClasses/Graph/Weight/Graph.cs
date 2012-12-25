namespace GraphPartial
{
    //refines class Graph {
    partial class Graph
    {
        public virtual Edge Weight_Add(Node n, Node m, Weight w)
        {
            Edge res = this.BasicGraph_Add(n, m);
            res.Weight_SetWeight(w);
            return res;
        }                
    }
}
