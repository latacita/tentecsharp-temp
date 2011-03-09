﻿using System;
using Expresiones;


namespace Expresiones
{
    
    public class AddInfix : IBinaryOperatorInfix, IAddInfix, IAdd
    {
        IExpressionInfix exp_izquierda;
        IExpressionInfix exp_derecha;
        /**
         * Constructor
         * */
        public AddInfix(IExpressionInfix izq, IExpressionInfix derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }//Constructor
        /**
         * Method to print in infix
         * */
        public void print()
        {
            Console.Write("(");
            exp_izquierda.print();
            Console.Write("+");
            exp_derecha.print();
            Console.Write(")");
        }//print        
       
    }//AddInfix
}//Expresiones