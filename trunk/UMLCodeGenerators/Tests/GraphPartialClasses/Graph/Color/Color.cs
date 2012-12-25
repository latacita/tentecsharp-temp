namespace GraphPartial
{
    class Color
    {
        int val = 0;
        public Color(int v)
        {
            val = v;
        }
        public static void Color_SetDisplayColor(Color c)
        {
            System.Console.Out.WriteLine("color changed to: " + c.val);
        }
    }
}