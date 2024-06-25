using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet (Name = "ListSoldProduct")]
        public IEnumerable<ProductoVendido> soldProduct()
        {
            return ProductoVendidoBussiness.ListSoldProduct().ToArray();
        }


        [HttpGet ("{id}")]
        public IActionResult GetSoldProductById(int id)
        {
            try
            {
                ProductoVendido productoVendido = ProductoVendidoBussiness.GetSoldProduct(id);

                if (productoVendido == null)
                {
                    return NotFound();
                }

                return Ok(productoVendido);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpPost (Name = "CreateSoldProduct")]
        public IActionResult Post([FromBody] ProductoVendido productoVendido)
        {
            if (productoVendido == null)
            {
                return BadRequest("El producto vendido no puede ser nulo, debe completar lo solicitado.");
            }

            try
            {
                ProductoVendidoBussiness.SoldCreateProduct(productoVendido);

                return Ok("Producto vendido creado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpPut ("{id}", Name = "UpdateSoldProduct")]
        public IActionResult Put(int id, [FromBody] ProductoVendido productoVendido)
        {
            if (productoVendido == null)
            {
                return BadRequest("El producto vendido no puede ser nulo, debe completar lo solicitado.");
            }
            if (id <= 0)
            {
                return BadRequest("El id no puede ser nulo o negativo, debe completar lo solicitado.");
            }

            try
            {
                ProductoVendidoBussiness.UpdateSoldProduct(id, productoVendido);

                return Ok("Producto vendido actualizado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpDelete (Name = "DeleteSoldProduct")]
        public IActionResult Delete([FromBody] int id)
        {
            if (id <= 0)
            {
                return BadRequest("El id no puede negativo, debe completar lo solicitado.");
            }

            try
            {
                var idSoldProduct = ProductoVendidoBussiness.GetSoldProduct(id);

                if (idSoldProduct == null)
                {
                    return NotFound($"No existe ningun producto vendido con el id: {id}");
                }

                ProductoVendidoBussiness.DeleteSoldProduct(id);

                return Ok("Producto vendido eliminado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
