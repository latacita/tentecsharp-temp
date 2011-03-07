using System;
using Expresiones;


namespace ProductA_ShortcircuitInfix
{
    public class MultInfixEval : BinaryOperator, IMultShortEval, IMultInfix, IExpressionInfixEval
    {
        public MultInfixEval(IExpressionInfixEval op1, IExpressionInfixEval op2)
        {
            this.mixinBinaryOperatorInfix = new MultInfix(op1, op2);
            this.mixinBinaryOperatorShortEval = new MultShortEval(op1, op2);
        } //Constructor AddPostFixEval        
    }
} //ProductA_ShortcircuitInfix