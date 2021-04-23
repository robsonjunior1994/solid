using Sem_SRP;
using Sem_SRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        readonly ProdutoContext _produtoContexto;

        public ProdutoRepository(ProdutoContext produtoContext)
        {
            _produtoContexto = produtoContext;
        }

        public void Salvar(Produto p)
        {
            _produtoContexto.Produtos.Add(p);
            _produtoContexto.SaveChanges();
        }
    }
}
