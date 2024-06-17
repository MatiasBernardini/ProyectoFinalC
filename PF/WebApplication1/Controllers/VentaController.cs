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
            Venta venta = VentaBussiness.GetSale(id);

            return Ok(venta);
        }
    }
}
