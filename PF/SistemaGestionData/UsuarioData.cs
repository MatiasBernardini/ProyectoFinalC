using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGestionData
{
    public class UsuarioData
    {
        private string connectionString;

        public UsuarioData()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        }

        public Usuario GetUser(int userId)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM Usuario WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", userId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string name = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string userName = reader.GetString(3);
                    string password = reader.GetString(4);
                    string email = reader.GetString(5);

                    Usuario usuario = new Usuario(id, name, lastName, userName, password, email);

                    return usuario;
                }
                throw new Exception("Id no fue encontrado");
            }


        }

        public static List<Usuario> ListUser()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

            List<Usuario> listUser = new List<Usuario>();
            string query = "SELECT * FROM Usuario";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.Id = Convert.ToInt32(dataReader["Id"]);
                            usuario.Name = dataReader["Nombre"].ToString();
                            usuario.LastName = dataReader["Apellido"].ToString();
                            usuario.UserName = dataReader["NombreUsuario"].ToString();
                            usuario.Password = dataReader["Contraseña"].ToString();
                            usuario.Email = dataReader["Mail"].ToString();

                            listUser.Add(usuario);

                        }
                    }
                }
            }
            return listUser;

        }

        public bool CreateUser(Usuario user)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO Usuario(nombre, apellido, nombreUsuario, contraseña,mail) values(@name, @lastName,@userName,@password,@email)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("name", user.Name);
                command.Parameters.AddWithValue("lastName", user.LastName);
                command.Parameters.AddWithValue("userName", user.UserName);
                command.Parameters.AddWithValue("password", user.Password);
                command.Parameters.AddWithValue("email", user.Email);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }

        public bool UpdateUser(int idUser, Usuario user)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE Usuario SET nombre = @nombre, apellido = @apellido, nombreUsuario= @nombreUsuario, contraseña = @password, mail = @email WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("nombre", user.Name);
                command.Parameters.AddWithValue("apellido", user.LastName);
                command.Parameters.AddWithValue("nombreUsuario", user.UserName);
                command.Parameters.AddWithValue("password", user.Password);
                command.Parameters.AddWithValue("email", user.Email);
                command.Parameters.AddWithValue("id", idUser);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Usuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", userId);

                return command.ExecuteNonQuery() > 0;
            }

        }
    }
}
