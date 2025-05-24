using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Proyecto
{
    internal class Dgv_Citas : Conexion
    {
        public DataTable ObtenerCitasPorNombrePaciente(string nombre)
        {
            DataTable tabla = new DataTable();

            try
            {
                AbrirConexion();

                string query = @"SELECT c.idCitas, c.fechaCita, c.horaCita, c.Motivo, c.Diagnostico, 
                                    c.Tratamiento, c.Observaciones, c.Paciente_idPaciente, c.Medico_idMedico
                             FROM citas c
                             INNER JOIN paciente p ON c.Paciente_idPaciente = p.idPaciente
                             WHERE p.NomPaciente LIKE @nombre";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return tabla;
        }

        public void ActualizarCita(int idCita, string diagnostico, string tratamiento, string observaciones)
        {
            try
            {
                AbrirConexion();

                string query = @"UPDATE citas 
                             SET Diagnostico = @diagnostico, 
                                 Tratamiento = @tratamiento, 
                                 Observaciones = @observaciones 
                             WHERE idCitas = @idCita";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@diagnostico", diagnostico);
                    cmd.Parameters.AddWithValue("@tratamiento", tratamiento);
                    cmd.Parameters.AddWithValue("@observaciones", observaciones);
                    cmd.Parameters.AddWithValue("@idCita", idCita);
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
