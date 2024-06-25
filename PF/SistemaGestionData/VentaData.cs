using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class VentaData
    {
        private string connectionString;

        public VentaData()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        }

        public Venta GetSale(int saleId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM Venta WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", saleId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string comments = reader.GetString(1);
                    int idUser = Convert.ToInt32(reader[2]);

                    Venta sale = new Venta(id, comments, idUser);

                    return sale;
                }
                throw new Exception("Id no fue encontrado");
            }
        }

        public static List<Venta> ListSale()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

            List<Venta> listSale = new List<Venta>();
            string query = "SELECT * FROM Venta";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Venta sale = new Venta();
                            sale.Id = Convert.ToInt32(dataReader["Id"]);
                            sale.Comments = dataReader["Comentarios"].ToString();
                            sale.IdUser = Convert.ToInt32(dataReader["IdUsuario"]);


                            listSale.Add(sale);

                        }
                    }
                }
            }
            return listSale;
        }

        public bool CreateSale(Venta sale)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO Venta(Comentarios, IdUsuario) values(@comments, @idUser)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("comments", sale.Comments);
                command.Parameters.AddWithValue("idUser", sale.IdUser);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }

        public bool UpdateSale(int idSale, Venta sale)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE Venta SET Comentarios = @comments, IdUsuario = @idUser WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("comments", sale.Comments);
                command.Parameters.AddWithValue("idUser", sale.IdUser);
                command.Parameters.AddWithValue("id", idSale);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteSale(int saleId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Venta WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", saleId);

                return command.ExecuteNonQuery() > 0;
            }

        }

        public bool SaleExists(int saleId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT COUNT(0) FROM Venta WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", saleId);
                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }
    }
}
