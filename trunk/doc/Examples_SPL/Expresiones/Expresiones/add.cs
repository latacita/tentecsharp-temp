using System;
using expresiones;

namespace expresiones
{
    /**
     * Clase que implementa la expresion suma
     * */
    public class Add : Expressions
    {
        Expressions exp_izquierda;
        Expressions exp_derecha;
        private int resultado;
        /**
         * Constructor
         * */
        public Add(Expressions izq, Expressions derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }
        /**
         * Método que evalua la expresión
         * */
        int Expressions.eval()
        {
            resultado = exp_izquierda.eval() + exp_derecha.eval();
            return resultado;
        }
        /**
         * Método que muestra por consola la expresión
         * */
        void Expressions.print()
        {
            Console.Write("(");
            exp_izquierda.print();
            Console.Write("+");
            exp_derecha.print();
            Console.Write(")");
        }
        /**
         * Metodo que evalua y muestra por pantalla el resultado
         * */
        void Expressions.getResult()
        {
            Console.Write("={0}", resultado);
        }


    }
}
