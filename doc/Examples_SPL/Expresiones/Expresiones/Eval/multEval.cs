using System;
using Expresiones;


namespace Expresiones
{
    
    public class MultEval : BinaryOperatorEval, Mult
    {
        protected static IExpressionEval exp_izquierda;
        protected static IExpressionEval exp_derecha;
        /**
         * Constructor
         * */
        public MultEval(IExpressionEval izq, IExpressionEval derch)
        {
            exp_izquierda = izq;
            exp_derecha = derch;
        }
        /**
        * Método que retorna el resultado de evaluar la expresion
        * */
        public int eval()
        {
            return exp_izquierda.eval() * exp_derecha.eval();
        }
    }
}