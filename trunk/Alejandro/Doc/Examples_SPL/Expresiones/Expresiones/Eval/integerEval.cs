using System;
using Expresiones;


namespace Expresiones
{
    public class IntegerEval : IBinaryOperatorEval, IInteger
    {
        protected int constante;
        /**
         * Constructor
         * */
        public IntegerEval(int constan)
        {
            constante = constan;
            
        }//Constructor

        /**
         * Method to return the constant
         * */
        public virtual int eval()
        {
            return constante;
        }//eval
    }//IntegerEval
}//Expresiones