using System;
using Expresiones;


namespace Expresiones
{
    
    public class MultPosfix : IBinaryOperatorPosfix, IMult
    {
        IExpressionPosfix exp_izquierda;
        IExpressionPosfix exp_derecha;
        /**
         * Constructor
         * */
        public MultPosfix(IExpressionPosfix izq, IExpressionPosfix derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }
        /**
         * Método que imprime en formato infijo
         * */
        void IExpressionPosfix.print()
        {
            exp_izquierda.print();
            Console.Write(" ");
            exp_derecha.print();
            Console.Write(" ");
            Console.Write("* ");
         }
    }
}