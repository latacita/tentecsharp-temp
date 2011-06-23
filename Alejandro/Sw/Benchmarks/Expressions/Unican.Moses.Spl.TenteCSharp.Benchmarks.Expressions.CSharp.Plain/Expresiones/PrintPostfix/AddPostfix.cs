using System;
using Expresiones;


namespace Expresiones
{
    
    public class AddPostfix : IBinaryOperatorPostfix, IAddPostfix, IAdd
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
         * Method to print in Postfix
         * */
        public void print()
        {            
            exp_izquierda.print();
            Console.Write(" ");
            exp_derecha.print();
            Console.Write("+ ");
        }//print        
       
    }//AddPostfix
}//Expresiones