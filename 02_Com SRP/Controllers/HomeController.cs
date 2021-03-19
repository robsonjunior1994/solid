using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sem_SRP.Models;
using Sem_SRP;
using solid.Service;

namespace solid.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Salvar(Produto produto)
        {
            ServiceProduto _serviceProduto = new ServiceProduto(); 

            if(_serviceProduto.CadastrarProduto(produto))
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
