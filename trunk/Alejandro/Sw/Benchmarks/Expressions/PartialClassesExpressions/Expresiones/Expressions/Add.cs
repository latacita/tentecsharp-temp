
namespace Expresiones
{
    public partial class Add : IBinaryOperator
    {
        IExpressions exp_izquierda;
        IExpressions exp_derecha;
        /**
         * Constructor
         * */
        public Add(IExpressions izq, IExpressions derch)
        {
            this.exp_izquierda = izq;
            this.exp_derecha = derch;
        }//Constructor
    }//Add
}//Expresiones

