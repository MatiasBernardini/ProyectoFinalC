//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        [HttpGet(Name = "ListProducts")]
        public IEnumerable<Producto> producto()
        {
            return ProductoBussiness.ListProduct().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                Producto producto = ProductoBussiness.GetProduct(id);

                if (producto == null)
                {
                    return NotFound();
                }

                return Ok(producto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }

        [HttpPost(Name = "CreateProduct")]
        public IActionResult Post([FromBody] Producto producto)
        {
            if (producto == null)
            {
                return BadRequest("El producto no puede ser nulo, debe completar lo solicitado.");
            }

            try
            {
                ProductoBussiness.CreateProduct(producto);

                return Ok("Producto creado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut ("{id}", Name = "UpdateProduct")]
        public IActionResult Put(int id, [FromBody] Producto producto)
        {
            if (producto == null)
            {
                return BadRequest("El producto no puede ser nulo, debe completar lo solicitado.");
            }
            if (id <= 0)
            {
                return BadRequest("El id no puede ser nulo o negativo, debe completar lo solicitado.");
            }

            try
            {
                ProductoBussiness.UpdateProduct(id, producto);

                return Ok("Producto actualizado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete (Name = "DeleteProduct")]
        public IActionResult Delete([FromBody] int id)
        {
            if (id <= 0)
            {
                return BadRequest("El id no puede negativo, debe completar lo solicitado.");
            }

            try
            {
                var idProduct = ProductoBussiness.GetProduct(id);
                if (idProduct == null)
                {
                    return NotFound($"No existe ningun producto con el id: {id}");
                }

                ProductoBussiness.DeleteProduct(id);

                return Ok("Producto eliminado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
