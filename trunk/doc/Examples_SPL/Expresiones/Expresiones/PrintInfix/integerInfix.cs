using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define IntegerInfix
     **/
    public class IntegerInfix : IBinaryOperatorInfix, IInteger
    {
        int constante;
        /**
         * Constructor
         * */
        public IntegerInfix(int constante)
        {
            this.constante = constante;
            
        }
        /**
         * Método que imprime en formato infijo
         * */
        void IExpressionInfix.print()
        {
            Console.Write(constante);
        }
    }
}