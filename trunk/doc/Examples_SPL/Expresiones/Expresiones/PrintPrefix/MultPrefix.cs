using System;
using Expresiones;


namespace Expresiones
{

    public class MultPrefix : IBinaryOperatorPrefix, IMult
    {
        IExpressionPrefix exp_izquierda;
        IExpressionPrefix exp_derecha;
        /**
         * Constructor
         * */
        public MultPrefix(IExpressionPrefix izq, IExpressionPrefix derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }//Constructor
        /**
         * Method to print an expression in prefix format
         * */
        public void print()
        {
            Console.Write("* ");
            exp_izquierda.print();
            Console.Write(" ");
            exp_derecha.print();
        }//print
    }//MultPrefix
}//Expresiones

