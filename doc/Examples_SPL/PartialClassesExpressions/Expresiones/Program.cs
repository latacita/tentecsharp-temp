using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expresiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer n1 = new Integer(2);
            Integer n2 = new Integer(3);
            Add add1 = new Add(n1, n2);
            add1.print();
            Console.Write("\nThe value of expression is: ");
            Console.Write(add1.eval());
            Console.Read();
        }
    }
}
