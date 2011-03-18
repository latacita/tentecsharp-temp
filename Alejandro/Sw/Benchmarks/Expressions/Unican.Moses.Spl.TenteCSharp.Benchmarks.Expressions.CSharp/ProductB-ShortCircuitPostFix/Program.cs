using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Expresiones;

namespace ProductB_ShortCircuitPostFix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Examples with 2 integer
            IntegerPostFixEval integer1 = new IntegerPostFixEval(8);
            IntegerPostFixEval integer2 = new IntegerPostFixEval(9);
            Console.Write("Two Integer Expression:\n");
            integer1.print();
            Console.Write("\n");
            integer2.print();
            Console.Write("\n");
            //Example: 8 9 +
            AddPostFixEval add1 = new AddPostFixEval(integer1, integer2);
            Console.Write("Add Expression\n");
            add1.print();
            Console.Write("\n");
            Console.Write("Expression Value is:\n");
            Console.WriteLine(add1.eval());            
            //Example 8 9 *
            MultPostFixEval mult1 = new MultPostFixEval(integer1, integer2);
            Console.Write("Mult Expression\n");
            mult1.print();
            Console.Write("\n");
            Console.Write("Expression Value is:\n");
            Console.WriteLine(mult1.eval());
            //Combined expressions
            MultPostFixEval multCombined = new MultPostFixEval(add1, mult1);
            Console.Write("Combined Expression:\n");
            multCombined.print();
            Console.Write("\n");
            Console.Write("Expression Value is:\n");
            Console.WriteLine(multCombined.eval());
            Console.ReadLine();
        }
    }
}
