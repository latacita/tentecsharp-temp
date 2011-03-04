using System;

namespace Expresiones
{
    /**
     * Interfaz ExpressionInfix
     * */
    public interface IExpressionEval : Expressions
    {
        int eval();
    }
}