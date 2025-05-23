using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_Proyecto
{
    internal class M_Recepcionista : Conexion
    {
        public string Guardar_cita(P_Cita oCita)
        {
            string respuesta = "";

            try
            {
                AbrirConexion();

                DateTime fechaHoraCita = oCita.FechaCita.Date.Add(TimeSpan.Parse(oCita.HoraCita));
                if (fechaHoraCita < DateTime.Now)
                    return "No se pueden agendar citas en el pasado.";

                TimeSpan hora = TimeSpan.Parse(oCita.HoraCita);
                TimeSpan horaMenos30 = hora.Subtract(TimeSpan.FromMinutes(30));
                TimeSpan horaMas30 = hora.Add(TimeSpan.FromMinutes(30));

                string sqlVerificar = @"SELECT COUNT(*) FROM citas 
                                        WHERE fechaCita = @fecha 
                                        AND horaCita BETWEEN @horaInicio AND @horaFin 
                                        AND Medico_idMedico = @idMedico";

                using (var cmdVerificar = new MySqlCommand(sqlVerificar, connection))
                {
                    cmdVerificar.Parameters.AddWithValue("@fecha", oCita.FechaCita.ToString("yyyy-MM-dd"));
                    cmdVerificar.Parameters.AddWithValue("@horaInicio", horaMenos30);
                    cmdVerificar.Parameters.AddWithValue("@horaFin", horaMas30);
                    cmdVerificar.Parameters.AddWithValue("@idMedico", oCita.Medico_idMedico);

                    int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                    if (count > 0)
                        return "Ya existe una cita para ese médico dentro de los 30 minutos.";
                }

                string sqlInsert = @"INSERT INTO citas 
                    (fechaCita, horaCita, Motivo, Diagnostico, Tratamiento, Observaciones, Paciente_idPaciente, Medico_idMedico)
                    VALUES (@fecha, @hora, @motivo, '', '', '', @idPaciente, @idMedico)";

                using (var cmdInsert = new MySqlCommand(sqlInsert, connection))
                {
                    cmdInsert.Parameters.AddWithValue("@fecha", oCita.FechaCita.ToString("yyyy-MM-dd"));
                    cmdInsert.Parameters.AddWithValue("@hora", oCita.HoraCita);
                    cmdInsert.Parameters.AddWithValue("@motivo", oCita.Motivo);
                    cmdInsert.Parameters.AddWithValue("@idPaciente", oCita.Paciente_idPaciente);
                    cmdInsert.Parameters.AddWithValue("@idMedico", oCita.Medico_idMedico);

                    int rows = cmdInsert.ExecuteNonQuery();
                    respuesta = rows > 0 ? "OK" : "No se pudo guardar la cita.";
                }
            }
            catch (Exception ex)
            {
                respuesta = "Error: " + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }

            return respuesta;
            
        }

        public int ObtenerIdPaciente(string nombrePaciente)
        {
            int id = -1;
            string sql = "SELECT idPaciente FROM paciente WHERE LOWER(TRIM(NomPaciente)) = LOWER(TRIM(@nombre))";

            using (MySqlConnection con = ConexionRecepcionista.getInstancia().CrearConexion())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nombre", nombrePaciente);
                con.Open();
                var result = cmd.ExecuteScalar();
                if (result != null) id = Convert.ToInt32(result);
            }

            return id;
        }

        public int ObtenerIdMedico(string nombreMedico)
        {
            int id = -1;
            string sql = "SELECT idMedico FROM medico WHERE LOWER(TRIM(NomMedico)) = LOWER(TRIM(@nombre))";

            using (MySqlConnection con = ConexionRecepcionista.getInstancia().CrearConexion())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nombre", nombreMedico);
                con.Open();
                var result = cmd.ExecuteScalar();
                if (result != null) id = Convert.ToInt32(result);
            }

            return id;
        }



        public DataTable Listado_citas(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = ConexionRecepcionista.getInstancia().CrearConexion();

                string sql_tarea = "SELECT c.idCitas, c.fechaCita, c.horaCita, c.Motivo, " +
                                   "p.NomPaciente, m.NomMedico " +
                                   "FROM citas c " +
                                   "INNER JOIN paciente p ON c.Paciente_idPaciente = p.idPaciente " +
                                   "INNER JOIN medico m ON c.Medico_idMedico = m.idMedico " +
                                   "WHERE p.NomPaciente LIKE '%" + cTexto + "%' " +
                                   "ORDER BY c.fechaCita, c.horaCita";

                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Eliminar_cita(int idCita)
        {
            string Rpta = "";
            string SqlTarea = "";

            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = ConexionRecepcionista.getInstancia().CrearConexion();

                SqlTarea = "DELETE FROM citas WHERE idCitas = " + idCita;

                MySqlCommand Comando = new MySqlCommand(SqlTarea, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar la cita";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Actualizar_cita(P_Cita oCita)
        {
            string Rpta = "";
            string SqlTarea = "";
            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = ConexionRecepcionista.getInstancia().CrearConexion();

                DateTime fechaHoraCita = oCita.FechaCita.Date.Add(TimeSpan.Parse(oCita.HoraCita));
                DateTime fechaHoraActual = DateTime.Now;

                if (fechaHoraCita < fechaHoraActual)
                {
                    return "No se pueden agendar citas en el pasado.";
                }

                TimeSpan horaCita = TimeSpan.Parse(oCita.HoraCita);
                TimeSpan horaMenos30 = horaCita.Subtract(TimeSpan.FromMinutes(30));
                TimeSpan horaMas30 = horaCita.Add(TimeSpan.FromMinutes(30));

                string SqlVerificar = "SELECT COUNT(*) FROM citas " +
                                      "WHERE fechaCita = '" + oCita.FechaCita.ToString("yyyy-MM-dd") + "' " +
                                      "AND horaCita BETWEEN '" + horaMenos30.ToString(@"hh\:mm\:ss") + "' AND '" + horaMas30.ToString(@"hh\:mm\:ss") + "' " +
                                      "AND Medico_idMedico = " + oCita.Medico_idMedico + " " +
                                      "AND idCitas <> " + oCita.IdCitas;

                MySqlCommand ComandoVerificar = new MySqlCommand(SqlVerificar, SqlCon);
                SqlCon.Open();

                int existe = Convert.ToInt32(ComandoVerificar.ExecuteScalar());

                if (existe > 0)
                {
                    Rpta = "Ya existe una cita para ese médico dentro de los 30 minutos de diferencia.";
                }
                else
                {
                    SqlTarea = "UPDATE citas SET fechaCita = '" + oCita.FechaCita.ToString("yyyy-MM-dd") + "', " +
                               "horaCita = '" + oCita.HoraCita + "', " +
                               "Motivo = '" + oCita.Motivo + "', " +
                               "Paciente_idPaciente = " + oCita.Paciente_idPaciente + ", " +
                               "Medico_idMedico = " + oCita.Medico_idMedico + " " +
                               "WHERE idCitas = " + oCita.IdCitas;

                    MySqlCommand ComandoActualizar = new MySqlCommand(SqlTarea, SqlCon);
                    Rpta = ComandoActualizar.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo actualizar la cita";
                }
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return Rpta;
        }


    }
}
