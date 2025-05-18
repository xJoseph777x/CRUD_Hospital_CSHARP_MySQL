using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD_Proyecto
{
    internal class Conexion
    {
        protected MySqlConnection connection;

        private string connectionString = "server=localhost;user=root;password=password;database=mydb;";

        public Conexion()
        {
            connection = new MySqlConnection(connectionString);
        }

        protected void AbrirConexion()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }

        protected void CerrarConexion()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Close();
        }
    }
}
