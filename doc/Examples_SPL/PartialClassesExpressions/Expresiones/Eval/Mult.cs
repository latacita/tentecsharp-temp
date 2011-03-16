using System;
using Expresiones;


namespace Expresiones
{

    public partial class Mult : IBinaryOperator
    {

        /**
         * Method to evaluate an expression
         * */
        public int eval()
        {
            return exp_izquierda.eval() * exp_derecha.eval();
        }//eval

    }//Mult
}//Expresiones