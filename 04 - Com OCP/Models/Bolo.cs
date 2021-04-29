namespace Sem_OCP.Models
{
    public class Bolo : Produto
    {
        public override void CalcularTaxaDeEntrega()
        {
            this.TaxaDeEntrega = this.Valor * 0.3;
        }
    }
}