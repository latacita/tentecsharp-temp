using System;
using expresiones;


namespace expresiones
{
    
    public class AddInfix : BinaryOperatorInfix, Add
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
        void ExpressionInfix.printInfix()
        {
            Console.Write("(");
            exp_izquierda.printInfix();
            Console.Write("+");
            exp_derecha.printInfix();
            Console.Write(")");
        }
    }
}