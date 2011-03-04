using System;
using Expresiones;


namespace Expresiones
{
    
    public class MultPosfix : BinaryOperatorPosfix, Mult
    {
        ExpressionPosfix exp_izquierda;
        ExpressionPosfix exp_derecha;
        /**
         * Constructor
         * */
        public MultPosfix(ExpressionPosfix izq, ExpressionPosfix derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }
        /**
         * Método que imprime en formato infijo
         * */
        void ExpressionPosfix.printPosfix()
        {
            exp_izquierda.printPosfix();
            Console.Write(" ");
            exp_derecha.printPosfix();
            Console.Write(" ");
            Console.Write("* ");
         }
    }
}