using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Proyecto
{
    internal class Dgv_Admin : Conexion
    {
        public DataTable ObtenerMedicos()
        {
            DataTable tabla = new DataTable();

            try
            {
                AbrirConexion();

                string query = "SELECT idMedico, NomMedico, CURPMedico, NacimientoMedico, sexo, Telefono, Direccion FROM medico";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(tabla);
            }
            finally
            {
                CerrarConexion();
            }

            return tabla;
        }


        public DataTable ObtenerUsuarios()
        {
            DataTable tabla = new DataTable();

            try
            {
                AbrirConexion();

                string query = "SELECT idUsuario, NomUsuario, CURPUsuario, tipo, clave, sexo FROM usuarios WHERE tipo = 3";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(tabla);
            }
            finally
            {
                CerrarConexion();
            }

            return tabla;
        }

        public bool RegistrarUsuario(
        string nombre, string curp, string clave, string repetirClave,
        int sexo, DateTime nacimiento, string telefono, string direccion,
        bool esMedico)
        {
            if (clave != repetirClave ||
                string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(curp) ||
                string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(repetirClave))
            {
                return false;
            }

            try
            {
                AbrirConexion();

                int tipo = esMedico ? 2 : 3;

                string queryUsuarios = "INSERT INTO usuarios (NomUsuario, CURPUsuario, tipo, clave, sexo) " +
                                       "VALUES (@nombre, @curp, @tipo, @clave, @sexo)";
                MySqlCommand cmdUsuarios = new MySqlCommand(queryUsuarios, connection);
                cmdUsuarios.Parameters.AddWithValue("@nombre", nombre);
                cmdUsuarios.Parameters.AddWithValue("@curp", curp);
                cmdUsuarios.Parameters.AddWithValue("@tipo", tipo);
                cmdUsuarios.Parameters.AddWithValue("@clave", clave);
                cmdUsuarios.Parameters.AddWithValue("@sexo", sexo);
                cmdUsuarios.ExecuteNonQuery();

                if (esMedico)
                {

                    long idUsuario = cmdUsuarios.LastInsertedId;

                    string queryMedico = "INSERT INTO medico (idMedico, NomMedico, CURPMedico, NacimientoMedico, sexo, Telefono, Direccion) " +
                                         "VALUES (@id, @nombre, @curp, @nacimiento, @sexoStr, @telefono, @direccion)";
                    MySqlCommand cmdMedico = new MySqlCommand(queryMedico, connection);
                    cmdMedico.Parameters.AddWithValue("@id", idUsuario);
                    cmdMedico.Parameters.AddWithValue("@nombre", nombre);
                    cmdMedico.Parameters.AddWithValue("@curp", curp);
                    cmdMedico.Parameters.AddWithValue("@nacimiento", nacimiento);
                    cmdMedico.Parameters.AddWithValue("@sexoStr", sexo == 1 ? "Masculino" : "Femenino");
                    cmdMedico.Parameters.AddWithValue("@telefono", telefono);
                    cmdMedico.Parameters.AddWithValue("@direccion", direccion);
                    cmdMedico.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                // Muestra o registra el error
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool ActualizarDatosYContrasenaMedico(int id, string nuevoNombreUsuario, string nuevoNombreMedico,
    string nuevaDireccion, string nuevoTelefono, string nuevaClave)
        {
            try
            {
                AbrirConexion();

                // Actualizar usuarios: nombre y clave
                string queryUsuarios = @"UPDATE usuarios 
                                 SET NomUsuario = @nombre, clave = @clave 
                                 WHERE idUsuario = @id";
                MySqlCommand cmdUsuarios = new MySqlCommand(queryUsuarios, connection);
                cmdUsuarios.Parameters.AddWithValue("@nombre", nuevoNombreUsuario);
                cmdUsuarios.Parameters.AddWithValue("@clave", nuevaClave);
                cmdUsuarios.Parameters.AddWithValue("@id", id);
                cmdUsuarios.ExecuteNonQuery();

                // Actualizar medico: nombre, direccion, telefono
                string queryMedico = @"UPDATE medico 
                               SET NomMedico = @nombre, Direccion = @direccion, Telefono = @telefono 
                               WHERE idMedico = @id";
                MySqlCommand cmdMedico = new MySqlCommand(queryMedico, connection);
                cmdMedico.Parameters.AddWithValue("@nombre", nuevoNombreMedico);
                cmdMedico.Parameters.AddWithValue("@direccion", nuevaDireccion);
                cmdMedico.Parameters.AddWithValue("@telefono", nuevoTelefono);
                cmdMedico.Parameters.AddWithValue("@id", id);

                int filasAfectadas = cmdMedico.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool ActualizarDatosYContrasenaRecepcionista(int id, string nuevoNombreUsuario, string nuevaClave)
        {
            try
            {
                AbrirConexion();

                string query = @"UPDATE usuarios 
                         SET NomUsuario = @nombre, clave = @clave 
                         WHERE idUsuario = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre", nuevoNombreUsuario);
                cmd.Parameters.AddWithValue("@clave", nuevaClave);
                cmd.Parameters.AddWithValue("@id", id);

                int filas = cmd.ExecuteNonQuery();

                return filas > 0;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void EliminarMedicoYUsuario(int id)
        {
            try
            {
                AbrirConexion();

                string eliminarMedico = "DELETE FROM medico WHERE idMedico = @id";
                string eliminarUsuario = "DELETE FROM usuarios WHERE idUsuario = @id";

                using (MySqlCommand cmd = new MySqlCommand(eliminarMedico, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                using (MySqlCommand cmd = new MySqlCommand(eliminarUsuario, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void EliminarSoloUsuario(int id)
        {
            try
            {
                AbrirConexion();

                string query = "DELETE FROM usuarios WHERE idUsuario = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CerrarConexion();
            }
        }


    }
}
