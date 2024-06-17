using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUser")]
        public IEnumerable<Usuario> usuario()
        {
            return UsuarioBussiness.ListUser().ToArray();
        }

        [HttpPut("{id}", Name = "UpdateUser")]
        public void Put(int id, [FromBody] Usuario usuario)
        {
            UsuarioBussiness.UpdateUser(id, usuario);
        }
    }
}