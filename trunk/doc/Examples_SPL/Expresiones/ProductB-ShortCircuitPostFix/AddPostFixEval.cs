using System;
using Expresiones;

namespace ProductB_ShortCircuitPostFix
{
    public class AddPostFixEval : BinaryOperator, IAddShortEval, IAddPostfix,IExpressionShortCircuitPostFix
    {
        public AddPostFixEval(IExpressionShortCircuitPostFix op1, IExpressionShortCircuitPostFix op2) {
            this.mixinBinaryOperatorPosfix = new AddPostfix(op1,op2);
            this.mixinBinaryOperatorShortEval = new AddShortEval(op1, op2);
        } //Constructor AddPostFixEval        
    }
}
