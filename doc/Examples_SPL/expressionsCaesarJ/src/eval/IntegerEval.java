cclass eval.Eval;

public cclass Integer extends Expression {
	protected int constante;
	public IntegerEval(int constan){
		this.constante=constan;
	}
	public int eval(){
		return constante;
	}
}
