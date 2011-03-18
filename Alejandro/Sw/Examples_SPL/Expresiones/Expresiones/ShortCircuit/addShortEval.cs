using System;
using Expresiones;


namespace Expresiones
{
    public class AddShortEval : AddEval,IBinaryOperatorShortEval,IAddShortEval
    {
        
        /**
         * Constructor
         * */
        public AddShortEval(IExpressionEval exp_izquierda, IExpressionEval exp_derecha)
            :base(exp_izquierda,exp_derecha)
        {
            
        }//Constructor
        /**
         * Method to evaluate an expression
         * */
        public override int eval()
        {
            return this.exp_izquierda.eval() + this.exp_derecha.eval();           
        }//eval
    }//AddShortEval
}//Expresiones