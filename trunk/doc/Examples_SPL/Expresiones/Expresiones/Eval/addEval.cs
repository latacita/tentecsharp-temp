using System;
using Expresiones;


namespace Expresiones
{
    public class AddEval : IBinaryOperatorEval, IAdd, IAddEval
    {
        protected IExpressionEval exp_izquierda;
        protected IExpressionEval exp_derecha;
        /**
         * Constructor
         * */
        public AddEval(IExpressionEval izq, IExpressionEval derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }//AddEval
        /**
         * Method to evaluate an expression
         * */
        public virtual int eval()
        {
            return exp_izquierda.eval() + exp_derecha.eval();
        }//eval
    }//AddEval
}//Expresiones