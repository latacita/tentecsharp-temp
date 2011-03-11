cclass eval.Eval;

public cclass Add {
	/**
	 * Method to evaluate an add expression
	 */
	public int eval(){
		return this.op1.eval()+this.op2.eval();
	} // eval
}// Add
