using System;
using Expresiones;


namespace Expresiones
{
    public class IntegerShortEval : IntegerEval, IBinaryOperatorEval, IIntegerShortEval
    {
        /**
         * Constructor
         * */
        public IntegerShortEval (int constante)
            : base(constante)
        {
                        
        }//Constructor

        /**
         * Method to return the constant
         **/
        public override int eval()
        {
            return constante;
        }//eval
    }//IntegerShortEval
}//Expresiones