using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define IntegerEval
     **/
    public class IntegerEval : IBinaryOperatorEval, IInteger
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
        public virtual int eval()
        {
            return constante;
        }
    }
}