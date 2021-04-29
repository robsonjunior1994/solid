using System.Collections.Generic;
using Sem_OCP.Models;
using solid.Interface;

namespace Sem_OCP.Service
{
    public class CalculadoraDeEntregaService : ICalculadoraDeEntregaService
    {
        public void CalcularEntrega(IList<Produto> produtos)
        {
            foreach(Produto produto in produtos){
                produto.CalcularTaxaDeEntrega();
            }
        } 
    }
}