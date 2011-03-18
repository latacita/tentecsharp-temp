using System;
using Expresiones;


namespace Expresiones
{
    
    public partial class Add: IBinaryOperator
    {
       
        /**
         * Method to print in infix
         * */
        public void print()
        {
            Console.Write("(");
            exp_izquierda.print();
            Console.Write("+");
            exp_derecha.print();
            Console.Write(")");
        }//print        
       
    }//AddInfix
}//Expresiones