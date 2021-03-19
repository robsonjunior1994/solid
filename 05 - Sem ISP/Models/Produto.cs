namespace Sem_OCP.Models
{
    public abstract class Produto
    {
        public int Id {get; set;}


        public abstract void CalcularTaxaDeEntrega();
    }
}