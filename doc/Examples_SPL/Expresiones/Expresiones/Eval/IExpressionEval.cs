﻿using System;

namespace Expresiones
{
    /**
     * Interfaz IExpressionInfix
     * */
    public interface IExpressionEval : IExpressions
    {
        int eval();
    }
}