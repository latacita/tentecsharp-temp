using System;
using Expresiones;


namespace Expresiones
{
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
         * Method to print a constant
         * */
        public void print()
        {
            Console.Write(constante);
        }//print
    }//IntegerPostfix
}//Expresiones