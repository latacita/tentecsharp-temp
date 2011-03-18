using System;
using expresiones;


namespace expresiones
{
    /**
     * Clase que define una constante
     * */
    public class Constante : Expressions
    {
        int constant;
        private int resultado;
        /**
         * Constructor
         * */
        public Constante(int cons)
        {
            constant = cons;
        }
        /**
        * Método que evalua la constante
        * */
        int Expressions.eval()
        {
            resultado = constant;
            return resultado;
        }
        /**
         * Método que muestra por consola la constante
         * */
        void Expressions.print()
        {
            Console.Write(constant);
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