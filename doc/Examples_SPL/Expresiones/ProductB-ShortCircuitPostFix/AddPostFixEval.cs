using System;
using Expresiones;

namespace ProductB_ShortCircuitPostFix
{
    public class AddPostFixEval : BinaryOperator, IAddShortEval, IAddPosfix
    {
        public AddPostFixEval(IExpressionShortCircuitPostFix op1, IExpressionShortCircuitPostFix op2) {
            this.mixinBinaryOperatorPosfix = new AddPosfix(op1,op2);
            this.mixinBinaryOperatorShortEval = new AddShortEval(op1, op2);
        } //Constructor AddPostFixEval        
    }
}
