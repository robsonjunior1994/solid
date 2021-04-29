namespace Sem_OCP.Models
{
    public class Empadao : Produto
    {
        public override void CalcularTaxaDeEntrega()
        {
            this.TaxaDeEntrega = this.Valor * 0.1;
        }
    }
}