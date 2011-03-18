using System;
using Expresiones;

namespace ProductB_ShortCircuitPostFix
{
    /**
     * Class for a new Add configuration: AddPostFix+ShortEval
     * */
    public class AddPostFixEval : BinaryOperator, IAddShortEval, IAddPostfix,IExpressionShortCircuitPostFix
    {
        public AddPostFixEval(IExpressionShortCircuitPostFix op1, IExpressionShortCircuitPostFix op2) {
            this.mixinBinaryOperatorPosfix = new AddPostfix(op1,op2);
            this.mixinBinaryOperatorShortEval = new AddShortEval(op1, op2);
        } //Constructor AddPostFixEval        
    }//AddPostFixEval
}//ProductB_ShortCircuitPostFix
