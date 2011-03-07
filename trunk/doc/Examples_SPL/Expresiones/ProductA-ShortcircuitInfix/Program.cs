using System;
using Expresiones;

namespace ProductA_ShortcircuitInfix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Examples with 2 integer
            IntegerInfixEval integer1 = new IntegerInfixEval(10);
            IntegerInfixEval integer2 = new IntegerInfixEval(2);
            Console.Write("Two Integer Expression:\n");
            integer1.print();
            Console.Write("\n");
            integer2.print();
            Console.Write("\n");
            //Example: (10+2)
            AddInfixEval add1 = new AddInfixEval(integer1, integer2);
            Console.Write("Add Expression\n");
            add1.print();
            Console.Write("\n");
            Console.Write("Expression Value is:\n");
            Console.WriteLine(add1.eval());
            //Example (8*9)
            MultInfixEval mult1 = new MultInfixEval(integer1, integer2);
            Console.Write("Mult Expression\n");
            mult1.print();
            Console.Write("\n");
            Console.Write("Expression Value is:\n");
            Console.WriteLine(mult1.eval());
            //Combined expressions
            MultInfixEval multCombined = new MultInfixEval(add1, mult1);
            Console.Write("Combined Expression:\n");
            multCombined.print();
            Console.Write("\n");
            Console.Write("Expression Value is:\n");
            Console.WriteLine(multCombined.eval());
            Console.ReadLine();
        }
    }
}
