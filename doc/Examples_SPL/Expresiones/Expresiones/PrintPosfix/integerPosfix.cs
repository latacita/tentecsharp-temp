using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define IntegerPosfix
     **/
    public class IntegerPosfix : IBinaryOperatorPosfix, IInteger
    {
        int constante;
        /**
         * Constructor
         * */
        public IntegerPosfix(int constante)
        {
            this.constante = constante;
            
        }
        /**
         * Método que imprime en formato infijo
         * */
        public void print()
        {
            Console.Write(constante);
        }
    }
}