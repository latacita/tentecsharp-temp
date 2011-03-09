cclass shortCircuit.ShortCircuit;

public cclass IntegerShortEval extends IntegerEval & ExpressionShortEval {
	protected int constante;
	public IntegerShortEval(int constante){
		this.constante=constante;
	}
	public int eval(){
		return constante;
	}
}
