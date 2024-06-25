using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        public static List<Producto> ListProduct()
        {
            return ProductoData.ListProduct();
        }

        public static Producto GetProduct(int productId)
        {
            ProductoData productoData = new ProductoData();
            if (!productoData.ProductExists(productId))
            {
                throw new ArgumentException($"No se encontró producto con Id: {productId}");
            }

            return productoData.GetProduct(productId);
        }

        public static bool CreateProduct(Producto product)
        {
            ProductoData productoData = new ProductoData();

            return productoData.CreateProduct(product);
        }

        public static bool UpdateProduct(int productId, Producto product)
        {
            ProductoData productoData = new ProductoData();
            if (!productoData.ProductExists(productId))
            {
                throw new ArgumentException($"No se encontró producto con Id: {productId}. No se puede actualizar.");
            }

            return productoData.UpdateProduct(productId, product);
        }

        public static bool DeleteProduct(int productId)
        {
            ProductoData productoData = new ProductoData();
            if (!productoData.ProductExists(productId))
            {
                throw new ArgumentException($"No se encontró producto con Id: {productId}. No se puede eliminar.");
            }

            return productoData.DeleteProduct(productId);
        }
    }
}
