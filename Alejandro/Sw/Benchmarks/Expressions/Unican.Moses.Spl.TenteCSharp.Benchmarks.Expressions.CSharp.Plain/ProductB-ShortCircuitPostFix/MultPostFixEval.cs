using System;
using Expresiones;

namespace ProductB_ShortCircuitPostFix
{
    /**
     * Class for a new Mult configuration: MultPostFix+ShortEval
     * */
    public class MultPostFixEval : BinaryOperator, IMultShortEval, IMultPostfix,IExpressionShortCircuitPostFix
    {
        public MultPostFixEval(IExpressionShortCircuitPostFix op1, IExpressionShortCircuitPostFix op2)
        {
            this.mixinBinaryOperatorPosfix = new MultPostfix(op1, op2);
            this.mixinBinaryOperatorShortEval = new MultShortEval(op1, op2);
        } //Constructor AddPostFixEval        
    }//MultPostFixEval
}//ProductB_ShortCircuitPostFix
