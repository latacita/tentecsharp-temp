cclass shortCircuit.ShortCircuit;

public cclass Mult {
	/**
	 * Method to evaluate a mult expression
	 */
	public int eval(){
		if (op1.eval() == 0){
            return 0;
        }else{
            return (this.op1.eval() * this.op2.eval());
        }//if
	}//eval

}//MultShortEval
