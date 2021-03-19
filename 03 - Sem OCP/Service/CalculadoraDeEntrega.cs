using System.Collections.Generic;
using Sem_OCP.Models;

namespace Sem_OCP.Service
{
    public class CalculadoraDeEntrega
    {
        public void CalcularEntre(IList<Produto> produtos)
        {
            foreach(Produto produto in produtos){
                if(produto is Bolo){
                    ((Bolo)produto).CalcularEntregaDoBolo();
                }
                else if(produto is Empadao){
                    ((Empadao)produto).CalcularEntregaDoEmpadao();
                }
            }
        } 
    }
}