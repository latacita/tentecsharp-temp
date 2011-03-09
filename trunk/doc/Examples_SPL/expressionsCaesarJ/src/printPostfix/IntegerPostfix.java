cclass printPostfix.PrintPostfix;

public cclass IntegerPostfix extends ExpressionPostfix & Integer {
	protected int constante;
	public IntegerPostfix(int constante){
		this.constante=constante;
	}
	public void print(){
		System.out.println(constante);
	}

}
