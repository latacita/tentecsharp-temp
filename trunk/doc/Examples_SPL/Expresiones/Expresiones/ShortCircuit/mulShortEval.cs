using System;
using Expresiones;

namespace Expresiones
{
    
    public class MultShortEval : MultEval,IBinaryOperatorShortEval,IMultShortEval
    {
        /**
         * Constructor
         * */
        public MultShortEval(IExpressionShortEval exp_izquierda, IExpressionShortEval exp_derecha)
            : base(exp_izquierda, exp_derecha)
        {
            
        }//Constructor

        /**
        * Method to evaluate an expression
        * */
        public override int eval()
        {
            if (exp_izquierda.eval() == 0)
            {
                return 0;
            }//if
            else
            {
                return (this.exp_izquierda.eval() * this.exp_derecha.eval());
            }//else
        }//eval
    }//MultShortEval
}//Expresiones