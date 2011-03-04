using System;
using Expresiones;


namespace Expresiones
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
        public int eval()
        {
            return constante;
        }
    }
}