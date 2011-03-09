cclass printInfix.PrintInfix;

public cclass AddInfix extends BinaryOperatorInfix & Add{
	protected ExpressionInfix op1;
	protected ExpressionInfix op2;
	public AddInfix(ExpressionInfix op1,ExpressionInfix op2){
		this.op1=op1;
		this.op2=op2;
	}
	public void print(){
		System.out.print("("+op1+"+"+op2+")");
	}

}
