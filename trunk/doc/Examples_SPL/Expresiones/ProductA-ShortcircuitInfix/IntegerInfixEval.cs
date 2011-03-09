using System;
using Expresiones;

namespace ProductA_ShortcircuitInfix
{
    /**
     * Class for a new Integer configuration: IntegerInfix+ShortEval
     * */
    public class IntegerInfixEval :IIntegerShortEval, IIntegerInfix, IExpressionInfixEval
    {
        protected IIntegerInfix mixinIntegerInfix;
        protected IIntegerShortEval mixinIntegerShortEval;

        public IntegerInfixEval(int constant)
        {
            this.mixinIntegerInfix = new IntegerInfix(constant);
            this.mixinIntegerShortEval = new IntegerShortEval(constant);
        } //Constructor IntegerInfixEval  

        public void print()
        {
            this.mixinIntegerInfix.print();
        }//print

        public int eval()
        {
            return this.mixinIntegerShortEval.eval();
        }//eval
    }//IntegerInfixEval
}//ProductA_ShortcircuitInfix
