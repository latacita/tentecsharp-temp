using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define un entero
     * */
    public class MultInfix : BinaryOperatorInfix, Mult
    {
        ExpressionInfix exp_izquierda;
        ExpressionInfix exp_derecha;
        /**
         * Constructor
         * */
        public MultInfix(ExpressionInfix izq, ExpressionInfix derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }
        /**
         * Método que imprime en formato infijo
         * */
        void ExpressionInfix.printInfix()
        {
            Console.Write("(");
            exp_izquierda.printInfix();
            Console.Write("*");
            exp_derecha.printInfix();
            Console.Write(")");
        }
    }
}