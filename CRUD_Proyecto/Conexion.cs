using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD_Proyecto
{

    /// <summary>
    /// 
    /// </summary>
    internal class Conexion
    {
        protected MySqlConnection connection;
        //caDena conexion
        private string connectionString = "server=localhost;user=equipo;password=hola123;database=mydb;";

        public Conexion()
        {
            connection = new MySqlConnection(connectionString);
        }
        /// <summary>
        /// 
        /// </summary>
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
