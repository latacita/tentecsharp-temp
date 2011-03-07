using System;
using Expresiones;

namespace ProductB_ShortCircuitPostFix
{
    public abstract class BinaryOperator : IBinaryOperatorShortEval, IBinaryOperatorPostfix
    {
        protected IBinaryOperatorShortEval mixinBinaryOperatorShortEval = null;
        protected IBinaryOperatorPostfix mixinBinaryOperatorPosfix = null;

        public int eval () {
            return this.mixinBinaryOperatorShortEval.eval();
        } // eval

        public void print () {
            this.mixinBinaryOperatorPosfix.print();
        } // print
      } // BinaryOperator
}//ProductB_ShortCircuitPostFix
