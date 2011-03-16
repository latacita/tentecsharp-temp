using System;
using Expresiones;


namespace Expresiones
{
    public partial class Mult
    {
        
        /**
         * Method to print an expression in infix format
         * */
        public void print()
        {
            Console.Write("(");
            exp_izquierda.print();
            Console.Write("*");
            exp_derecha.print();
            Console.Write(")");
        }//print
    }//Mult
}//Expresiones