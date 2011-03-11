cclass printInfix.PrintInfix;

public cclass Mult {
	/**
	 * Method to print a mult expression in infix format
	 */
	public void print(){
		System.out.print("(");
		op1.print();
		System.out.print("*");
		op2.print();
		System.out.print(")");	
	}//print

}