using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SingleSignOn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        List<string> usuarios = new List<string> { "usuario1", "usuario2" };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(usuarios);
        }

        [HttpPut]
        public ActionResult Put([FromBody] string usuario)
        {
            var usuarioActual = usuarios.First();
            usuarioActual = usuario;
            return Ok(); 
        }

        [HttpPost]
        public ActionResult Post([FromBody] string usuario)
        {
            this.usuarios.Add(usuario);
            return StatusCode(201);
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] string usuario)
        {
            var user = usuarios.Find(x => x == usuario);
            usuarios.Remove(user);
            return StatusCode(201);
        }
    }
}
