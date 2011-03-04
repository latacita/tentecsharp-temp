using System;
using expresiones;


namespace expresiones
{
    
    public class MultEval : BinaryOperatorEval, Mult
    {
        protected static ExpressionEval exp_izquierda;
        protected static ExpressionEval exp_derecha;
        /**
         * Constructor
         * */
        public MultEval(ExpressionEval izq, ExpressionEval derch)
        {
            exp_izquierda = izq;
            exp_derecha = derch;
        }
        /**
        * Método que retorna el resultado de evaluar la expresion
        * */
        int ExpressionEval.eval()
        {
            return exp_izquierda.eval() * exp_derecha.eval();
        }
    }
}