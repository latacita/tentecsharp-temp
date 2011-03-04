using System;
using expresiones;


namespace expresiones
{
    /**
     * Clase que define un entero
     * */
    public class AddPosfix : BinaryOperatorPosfix, Add
    {
        ExpressionPosfix exp_izquierda;
        ExpressionPosfix exp_derecha;
        /**
         * Constructor
         * */
        public AddPosfix(ExpressionPosfix izq, ExpressionPosfix derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }
        /**
         * Método que imprime en formato posfijo
         * */
        void ExpressionPosfix.printPosfix()
        {
            exp_izquierda.printPosfix();
            Console.Write(" ");
            exp_derecha.printPosfix();
            Console.Write(" ");
            Console.Write("+ ");
            
        }
    }
}