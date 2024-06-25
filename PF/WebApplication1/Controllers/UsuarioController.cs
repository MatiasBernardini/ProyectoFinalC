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
        [HttpGet(Name = "ListUser")]
        public IEnumerable<Usuario> usuario()
        {
            return UsuarioBussiness.ListUser().ToArray();
        }

        [HttpGet ("{id}")]
        public IActionResult GetUserId(int id)
        {
            try
            {
                Usuario usuario = UsuarioBussiness.GetUser(id);

                if (usuario == null)
                {
                    return NotFound();
                }

                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}/name", Name = "GetUserNameById")]
        public IActionResult GetUserNameById(int id)
        {
            try
            {
                string userName = UsuarioBussiness.GetUserNameById(id);

                if (userName == null)
                {
                    return NotFound();
                }

                string successfulMessage = $"nombre: {userName}";
                return Ok(successfulMessage);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost(Name = "CreateUser")]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest("El usuario no puede ser nulo, debe completar lo solicitado.");
            }

            try
            {
                UsuarioBussiness.CreateUser(usuario);

                return Ok("Usuario creado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpPut("{id}", Name = "UpdateUser")]
        public IActionResult Put(int id, [FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest("El usuario no puede ser nulo, debe completar lo solicitado.");
            } 
            if (id <= 0) {
                return BadRequest("El id no puede ser nulo o negativo, debe completar lo solicitado.");
            }

            try
            {
                UsuarioBussiness.UpdateUser(id, usuario);

                return Ok("Usuario actualizado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpDelete (Name = "DeleteUser")]
        public IActionResult Delete([FromBody] int id)
        {
            if (id <= 0)
            {
                return BadRequest("El id no puede negativo, debe completar lo solicitado.");
            }

            try
            {
                var idUser = UsuarioBussiness.GetUser(id);
                if (idUser == null)
                {
                    return NotFound($"No existe ningun usuario con el id: {id}");
                }

                UsuarioBussiness.DeleteUser(id);

                return Ok("Usuario eliminado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}