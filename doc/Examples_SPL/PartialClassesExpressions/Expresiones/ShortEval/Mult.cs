using System;
using Expresiones;


namespace Expresiones
{
    
    public partial class Mult: IBinaryOperator
    {
        
        /**
         * Method to evaluate an expression in a short way.
         * */
        public int eval()
        {
            if (exp_izquierda.eval() == 0)
            {
                return 0;

            }else{
                return exp_izquierda.eval() * exp_derecha.eval();
            }//if
        }//eval
    }//Mult
}//Expresiones