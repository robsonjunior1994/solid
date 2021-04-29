using Moq;
using Sem_OCP.Models;
using Sem_OCP.Service;
using solid.Interface;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestandoOCP
{
    public class TesteOCP
    {
        [Trait("CalculadoraDeEntrega", "CalcularEntrega")]
        [Fact(DisplayName = "DeveriaCalcularTaxaDeEntrega")]
        public void DeveriaCalcularTaxaDeEntrega()
        {
            //Arrange
            var calculadoraDeEntrega = new CalculadoraDeEntregaService();
           
            var bolo1 = new Bolo() { Id = 1, Valor = 140 };
            var bolo2 = new Bolo() { Id = 2, Valor = 70 };

            var valorDeRetornoDoBolo1 = 42;

            var empadao1 = new Empadao() { Id = 1, Valor = 12 };
            var empadao2 = new Empadao() { Id = 2, Valor = 6 };
            
            List<Produto> produtos = new List<Produto>();
            produtos.Add(bolo1);
            produtos.Add(bolo2);
            produtos.Add(empadao1);
            produtos.Add(empadao2);

            //Act
            calculadoraDeEntrega.CalcularEntrega(produtos);

            //Assert
            Assert.Equal(bolo1.TaxaDeEntrega, valorDeRetornoDoBolo1);
        }

        [Trait("CalculadoraDeEntrega", "CalcularEntrega")]
        [Fact(DisplayName = "MOckDeveriaCalcularTaxaDeEntrega")]
        public void MockDeveriaCalcularTaxaDeEntrega()
        {
            //Arrange
            var calculadoraDeEntrega = new Mock<ICalculadoraDeEntregaService>();

            var bolo1 = new Bolo() { Id = 1, Valor = 140 };
            var bolo2 = new Bolo() { Id = 2, Valor = 70 };

            var valorDeRetornoDoBolo1 = 42;

            var empadao1 = new Empadao() { Id = 1, Valor = 12 };
            var empadao2 = new Empadao() { Id = 2, Valor = 6 };

            List<Produto> produtos = new List<Produto>();
            produtos.Add(bolo1);
            produtos.Add(bolo2);
            produtos.Add(empadao1);
            produtos.Add(empadao2);

            //Act
            calculadoraDeEntrega.Object.CalcularEntrega(produtos);

            //Assert
            Assert.Equal(bolo1.TaxaDeEntrega, valorDeRetornoDoBolo1);
        }
    }
}
