using System;
using expresiones;


namespace expresiones
{
    /**
     * Clase que define IntegerShortEval
     **/
    public class IntegerShortEval : IntegerEval, BinaryOperatorEval
    {
        //int constante;
        /**
         * Constructor
         * */
        public IntegerShortEval ()
            : base(constante)
        {
            //constan = constante;
            
        }
        /**
       * Método que retorna el valor del entero
       * */
        int ExpressionEval.eval()
        {
            return constante;
        }
    }
}