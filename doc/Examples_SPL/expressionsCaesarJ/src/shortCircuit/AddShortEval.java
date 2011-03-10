cclass shortCircuit.ShortCircuit;

public cclass Add BinaryOperator {
	protected ExpressionShortEval op1;
	protected ExpressionShortEval op2;
	
	public Add(ExpressionShortEval op1, ExpressionShortEval op2){
		this.op1=op1;
		this.op2=op2;
	}
	
	public int eval(){
		return this.op1.eval()+this.op2.eval();
	}
	

}
