namespace GraphPartial
{
    //refines class Node {
    partial class Node
    {
        Color color = new Color(815);
        public virtual void Color_Print()
        {
            Color.Color_SetDisplayColor(color);
            //BasicGraph_Node_Print();
        }
    }
}
