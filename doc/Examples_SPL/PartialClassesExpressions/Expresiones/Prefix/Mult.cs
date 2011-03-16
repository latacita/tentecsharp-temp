using System;
using Expresiones;


namespace Expresiones
{
    public partial class Mult: IBinaryOperator
    {
        
        /**
         * Method to print an expression in postfix format
         * */
        public void print()
        {
            Console.Write("*");
            Console.Write(" ");
            exp_izquierda.print();
            Console.Write(" ");
            exp_derecha.print();
        }//print
    }//Mult
}//Expresiones