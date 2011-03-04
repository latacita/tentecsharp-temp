using System;
using expresiones;


namespace expresiones
{
    /**
     * Clase que define IntegerEval
     **/
    public class IntegerEval : BinaryOperatorEval, Integer
    {
        protected static int constante;
        /**
         * Constructor
         * */
        public IntegerEval(int constan)
        {
            constante = constan;
            
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