﻿using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define IntegerPosfix
     **/
    public class IntegerPosfix : BinaryOperatorPosfix, Integer
    {
        int constante;
        /**
         * Constructor
         * */
        public IntegerPosfix(int constante)
        {
            this.constante = constante;
            
        }
        /**
         * Método que imprime en formato infijo
         * */
        void ExpressionPosfix.printPosfix()
        {
            Console.Write(constante);
        }
    }
}