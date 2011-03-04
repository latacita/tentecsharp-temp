using System;
using Expresiones;


namespace Expresiones
{
    
    public class MultShortEval : MultEval,BinaryOperatorShortEval
    {
        //ExpressionShortEval exp_izquierda;
        //ExpressionShortEval exp_derecha;
        /**
         * Constructor
         * */
        public MultShortEval() :base (exp_izquierda, exp_derecha)
        {
            
        }
        /**
        * Método que retorna el resultado de evaluar la expresion
        * */
        public int eval()
        {
            if (exp_izquierda.eval() == 0)
            {
                return 0;
            }
            else
            {
                return exp_izquierda.eval() * exp_derecha.eval();
            }
        }
    }
}