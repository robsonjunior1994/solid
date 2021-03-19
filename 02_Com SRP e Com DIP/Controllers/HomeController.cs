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
        readonly IServiceProduto _serviceProduto;
        public HomeController (IServiceProduto serviceProduto)
        {
            _serviceProduto = serviceProduto;
        }

        [HttpPost]
        public IActionResult Salvar(Produto produto)
        {
            
            if(_serviceProduto.CadastrarProduto(produto))
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
