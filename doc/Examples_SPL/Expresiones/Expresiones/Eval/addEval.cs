using System;
using Expresiones;


namespace Expresiones
{
    /**
     * Clase que define un entero
     * */
    public class AddEval : IBinaryOperatorEval, IAdd, IAddEval
    {
        protected IExpressionEval exp_izquierda;
        protected IExpressionEval exp_derecha;
        /**
         * Constructor
         * */
        public AddEval(IExpressionEval izq, IExpressionEval derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }
        /**
         * Método que retorna el resultado de evaluar la expresion
         * */
        public virtual int eval()
        {
            return exp_izquierda.eval() + exp_derecha.eval();
        }
    }
}