using Sem_SRP.Models;
using solid.Repository;

namespace solid.Service
{
    public class ServiceProduto : IServiceProduto
    {
        readonly IProdutoRepository _produtoRepository;
        public ServiceProduto(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public bool CadastrarProduto(Produto p)
        {
            Produto produto = new Produto()
            {
                Nome = p.Nome,
                Valor = p.Valor
            };

            if (produto.EhValido())
            {
                _produtoRepository.Salvar(produto);
                return true;
            }

            return false;
        }
    }
}
