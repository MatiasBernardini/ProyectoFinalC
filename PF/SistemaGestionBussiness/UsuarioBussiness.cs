using SistemaGestionEntities;
using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        public static List<Usuario> ListUser()
        {
            return UsuarioData.ListUser();
        }

        public static Usuario GetUser(int userId)
        {
            UsuarioData usuarioData = new UsuarioData();
            if (!usuarioData.UserExists(userId))
            {
                throw new ArgumentException($"No se encontró usuario con Id: {userId}");
            }

            return usuarioData.GetUser(userId);
        }

        public static string GetUserNameById(int id)
        {
            UsuarioData usuarioData = new UsuarioData();
            if (!usuarioData.UserExists(id))
            {
                throw new ArgumentException($"No se encontró usuario con Id: {id}");
            }

            return usuarioData.GetUserNameById(id);
        }

        public static bool CreateUser(Usuario user)
        {
            UsuarioData usuarioData = new UsuarioData();

            return usuarioData.CreateUser(user);
        }

        public static bool UpdateUser(int userId, Usuario user)
        {
            UsuarioData usuarioData = new UsuarioData();
            if (!usuarioData.UserExists(userId))
            {
                throw new ArgumentException($"No se encontró usuario con Id: {userId}");
            }

            return usuarioData.UpdateUser(userId, user);
        }

        public static bool DeleteUser(int userId)
        {
            UsuarioData usuarioData = new UsuarioData();
            if (!usuarioData.UserExists(userId))
            {
                throw new ArgumentException($"No se encontró usuario con Id: {userId}");
            }

            return usuarioData.DeleteUser(userId);
        }
    }
}
