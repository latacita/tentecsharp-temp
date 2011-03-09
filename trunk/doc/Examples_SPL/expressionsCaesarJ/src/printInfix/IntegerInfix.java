cclass printInfix.PrintInfix;

public cclass IntegerInfix extends ExpressionInfix & Integer {
	protected int constante;
	public IntegerInfix(int constante){
		this.constante=constante;
	}
	public void print(){
		System.out.print(constante);
	}

}
