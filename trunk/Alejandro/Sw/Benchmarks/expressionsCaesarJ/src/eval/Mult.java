cclass eval.Eval;

public cclass Mult{
	/**
	 * Method to evaluate a mult expression
	 */
	public int eval(){
		return this.op1.eval()*this.op2.eval();
	} //eval
}// Mult
