using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Proyecto
{
    internal class Login : Conexion
    {
        

        public int ObtenerTipoUsuario(string usuario, string password)
        {
            int tipo = 0;

            try
            {
                AbrirConexion();

                string query = "SELECT tipo FROM usuarios WHERE NomUsuario = @usuario AND clave = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", password);

                var result = cmd.ExecuteScalar();
                if (result != null)
                    tipo = Convert.ToInt32(result);
            }
            finally
            {
                CerrarConexion();
            }

            return tipo;
        }
    }
}
