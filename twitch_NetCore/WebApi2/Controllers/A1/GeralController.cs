using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Model;

namespace WebApi2.Controllers.A1
{
    [Route("api/A1/[controller]")]
    [ApiController]
    public class GeralController : ControllerBase
    {
        [HttpGet]
        [Route("helloworld")]
        public ActionResult GetHelloWorld()
        {
            return Ok("Hello World");
        }

        [HttpGet]
        [Route("meunome/{nome}")]

        public ActionResult GetMeuNome(string nome)
        {
            return Ok("Meu nome é: "+nome);
        }

        [HttpGet]
        [Route ("usuario/{nome}/{sobrenome}/{idade}/{endereco}")]

        public ActionResult GetUsuario(string nome, string sobrenome, int idade, string endereco)
        {
            return Ok($"Nome:{nome} Sobrenome:{sobrenome} Idade:{idade} Endereço:{endereco}");
        }

        [HttpPost]
        [Route("usuarioobjeto")]

        public ActionResult GetUsuario([FromBody]Usuario usuario)
        {
            return Ok($"Nome:{usuario.Nome} Sobrenome:{usuario.Sobrenome} Idade:{usuario.Idade} Endereço:{usuario.Endereco}");
        }
    }
}
