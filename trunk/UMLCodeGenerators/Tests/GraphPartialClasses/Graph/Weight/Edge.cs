namespace GraphPartial
{
    //refines class Edge {
    partial class Edge
    {
        Weight w = new Weight(0);
        public void Weight_SetWeight(Weight _w)
        {
            w = _w;
        }
        public void Weight_Print()
        {
            //original();
            System.Console.Out.Write(" [");
            w.Weight_Print();
            System.Console.Out.Write("] ");
        }
    }
}