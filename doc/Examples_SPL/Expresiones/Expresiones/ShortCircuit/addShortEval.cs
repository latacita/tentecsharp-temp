using System;
using Expresiones;


namespace Expresiones
{

    public class AddShortEval : AddEval,BinaryOperatorShortEval
    {
        //ExpressionShortEval exp_izquierda;
        //ExpressionShortEval exp_derecha;
        /**
         * Constructor
         * */
        public AddShortEval()
            :base(exp_izquierda, exp_derecha)
        {
            
        }
        /**
         * Método que retorna el resultado de evaluar la expresion
         * */
        public int eval()
        {
            return exp_izquierda.eval() + exp_derecha.eval();
        }
    }
}