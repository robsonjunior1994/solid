using System.Collections.Generic;
using Sem_OCP.Models;

namespace Sem_OCP.Service
{
    public class CalculadoraDeEntrega
    {
        public void CalcularEntre(IList<Produto> produtos)
        {
            foreach(Produto produto in produtos){
                produto.CalcularTaxaDeEntrega();
            }
        } 
    }
}