using System;
using expresiones;


namespace expresiones
{
    /**
     * Clase que define un entero
     * */
    public class AddEval : BinaryOperatorEval, Add, IAddEval
    {
        protected static ExpressionEval exp_izquierda;
        protected static ExpressionEval exp_derecha;
        /**
         * Constructor
         * */
        public AddEval(ExpressionEval izq, ExpressionEval derch)
        {
            exp_izquierda = izq;
            exp_derecha = derch;
        }
        /**
         * Método que retorna el resultado de evaluar la expresion
         * */
        int ExpressionEval.eval()
        {
            return exp_izquierda.eval() + exp_derecha.eval();
        }
    }
}