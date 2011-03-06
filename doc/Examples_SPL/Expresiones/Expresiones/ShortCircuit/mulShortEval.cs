using System;
using Expresiones;


namespace Expresiones
{
    
    public class MultShortEval : MultEval,IBinaryOperatorShortEval,IMultShortEval
    {
        //IExpressionShortEval exp_izquierda;
        //IExpressionShortEval exp_derecha;
        /**
         * Constructor
         * */
        public MultShortEval(IExpressionShortEval exp_izquierda, IExpressionShortEval exp_derecha)
            : base(exp_izquierda, exp_derecha)
        {
            
        }
        /**
        * Método que retorna el resultado de evaluar la expresion
        * */
        public override int eval()
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