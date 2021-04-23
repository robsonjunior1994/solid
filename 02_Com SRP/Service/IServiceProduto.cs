using Sem_SRP.Models;
using solid.RequestResponse;

namespace solid.Service
{
    public interface IServiceProduto
    {
        bool CadastrarProduto(RequestProduto p);
    }
}
