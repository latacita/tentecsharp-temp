
namespace Expresiones
{
    public partial class Mult : IBinaryOperator
    {
        IExpressions exp_izquierda;
        IExpressions exp_derecha;
        /**
         * Constructor
         * */
        public Mult(IExpressions izq, IExpressions derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }
    }//Mult
}//Expresiones