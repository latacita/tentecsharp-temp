using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Expresiones;

namespace ProductB_ShortCircuitPostFix
{
    class ShortCircuitPostfix:IMultPosfix,IAddPosfix, IIntegerPosfix, IIntegerShortEval,IAddShorEval,IMultShortEval
    {
        protected AddPosfix addPosfix_mixin;
        protected AddShortEval addShortEval_mixin;
        protected MultPosfix multPosfix_mixin;
        protected MultShortEval multShortEval_mixin;
        protected IntegerPosfix integerPosfix_mixin;
        protected IntegerShortEval integerShortEval_mixin;
        private Boolean isAdd = false;
        private Boolean isMult = false;
        private Boolean isInteger = false;
        /**
         * Constructor para Add
         **/
        public ShortCircuitPostfix( IExpressionAdd op1, IExpressionAdd op2)
        {
            this.addPosfix_mixin = new AddPosfix(op1, op2);
            this.addShortEval_mixin = new AddShortEval(op1, op2);
            isAdd = true;
        }
        /**
         * Constructor para Mult
         * */
        public ShortCircuitPostfix(IExpressionMult op1, IExpressionMult op2)
        {
            this.multPosfix_mixin = new MultPosfix(op1, op2);
            this.multShortEval_mixin = new MultShortEval(op1, op2);
            isMult = true;
        }
        /**
         * Constructor para un entero
         * */
        public ShortCircuitPostfix(int constan)
        {
            this.integerPosfix_mixin= new IntegerPosfix(constan);
            this.integerShortEval_mixin = new IntegerShortEval(constan);
            isInteger = true;
        }

        public void print()
        {
            if (isAdd == true)
            {
                this.addPosfix_mixin.print();
            }
            else if (isMult == true)
            {
                this.multPosfix_mixin.print();
            }
            else if (isInteger == true)
            {
                this.integerPosfix_mixin.print();
            }

        }//print

        public int eval()
        {
            if (isAdd == true)
            {
                return this.addShortEval_mixin.eval();
            }
            else if (isMult == true)
            {
                return this.multShortEval_mixin.eval();
            }
            else
            {
                return this.integerShortEval_mixin.eval();
            }            
        }//eval
    }//ShortCircuitPosfix
}//ProductB_ShortCircuitPostFix
