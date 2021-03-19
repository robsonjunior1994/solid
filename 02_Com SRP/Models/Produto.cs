namespace Sem_SRP.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public double Valor {get; set;}

        public bool EhValido()
        {
            if (string.IsNullOrEmpty(this.Nome) || this.Valor < 0)
            {
                return false;
            }

            return true;
        }
    }
}