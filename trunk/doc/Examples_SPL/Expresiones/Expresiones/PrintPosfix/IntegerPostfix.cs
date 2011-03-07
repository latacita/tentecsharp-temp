using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define IntegerPostfix
     **/
    public class IntegerPostfix : IBinaryOperatorPostfix, IInteger, IIntegerPostfix
    {
        int constante;
        /**
         * Constructor
         * */
        public IntegerPostfix(int constante)
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