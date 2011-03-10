package eval;

cclass eval.Eval;

public cclass Add extends BinaryOperator {
	protected ExpressionEval op1;
	protected ExpressionEval op2;
	public AddEval(ExpressionEval op1, ExpressionEval op2){
		this.op1=op1;
		this.op2=op2;
	}
	public int eval(){
		return this.op1.eval()+this.op2.eval();
	}
}
