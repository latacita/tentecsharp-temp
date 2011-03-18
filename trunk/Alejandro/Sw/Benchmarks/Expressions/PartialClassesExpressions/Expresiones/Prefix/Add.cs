using System;
using Expresiones;


namespace Expresiones
{
    
    public partial class Add: IBinaryOperator
    {
       
        /**
         * Method to print in prefix
         * */
        public void print()
        {
            Console.Write("+");
            Console.Write(" ");
            exp_izquierda.print();
            Console.Write(" ");
            exp_derecha.print();
            
            
        }//print        
       
    }//Add
}//Expresiones