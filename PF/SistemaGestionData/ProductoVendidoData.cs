using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class ProductoVendidoData
    {
        private string connectionString;

        public ProductoVendidoData()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        }

        public ProductoVendido GetSoldProduct(int soldProductId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM ProductoVendido WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", soldProductId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    int stock = Convert.ToInt32(reader[1]);
                    int idProduct = Convert.ToInt32(reader[2]);
                    int idSale = Convert.ToInt32(reader[3]);

                    ProductoVendido productoVendido = new ProductoVendido(id, stock, idProduct, idSale);

                    return productoVendido;
                }
                throw new Exception("Id no fue encontrado");
            }
        }

        public static List<ProductoVendido> ListSoldProduct()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

            List<ProductoVendido> listSoldProduct = new List<ProductoVendido>();
            string query = "SELECT * FROM ProductoVendido";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            ProductoVendido soldProduct = new ProductoVendido();
                            soldProduct.Id = Convert.ToInt32(dataReader["Id"]);
                            soldProduct.Stock = Convert.ToInt32(dataReader["Stock"]);
                            soldProduct.IdProduct = Convert.ToInt32(dataReader["IdProducto"]);
                            soldProduct.IdSale = Convert.ToInt32(dataReader["IdVenta"]);

                            listSoldProduct.Add(soldProduct);

                        }
                    }
                }
            }
            return listSoldProduct;
        }

        public bool CreateSoldProduct(ProductoVendido soldProduct)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO ProductoVendido(Stock, IdProducto, IdVenta) values(@stock, @idProduct, @idSale)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("stock", soldProduct.Stock);
                command.Parameters.AddWithValue("idProduct", soldProduct.IdProduct);
                command.Parameters.AddWithValue("idSale", soldProduct.IdSale);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }

        public bool UpdateSoldProduct(int idSoldProduct, ProductoVendido soldProduct)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE ProductoVendido SET Stock = @stock, IdProducto = @idProduct, IdVenta = @IdSale WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("stock", soldProduct.Stock);
                command.Parameters.AddWithValue("idProduct", soldProduct.IdProduct);
                command.Parameters.AddWithValue("IdSale", soldProduct.IdSale);
                command.Parameters.AddWithValue("id", idSoldProduct);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteSoldProduct(int soldProductId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ProductoVendido WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", soldProductId);

                return command.ExecuteNonQuery() > 0;
            }

        }
    }
}
