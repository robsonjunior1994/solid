using Moq;
using Sem_SRP.Models;
using solid.Repository;
using solid.RequestResponse;
using solid.Service;
using System;
using Xunit;

namespace ProjetoDeTesteXunit
{
    public class TestandoSRP
    {
        [Trait("HomeController", "Salvar")]
        [Fact(DisplayName = "DeveriaCadastrarUmNovoProduto")]
        public void DeveriaCadastrarUmNovoProduto()
        {
            //Arrange
            var ProdutoRepositoryMock = new Mock<IProdutoRepository>();
            ServiceProduto serviceProduto = new ServiceProduto(ProdutoRepositoryMock.Object);
            var rp = new RequestProduto() { Nome = "Bolo", Valor = 5 };
            Produto produto = new Produto() { Nome = rp.Nome, Valor = rp.Valor };
            ProdutoRepositoryMock.Setup(p => p.Salvar(produto));

            //Act
            var retorno = serviceProduto.CadastrarProduto(rp);

            //Assert
            Assert.True(retorno);
        }
    }
}
