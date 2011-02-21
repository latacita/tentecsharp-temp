using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace expresiones
{
    //Interfaz para las expresiones
    public interface Expressions
    {
        void print();
        int eval();
        void getResult();
    }
    //Clase que implementa la expresion suma
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
    //Clase que implementa la expresion suma
    public class Mult : Expressions
    {
        Expressions exp_izquierda;
        Expressions exp_derecha;
        private int resultado;
        /**
         * Constructor
         * */
        public Mult(Expressions izq, Expressions derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }
        /**
         * Método que evalua la expresión
         * */
        int Expressions.eval()
        {
            resultado = exp_izquierda.eval() * exp_derecha.eval();
            return resultado;
        }
        /**
         * Método que muestra por consola la expresión
         * */
        void Expressions.print()
        {
            Console.Write("(");
            exp_izquierda.print();
            Console.Write("*");
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
    //Clase que define una constante
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
    //Clase que implementa las expresiones anidadas
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
