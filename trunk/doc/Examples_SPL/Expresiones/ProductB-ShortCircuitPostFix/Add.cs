using System;
using Expresiones;

namespace ProductB_ShortCircuitPostFix
{
    public class Add : BinaryOperator, IAddShortEval, IAddPosfix
    {
        public Add(IExpressionShortCircuitPostFix op1, IExpressionShortCircuitPostFix op2) {
            this.mixinBinaryOperatorPosfix = new AddPosfix(op1,op2);
            this.mixinBinaryOperatorShortEval = new AddShortEval(op1, op2);
        } // add
        
    }
}
