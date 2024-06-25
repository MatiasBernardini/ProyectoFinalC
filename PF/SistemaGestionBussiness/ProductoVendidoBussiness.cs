using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> ListSoldProduct()
        {
            return ProductoVendidoData.ListSoldProduct();
        }

        public static ProductoVendido GetSoldProduct(int soldProductId)
        {
            ProductoVendidoData productoVendidoData = new ProductoVendidoData();
            if(!productoVendidoData.SoldProductExists(soldProductId))
            {
                throw new ArgumentException($"No se encontró el producto vendido con Id: {soldProductId}");
            }

            return productoVendidoData.GetSoldProduct(soldProductId);
        }

        public static bool SoldCreateProduct(ProductoVendido soldProduct)
        {
            ProductoVendidoData productoVendidoData = new ProductoVendidoData();

            return productoVendidoData.CreateSoldProduct(soldProduct);
        }

        public static bool UpdateSoldProduct(int soldProductId, ProductoVendido soldProduct)
        {
            ProductoVendidoData productoVendidoData = new ProductoVendidoData();
            if (!productoVendidoData.SoldProductExists(soldProductId))
            {
                throw new ArgumentException($"No se encontró el producto vendido con Id: {soldProductId}");
            }

            return productoVendidoData.UpdateSoldProduct(soldProductId, soldProduct);
        }

        public static bool DeleteSoldProduct(int soldProductId)
        {
            ProductoVendidoData productoVendidoData = new ProductoVendidoData();
            if (!productoVendidoData.SoldProductExists(soldProductId))
            {
                throw new ArgumentException($"No se encontró el producto vendido con Id: {soldProductId}");
            }

            return productoVendidoData.DeleteSoldProduct(soldProductId);
        }
    }
}
