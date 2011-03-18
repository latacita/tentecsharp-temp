using System;
using Expresiones;


namespace Expresiones
{
    public partial class Mult:IBinaryOperator
    {
        
        /**
         * Method to print an expression in postfix format
         * */
        public void print()
        {
            exp_izquierda.print();
            Console.Write(" ");
            exp_derecha.print();
            Console.Write(" ");
            Console.Write("*");
        }//print
    }//Mult
}//Expresiones