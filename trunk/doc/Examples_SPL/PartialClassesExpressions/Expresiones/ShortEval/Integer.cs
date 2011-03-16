using System;
using Expresiones;


namespace Expresiones
{
    public partial class Integer : IExpressions
    {


        /**
         * Method to return the constant
         * */
        public int eval()
        {
            return constante;
        }//eval
    }//Integer
}//Expresiones