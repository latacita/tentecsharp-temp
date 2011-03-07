using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define AddPostfix
     * */
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
        }
        /**
         * Método que imprime en formato posfijo
         * */
        public void print()
        {
            exp_izquierda.print();
            Console.Write(" ");
            exp_derecha.print();
            Console.Write(" ");
            Console.Write("+ ");
            
        }
    }
}