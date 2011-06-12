﻿using System;
using Expresiones;


namespace ProductA_ShortcircuitInfix
{
    /**
     * Class for a new Add configuration: AddInfix+ShortEval
     * */
    public class AddInfixEval : BinaryOperator, IAddShortEval, IAddInfix,IExpressionInfixEval
    {
        public AddInfixEval(IExpressionInfixEval op1, IExpressionInfixEval op2)
        {
            this.mixinBinaryOperatorInfix = new AddInfix(op1, op2);
            this.mixinBinaryOperatorShortEval = new AddShortEval(op1, op2);
        } //Constructor AddPostFixEval        
    }//AddInfixEval
} //ProductA_ShortcircuitInfix