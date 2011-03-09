using System;
using Expresiones;


namespace Expresiones
{
    public class IntegerInfix : IBinaryOperatorInfix, IInteger,IIntegerInfix
    {
        int constante;
        /**
         * Constructor
         * */
        public IntegerInfix(int constante)
        {
            this.constante = constante;
            
        }//Constructor
        /**
         * Method to print a constant
         * */
        void IExpressionInfix.print()
        {
            Console.Write(constante);
        }//IExpressionInfix.print
    }//IntegerInfix
}//Expresiones