namespace GraphPartial
{
    partial class Node
    {
        int id = 0;
        public Node(int _id) { id = _id; }
        public virtual void BasicGraph_Print()
        {
            System.Console.Out.Write(id);
        }
    }
}