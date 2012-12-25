namespace GraphPartial
{
    //refines class Edge {
    partial class Edge
    {
        Color color = new Color(4711);
        public void Color_Print()
        {
            Color.Color_SetDisplayColor(color);
            //BasicGraph_Edge_Print();
        }
    }
}
