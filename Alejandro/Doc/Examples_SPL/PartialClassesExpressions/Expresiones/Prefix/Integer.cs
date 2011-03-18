using System;
using Expresiones;


namespace Expresiones
{
    public partial class Integer : IExpressions
    {
        
        /**
         * Method to print a constant
         * */
        public void print()
        {
            Console.Write(constante);
        }//print
        
    }//Integer
}//Expresiones