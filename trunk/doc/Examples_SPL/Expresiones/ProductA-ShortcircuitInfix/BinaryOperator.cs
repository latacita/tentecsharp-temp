using System;
using Expresiones;

namespace ProductA_ShortcircuitInfix
{
    public abstract class BinaryOperator : IBinaryOperatorShortEval, IBinaryOperatorInfix
    {
        protected IBinaryOperatorEval mixinBinaryOperatorShortEval = null;
        protected IBinaryOperatorInfix mixinBinaryOperatorInfix = null;

        public int eval()
        {
            return this.mixinBinaryOperatorShortEval.eval();
        } // eval

        public void print()
        {
            this.mixinBinaryOperatorInfix.print();
        } // print
    } // BinaryOperator
}//ProductA_ShortcircuitInfix