using System;
using Expresiones;


namespace Expresiones
{
    public class IntegerPostfix : IBinaryOperatorPostfix, IInteger,IIntegerPostfix
    {
        int constante;
        /**
         * Constructor
         * */
        public IntegerPostfix(int constante)
        {
            this.constante = constante;
            
        }//Constructor
        /**
         * Method to print a constant
         * */
        void IExpressionPostfix.print()
        {
            Console.Write(constante);
        }//IExpressionPostfix.print
    }//IntegerPostfix
}//Expresiones