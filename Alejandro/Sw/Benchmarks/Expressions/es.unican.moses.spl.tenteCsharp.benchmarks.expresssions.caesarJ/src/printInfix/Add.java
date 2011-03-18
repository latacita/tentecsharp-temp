cclass printInfix.PrintInfix;

public cclass Add{
	/**
	 * Method to print an add expression in infix format
	 */
	public void print(){
		System.out.print("(");
		op1.print();
		System.out.print("+");
		op2.print();
		System.out.print(")");		
	}//print

}//Add
