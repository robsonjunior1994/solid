using Sem_OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.Interface
{
    public interface ICalculadoraDeEntregaService
    {
        void CalcularEntrega(IList<Produto> produtos);
    }
}
