using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define IntegerShortEval
     **/
    public class IntegerShortEval : IntegerEval, IBinaryOperatorEval
    {
        //int constante;
        /**
         * Constructor
         * */
        public IntegerShortEval (int constante)
            : base(constante)
        {
            //constan = constante;
            
        }
        /**
       * Método que retorna el valor del entero
       * */
        public override int eval()
        {
            return constante;
        }
    }
}