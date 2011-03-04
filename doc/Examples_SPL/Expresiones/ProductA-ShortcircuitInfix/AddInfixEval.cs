using System;
using Expresiones;

namespace ProductA_ShortcircuitInfix
{

    public class AddInfixEval: IAddInfix, IAddEval
    {
        protected AddInfix addInfix_mixin;
        protected AddEval addEval_mixin;

        public AddInfixEval(IExpressionInfixEval op1, IExpressionInfixEval op2) {
            this.addEval_mixin  = new AddEval(op1, op2);
            this.addInfix_mixin = new AddInfix(op1, op2);
        } // AddInfixEval

        // eval
        public int eval() {
            return this.addEval_mixin.eval();
        } // eval

        public void print() {
            this.addInfix_mixin.print();
        } // print
    } // addInfixEval

} //