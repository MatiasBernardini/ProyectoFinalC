using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class ProductoData
    {
        private string connectionString;

        public ProductoData()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        }

        public Producto GetProduct(int productId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM Producto WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", productId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string description = reader.GetString(1);
                    double cost = Convert.ToDouble(reader[2]);
                    double salePrice = Convert.ToDouble(reader[3]);
                    int stock = Convert.ToInt32(reader[4]);
                    int idUser = Convert.ToInt32(reader[5]);

                    Producto producto = new Producto(id, description, cost, salePrice, stock, idUser);

                    return producto;
                }
                throw new Exception("Id no fue encontrado");
            }
        }

        public static List<Producto> ListProduct()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";


            List<Producto> listProduct = new List<Producto>();
            string query = "SELECT * FROM Producto";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Producto product = new Producto();
                            product.Id = Convert.ToInt32(dataReader["Id"]);
                            product.Description = dataReader["Descripciones"].ToString();
                            product.Cost = Convert.ToDouble(dataReader["Costo"]);
                            product.SalePrice = Convert.ToDouble(dataReader["PrecioVenta"]);
                            product.Stock = Convert.ToInt32(dataReader["Stock"]);
                            product.IdUser = Convert.ToInt32(dataReader["IdUsuario"]);

                            listProduct.Add(product);

                        }
                    }
                }
            }
            return listProduct;
        }

        public bool CreateProduct(Producto product)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO Producto(Descripciones, Costo, PrecioVenta, Stock, IdUsuario) values(@description, @cost,@salePrice,@stock,@idUser)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("description", product.Description);
                command.Parameters.AddWithValue("cost", product.Cost);
                command.Parameters.AddWithValue("salePrice", product.SalePrice);
                command.Parameters.AddWithValue("stock", product.Stock);
                command.Parameters.AddWithValue("idUser", product.IdUser);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }

        public bool UpdateProduct(int idProduct, Producto product)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE Producto SET Descripciones = @description, Costo = @cost, PrecioVenta= @salePrice, Stock = @stock, IdUsuario = @idUser WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("description", product.Description);
                command.Parameters.AddWithValue("cost", product.Cost);
                command.Parameters.AddWithValue("salePrice", product.SalePrice);
                command.Parameters.AddWithValue("stock", product.Stock);
                command.Parameters.AddWithValue("idUser", product.IdUser);
                command.Parameters.AddWithValue("id", idProduct);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteProduct(int productId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", productId);

                return command.ExecuteNonQuery() > 0;
            }

        }

        public bool ProductExists(int productId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT COUNT(0) FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", productId);
                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }
    }
}
