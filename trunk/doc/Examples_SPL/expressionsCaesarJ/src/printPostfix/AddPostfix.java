cclass printPostfix.PrintPostfix;

public cclass AddPostfix extends BinaryOperatorPostfix & Add{
	protected ExpressionPostfix op1;
	protected ExpressionPostfix op2;
	public AddPostfix(ExpressionPostfix op1,ExpressionPostfix op2){
		this.op1=op1;
		this.op2=op2;
	}
	public void print(){
		System.out.print(op1+" "+op2+"+");
	}

}

