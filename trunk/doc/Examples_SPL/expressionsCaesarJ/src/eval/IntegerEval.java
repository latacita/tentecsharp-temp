cclass eval.Eval;

public cclass IntegerEval extends ExpressionEval & Integer {
	protected int constante;
	public IntegerEval(int constan){
		this.constante=constan;
	}
	public int eval(){
		return constante;
	}
}
