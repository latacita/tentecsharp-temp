using System;
using expresiones;


namespace expresiones
{
    /**
     * Clase que implementa las expresiones anidadas
     * */
    public class ExpresionLarga : Expressions
    {
        Expressions expression1;
        Expressions expression2;
        String operacion;
        private int resultado;
        /**
         * Constructor
         * */
        public ExpresionLarga(Expressions exp1, Expressions exp2, String oper)
        {
            expression1 = exp1;
            expression2 = exp2;
            operacion = oper;


        }
        /**
       * Método que muestra por consola la expresión
       * */
        void Expressions.print()
        {
            Console.Write("(");
            expression1.print();
            Console.Write(operacion);
            expression2.print();
            Console.Write(")");
        }
        /**
         * Método que evalua la expresión
         * */
        int Expressions.eval()
        {
            switch (operacion)
            {
                case "+":
                    resultado = expression1.eval() + expression2.eval();
                    return resultado;
                case "*":
                    resultado = expression1.eval() * expression2.eval();
                    return resultado;
                default:
                    Console.Write("Operador no válido");
                    return -1;
            }
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

