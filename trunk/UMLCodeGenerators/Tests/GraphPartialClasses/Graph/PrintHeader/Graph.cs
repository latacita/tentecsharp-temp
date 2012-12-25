namespace GraphPartial
{
    //refines class Graph {
    partial class Graph
    {
        static int s = 0;
        public virtual void PrintHeader_Print()
        {
            s++;
            if (s == 1)
            {
                PrintHeader_PrintTopLevelHeader();
            }
            else
            {
                PrintHeader_PrintSubLevelHeader();
            }
            //original();
            s--;
        }
        static void PrintHeader_PrintTopLevelHeader()
        {
            System.Console.Out.Write("top: ");
        }
        static void PrintHeader_PrintSubLevelHeader()
        {
            System.Console.Out.Write("sub: ");
        }
       
    }
}