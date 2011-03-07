using System;
using Expresiones;

namespace ProductB_ShortCircuitPostFix
{
    public class IntegerPostFixEval :IIntegerShortEval, IIntegerPostfix, IExpressionShortCircuitPostFix
    {
        protected IIntegerPostfix mixinIntegerPosfix;
        protected IIntegerShortEval mixinIntegerShortEval;

        public IntegerPostFixEval(int constant)
        {
            this.mixinIntegerPosfix = new IntegerPostfix(constant);
            this.mixinIntegerShortEval = new IntegerShortEval(constant);
        } //Constructor IntegerPostFixEval  

        public void print()
        {
            this.mixinIntegerPosfix.print();
        }//print

        public int eval()
        {
            return this.mixinIntegerShortEval.eval();
        }//eval
    }
}
