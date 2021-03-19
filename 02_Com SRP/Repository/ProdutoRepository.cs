using Sem_SRP;
using Sem_SRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.Repository
{
    public class ProdutoRepository
    {
        readonly ProdutoContext _contexto;

        public ProdutoRepository()
        {
            _contexto = new ProdutoContext();
        }

        public void Salvar(Produto p)
        {
            _contexto.Produtos.Add(p);
            _contexto.SaveChanges();
        }
    }
}
