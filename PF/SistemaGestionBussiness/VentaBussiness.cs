using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public static List<Venta> ListSale()
        {
            return VentaData.ListSale();
        }

        public static Venta GetSale(int saleId)
        {
            VentaData ventaData = new VentaData();
            if (!ventaData.SaleExists(saleId))
            {
                throw new ArgumentException($"No se encontró la venta con Id: {saleId}");
            }

            return ventaData.GetSale(saleId);
        }

        public static bool CreateSale(Venta sale)
        {
            VentaData ventaData = new VentaData();

            return ventaData.CreateSale(sale);
        }

        public static bool UpdateSale(int saleId, Venta sale)
        {
            VentaData ventaData = new VentaData();
            if (!ventaData.SaleExists(saleId))
            {
                throw new ArgumentException($"No se encontró la venta con Id: {saleId}");
            }

            return ventaData.UpdateSale(saleId, sale);
        }

        public static bool DeleteSale(int saleId)
        {
            VentaData ventaData = new VentaData();
            if (!ventaData.SaleExists(saleId))
            {
                throw new ArgumentException($"No se encontró la venta con Id: {saleId}");
            }

            return ventaData.DeleteSale(saleId);
        }
    }
}
