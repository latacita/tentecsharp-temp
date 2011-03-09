cclass shortCircuit.ShortCircuit;

public cclass MultShortEval extends MultEval & BinaryOperatorShortEval {
	protected ExpressionShortEval op1;
	protected ExpressionShortEval op2;
	
	public MultShortEval(ExpressionShortEval op1, ExpressionShortEval op2){
		this.op1=op1;
		this.op2=op2;
	}//Constructor
	
	public int eval(){
		if (op1.eval() == 0){
            return 0;
        }else{
            return (this.op1.eval() * this.op2.eval());
        }//if
	}//eval

}//MultShortEval
