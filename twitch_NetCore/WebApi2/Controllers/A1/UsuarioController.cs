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
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> _usuarioDB;

        public UsuarioController()
        {
            if (_usuarioDB == null)
                _usuarioDB = new List<Usuario>();
        }

        [HttpGet]
        public ActionResult GetUsuarios()
        {
            return Ok(_usuarioDB);
        }

        [HttpPost]
        public ActionResult PostUsuario([FromBody] Usuario usuario)
        {
            _usuarioDB.Add(usuario);
            return Ok();
        }
            
        [HttpPut]

        public ActionResult PutUsuario([FromBody] Usuario usuario)
        {
            var usuariolocalizado = _usuarioDB.Find(a => a.Nome == usuario.Nome);
            if(usuariolocalizado != null)
            {
                usuariolocalizado.Nome = usuario.Nome;
                usuariolocalizado.Sobrenome = usuario.Sobrenome;
                usuariolocalizado.Idade = usuario.Idade;
                usuariolocalizado.Endereco = usuario.Endereco;
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
        
        [HttpDelete]
        public ActionResult DeleteUsuario([FromBody] string nome)
        {
            var usuariolocalizado = _usuarioDB.Find(a => a.Nome.Equals(nome));

            if (usuariolocalizado != null)
            {
                _usuarioDB.Remove(usuariolocalizado);
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
