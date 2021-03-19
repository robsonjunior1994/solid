using solid.Models;

namespace Sem_OCP.Models
{
    public class Bolo : Produto, ICalculadora
    {
        public void CalcularQuantidadeDeChocolate()
        {
            //code
        }

        public void CalcularQuantidadeDeFrango()
        {
            //code
        }

        public override void CalcularTaxaDeEntrega()
        {
            // code...
        }
    }
}