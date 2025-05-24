using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD_Proyecto
{
    internal class ConexionRecepcionista
    {
        private string Base;
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Clave;
        private static ConexionRecepcionista Con = null;

        private ConexionRecepcionista()
        {
            this.Base = "mydb";
            this.Servidor = "localhost";
            this.Puerto = "3306";
            this.Usuario = "equipo";
            this.Clave = "hola123";

            Console.WriteLine("Usuario actual de conexión: " + this.Usuario);
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString = "datasource=" + this.Servidor +
                                                        "; port=" + this.Puerto +
                                                        ";username=" + this.Usuario +
                                                        ";password=" + this.Clave +
                                                        ";Database=" + this.Base;

            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static ConexionRecepcionista getInstancia()
        {
            if (Con == null)
            {
                Con = new ConexionRecepcionista();
            }
            return Con;
        }

    }
}