using Microsoft.AspNetCore.Http;
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

        [HttpPost(Name = "CreateProduct")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.CreateProduct(producto);
        }

        [HttpPut ("{id}", Name = "UpdateProduct")]
        public void Put(int id, [FromBody] Producto producto)
        {
            ProductoBussiness.UpdateProduct(id, producto);
        }

        [HttpDelete (Name = "DeleteProduct")]
        public void Delete([FromBody] int id)
        {
            ProductoBussiness.DeleteProduct(id);
        }
    }
}
