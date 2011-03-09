using System;
using Expresiones;


namespace Expresiones
{
   
    public class AddPostfix : IBinaryOperatorPostfix, IAdd, IAddPostfix
    {
        IExpressionPostfix exp_izquierda;
        IExpressionPostfix exp_derecha;
        /**
         * Constructor
         * */
        public AddPostfix(IExpressionPostfix izq, IExpressionPostfix derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }//Constructor
        /**
         * Method to print an expression in postfix format
         * */
        public void print()
        {
            exp_izquierda.print();
            Console.Write(" ");
            exp_derecha.print();
            Console.Write(" ");
            Console.Write("+ ");
            
        }//print
    }//AddPostfix
}//Expresiones