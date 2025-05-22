using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        public void InsertarPaciente(string nombre, string curp, DateTime nacimiento, string sexo, string telefono, string direccion)
        {
            try
            {
                AbrirConexion();
                string query = @"INSERT INTO paciente (NomPaciente, CURPPaciente, NacimientoPaciente, sexoPaciente, TelefonoPaciente, Direccion) 
                 VALUES (@nombre, @curp, @nacimiento, @sexo, @telefono, @direccion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@curp", curp);
                cmd.Parameters.AddWithValue("@nacimiento", nacimiento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                CerrarConexion();
            }
        }
        public void EliminarPaciente(int idPaciente)
        {
            try
            {
                AbrirConexion();
                string query = "DELETE FROM paciente WHERE idPaciente = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", idPaciente);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                CerrarConexion();
            }
        }
        public DataTable ObtenerPacientes()
        {
            DataTable tabla = new DataTable();

            try
            {
                AbrirConexion();

                string query = "SELECT idPaciente, NomPaciente, CURPPaciente, NacimientoPaciente, sexoPaciente, TelefonoPaciente, Direccion FROM paciente";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(tabla);
            }
            finally
            {
                CerrarConexion();
            }

            return tabla;
        }
        public void ActualizarPaciente(int id, string nombre, string curp, DateTime nacimiento, string sexo, string telefono, string direccion)
        {
            try
            {
                AbrirConexion();
                string query = @"UPDATE paciente SET 
                    NomPaciente = @nombre, 
                    CURPPaciente = @curp, 
                    NacimientoPaciente = @nacimiento,
                    sexoPaciente = @sexo, 
                    TelefonoPaciente = @telefono, 
                    Direccion = @direccion 
                 WHERE idPaciente = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@curp", curp);
                cmd.Parameters.AddWithValue("@nacimiento", nacimiento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
