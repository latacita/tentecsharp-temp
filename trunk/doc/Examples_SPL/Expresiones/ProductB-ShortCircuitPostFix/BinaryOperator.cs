using System;
using Expresiones;

namespace ProductB_ShortCircuitPostFix
{
    public abstract class BinaryOperator : IBinaryOperatorShortEval, IBinaryOperatorPosfix
    {
        protected BinaryOperatorShortEval mixinBinaryOperatorShortEval = null;
        protected BinaryOperatorPosfix mixinBinaryOperatorPosfix = null;

        public int eval () {
            return this.mixinBinaryOperatorShortEval.eval();
        } // eval

        public void print () {
            this.mixinBinaryOperatorPosfix.print();
        } // eval

        /*
        private abstract void dummy() { 
        } */

    } // BinaryOperator
}
