using System;
using Expresiones;


namespace Expresiones
{
    public class MultInfix : IBinaryOperatorInfix, IMult,IMultInfix
    {
        IExpressionInfix exp_izquierda;
        IExpressionInfix exp_derecha;
        /**
         * Constructor
         * */
        public MultInfix(IExpressionInfix izq, IExpressionInfix derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }//Constructor
        /**
         * Method to print an expression in infix format
         * */
        void IExpressionInfix.print()
        {
            Console.Write("(");
            exp_izquierda.print();
            Console.Write("*");
            exp_derecha.print();
            Console.Write(")");
        }//IExpressionInfix.print
    }//MultInfix
}//Expresiones