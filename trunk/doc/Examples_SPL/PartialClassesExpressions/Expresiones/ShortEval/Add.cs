using System;
using Expresiones;


namespace Expresiones
{
    public partial class Add : IBinaryOperator
    {
        
        /**
         * Method to evaluate an expression
         * */
        public int eval()
        {
            return exp_izquierda.eval() + exp_derecha.eval();
        }//eval
    }//Add
}//Expresiones