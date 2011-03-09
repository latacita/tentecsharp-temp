cclass printInfix.PrintInfix;

public cclass MultInfix extends BinaryOperatorInfix & Mult{
	protected ExpressionInfix op1;
	protected ExpressionInfix op2;
	public MultInfix(ExpressionInfix op1,ExpressionInfix op2){
		this.op1=op1;
		this.op2=op2;
	}
	public void print(){
		System.out.print("("+op1+"*"+op2+")");
	}

}