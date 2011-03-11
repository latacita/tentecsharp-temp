package productA_evalInfix;
import eval.Eval;
import printPostfix.PrintPostfix;
import printInfix.PrintInfix;
import printPrefix.PrintPrefix;

public cclass EvalInfix extends PrintPrefix & Eval{
	public void test_evalInfix(){
		//Print two integers
		Integer n1 = new Integer(3);
		Integer n2 = new Integer(4);
		System.out.println("Show some integers:");
		n1.print();
		System.out.print("\n");
		n2.print();
		//Test add operation
		Add add1=new Add(n1,n2);
		System.out.println("\nAdd expression:");
		add1.print();
		System.out.println("\nThe expression values is:"+add1.eval());
		//Two expressions
		System.out.println("Combined expressions:");
		Integer n3 = new Integer(10);
		Integer n4 = new Integer(7);
		Mult mult1= new Mult(n3,n4);
		Add twoExpression = new Add(mult1,add1);
		twoExpression.print();
		System.out.println("\nThe expression values is:"+twoExpression.eval());
	}
}