using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define MultInfix
     * */
    public class MultInfix : IBinaryOperatorInfix, IMult
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
        }
        /**
         * Método que imprime en formato infijo
         * */
        void IExpressionInfix.print()
        {
            Console.Write("(");
            exp_izquierda.print();
            Console.Write("*");
            exp_derecha.print();
            Console.Write(")");
        }
    }
}