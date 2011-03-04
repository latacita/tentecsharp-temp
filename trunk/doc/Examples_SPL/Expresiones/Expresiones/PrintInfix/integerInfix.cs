using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define IntegerInfix
     **/
    public class IntegerInfix : BinaryOperatorInfix, Integer
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
        void ExpressionInfix.printInfix()
        {
            Console.Write(constante);
        }
    }
}