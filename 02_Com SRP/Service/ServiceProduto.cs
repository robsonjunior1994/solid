using Sem_SRP.Models;
using solid.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.Service
{
    public class ServiceProduto
    {
        public bool CadastrarProduto(Produto p)
        {
            Produto produto = new Produto()
            {
                Nome = p.Nome,
                Valor = p.Valor
            };

            if (produto.EhValido())
            {
                ProdutoRepository _produtoRepository = new ProdutoRepository();
                _produtoRepository.Salvar(produto);
                return true;
            }

            return false;
        }
    }
}
