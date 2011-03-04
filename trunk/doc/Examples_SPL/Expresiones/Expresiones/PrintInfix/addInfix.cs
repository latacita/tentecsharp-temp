using System;
using Expresiones;


namespace Expresiones
{
    
    public class AddInfix : BinaryOperatorInfix, IAddInfix, Add
    {
        ExpressionInfix exp_izquierda;
        ExpressionInfix exp_derecha;
        /**
         * Constructor
         * */
        public AddInfix(ExpressionInfix izq, ExpressionInfix derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }
        /**
         * Método que imprime en formato infijo
         * */
        public void printInfix()
        {
            Console.Write("(");
            exp_izquierda.printInfix();
            Console.Write("+");
            exp_derecha.printInfix();
            Console.Write(")");
        }        

        public void print() {
            this.printInfix();
        }  // print 

    }
}