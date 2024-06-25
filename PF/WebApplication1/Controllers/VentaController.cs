using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "ListSale")]
        public IEnumerable<Venta> venta()
        {
            return VentaBussiness.ListSale().ToArray();
        }


        [HttpGet("{id}")]
        public IActionResult GetSaleById(int id)
        {
            try
            {
                Venta venta = VentaBussiness.GetSale(id);

                if (venta == null)
                {
                    return NotFound();
                }

                return Ok(venta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost (Name = "CreateSale")]
        public IActionResult Post([FromBody]  Venta venta)
        {
            if (venta == null)
            {
                return BadRequest("La venta no puede ser nulo, debe completar lo solicitado.");
            }

            try
            {
                VentaBussiness.CreateSale(venta);

                return Ok("Venta creada exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut ("{id}", Name = "UpdateSale")]
        public IActionResult Put(int id, [FromBody] Venta venta)
        {
            if (venta == null)
            {
                return BadRequest("La venta no puede ser nulo, debe completar lo solicitado.");
            }
            if (id <= 0)
            {
                return BadRequest("El id no puede ser nulo o negativo, debe completar lo solicitado.");
            }

            try
            {
                VentaBussiness.UpdateSale(id, venta);

                return Ok("Venta actualizada exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete (Name = "DeleteSale")]
        public IActionResult Delete([FromBody] int id)
        {
            if (id <= 0)
            {
                return BadRequest("El id no puede negativo, debe completar lo solicitado.");
            }

            try
            {
                var idSale = VentaBussiness.GetSale(id);
                if (idSale == null)
                {
                    return NotFound($"No existe ninguna venta con el id: {id}");
                }

                VentaBussiness.DeleteSale(id);
                return Ok("Venta eliminada exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}