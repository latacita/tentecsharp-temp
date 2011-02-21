
using System;
using expresiones;

public class Program
{

    public static void Main()
    {
        //Pruebo con una expresion sencilla: (3+2)
        Expressions constante1 = new Constante(3);
        Expressions constante2 = new Constante(2);
        Expressions suma1 = new Add(constante1, constante2);
        //Imprimimos la expresion
        suma1.print();
        //Evaluamos y mostramos su resultado 
        suma1.eval();
        suma1.getResult();
        Console.Write("\n");
        //Pruebo con dos expresiones ((3+2)+(6*5))
        Expressions constante3 = new Constante(6);
        Expressions constante4 = new Constante(5);
        Expressions mult1 = new Mult(constante3, constante4);
        Expressions larga1 = new ExpresionLarga(suma1, mult1, "+");
        larga1.print();
        larga1.eval();
        larga1.getResult();
        Console.Write("\n");
        //Testeo con tres expresiones ((3+2)+(6*5)*(10*2))
        Expressions constante5 = new Constante(10);
        Expressions constante6 = new Constante(2);
        Expressions mult2 = new Mult(constante5, constante6);
        Expressions larga2 = new ExpresionLarga(larga1, mult2, "*");
        larga2.print();
        larga2.eval();
        larga2.getResult();
        Console.Read();
    }
}

