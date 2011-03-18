using System;
using Expresiones;


namespace Expresiones
{
    
    public partial class Add: IBinaryOperator
    {
       
        /**
         * Method to print in postfix
         * */
        public void print()
        {
            exp_izquierda.print();
            Console.Write(" ");
            exp_derecha.print();
            Console.Write(" ");
            Console.Write("+");
        }//print        
       
    }//Add
}//Expresiones