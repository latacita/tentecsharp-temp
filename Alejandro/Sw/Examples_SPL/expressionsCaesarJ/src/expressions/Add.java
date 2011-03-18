cclass expressions.Expressions;

public cclass Add extends BinaryOperator {
	
	protected Expression op1;
	protected Expression op2; 
	
	public Add(Expression op1, Expression op2){
		this.op1=op1;
		this.op2=op2;
	} // Add 

}