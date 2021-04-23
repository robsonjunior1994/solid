using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sem_SRP.Models;
using Sem_SRP;

namespace solid.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Salvar(Produto produto)
        {   
            if(string.IsNullOrEmpty(produto.Nome) || produto.Valor < 0)
            {
                return BadRequest();
            }

            else 
            {
                ProdutoContext produtoContext = new ProdutoContext();
                produtoContext.Produtos.Add(produto);
                produtoContext.SaveChanges();
            }
            
            return Ok();
        }
    }
}
