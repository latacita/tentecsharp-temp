using System;
using Expresiones;


namespace Expresiones
{
    
    public class MultEval : IBinaryOperatorEval, IMult
    {
        protected IExpressionEval exp_izquierda;
        protected IExpressionEval exp_derecha;
        /**
         * Constructor
         * */
        public MultEval(IExpressionEval izq, IExpressionEval derch)
        {
            exp_izquierda = izq;
            exp_derecha = derch;
        }//Constructor
        /**
         * Method to evaluate an expression
         * */
        public virtual int eval()
        {
            return exp_izquierda.eval() * exp_derecha.eval();
        }//eval
    }//MultEval
}//Expresiones