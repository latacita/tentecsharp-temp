using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define un entero
     * */
    public class AddEval : BinaryOperatorEval, Add, IAddEval
    {
        // NOTA(Pablo): Las variables no se declaran estáticas salvo que sea
        //              muy necesario, elimina los statics
        protected static IExpressionEval exp_izquierda;
        protected static IExpressionEval exp_derecha;
        /**
         * Constructor
         * */
        public AddEval(IExpressionEval izq, IExpressionEval derch)
        {
            exp_izquierda = izq;
            exp_derecha = derch;
        }
        /**
         * Método que retorna el resultado de evaluar la expresion
         * */
        public int eval()
        {
            return exp_izquierda.eval() + exp_derecha.eval();
        }
    }
}