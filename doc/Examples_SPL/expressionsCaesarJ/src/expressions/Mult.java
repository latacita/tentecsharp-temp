cclass expressions.Expressions;

public cclass Mult extends BinaryOperator {
	protected Expression op1;
	protected Expression op2;
	public Mult(Expression op1, Expression op2){
		this.op1=op1;
		this.op2=op2;
	}
}
