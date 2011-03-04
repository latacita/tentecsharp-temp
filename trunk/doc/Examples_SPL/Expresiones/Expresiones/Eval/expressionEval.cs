using System;
using expresiones;


namespace expresiones
{
    /**
     * Interfaz ExpressionInfix
     * */
    public interface ExpressionEval : Expressions
    {
        int eval();
    }
}