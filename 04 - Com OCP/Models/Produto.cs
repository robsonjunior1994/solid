namespace Sem_OCP.Models
{
    public abstract class Produto
    {
        public int Id {get; set;}
        public double Valor { get; set; }
        public double TaxaDeEntrega { get; set; }

        public abstract void CalcularTaxaDeEntrega();
    }
}