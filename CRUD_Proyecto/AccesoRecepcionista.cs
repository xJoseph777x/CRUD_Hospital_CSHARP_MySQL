using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CRUD_Proyecto
{
    public partial class AccesoRecepcionista : Form
    {
        public AccesoRecepcionista()
        {
            InitializeComponent();
        }

        int idCitaSeleccionada = 0;
        int nEstadoGuardar = 0;

        #region "MÉTODOS"
        private void Formato_citas()
        {
            dgv_citas.Columns[0].Width = 20;
            dgv_citas.Columns[0].HeaderText = "ID";
            dgv_citas.Columns[1].Width = 70;
            dgv_citas.Columns[1].HeaderText = "Fecha";
            dgv_citas.Columns[2].Width = 50;
            dgv_citas.Columns[2].HeaderText = "Hora";
            dgv_citas.Columns[3].Width = 200;
            dgv_citas.Columns[3].HeaderText = "Motivo";
            dgv_citas.Columns[4].Width = 200;
            dgv_citas.Columns[4].HeaderText = "Paciente";
            dgv_citas.Columns[5].Width = 200;
            dgv_citas.Columns[5].HeaderText = "Médico";
        }
        private void FiltrarCitas()
        {
            DataTable dt = dgv_citas.DataSource as DataTable;
            if (dt == null) return;

            string filtro = txtBuscar.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filtro))
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            string criterio = cmbFiltro.SelectedItem?.ToString();
            string filtroExpresion = "";

            switch (criterio)
            {
                case "Fecha":
                    filtroExpresion = $"CONVERT(fechaCita, System.String) LIKE '%{filtro}%'";
                    break;
                case "Paciente":
                    filtroExpresion = $"NomPaciente LIKE '%{filtro}%'";
                    break;
                case "Medico":
                    filtroExpresion = $"NomMedico LIKE '%{filtro}%'";
                    break;
                default:
                    filtroExpresion = "";
                    break;
            }

            try
            {
                dt.DefaultView.RowFilter = filtroExpresion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void Listado_citas(string cTexto)
        {
            M_Recepcionista Datos = new M_Recepcionista(); // Asumo que tienes esta clase para acceder a datos de citas
            dgv_citas.DataSource = Datos.Listado_citas(cTexto);
            this.Formato_citas();
        }

        private void Selecciona_item_cita()
        {
            if (dgv_citas.CurrentRow == null ||
                string.IsNullOrEmpty(Convert.ToString(dgv_citas.CurrentRow.Cells["idCitas"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                int idCita = Convert.ToInt32(dgv_citas.CurrentRow.Cells["idCitas"].Value);

                DateTime fechaCita = Convert.ToDateTime(dgv_citas.CurrentRow.Cells["fechaCita"].Value);
                TimeSpan horaCita = (TimeSpan)dgv_citas.CurrentRow.Cells["horaCita"].Value;

                string motivo = Convert.ToString(dgv_citas.CurrentRow.Cells["Motivo"].Value);
                string nombrePaciente = Convert.ToString(dgv_citas.CurrentRow.Cells["NomPaciente"].Value);
                string nombreMedico = Convert.ToString(dgv_citas.CurrentRow.Cells["NomMedico"].Value);

                dtpCita.Value = fechaCita;
                dtpHora.Value = DateTime.Today.Add(horaCita);
                txtBoxMotivo.Text = motivo;

                txtPaciente.Text = nombrePaciente;

                // Buscar el índice del médico y seleccionarlo
                int indexMedico = cmbMedico.FindStringExact(nombreMedico);
                if (indexMedico >= 0)
                {
                    cmbMedico.SelectedIndex = indexMedico;
                }
                else
                {
                    cmbMedico.SelectedIndex = -1; // No encontrado, limpia selección
                }

                // Guarda el id si necesitas editar o eliminar
                this.idCitaSeleccionada = idCita;
            }
        }




        private void CargarMedicos()
        {
            try
            {
                using (MySqlConnection con = ConexionRecepcionista.getInstancia().CrearConexion())
                {
                    string sql = "SELECT idMedico, NomMedico FROM medico";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<int, string> medicos = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        medicos.Add(reader.GetInt32("idMedico"), reader.GetString("NomMedico"));
                    }

                    cmbMedico.DataSource = new BindingSource(medicos, null);
                    cmbMedico.DisplayMember = "Value";
                    cmbMedico.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar médicos: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            dtpCita.Value = DateTime.Today;
            dtpHora.Value = DateTime.Now;
            txtBoxMotivo.Clear();
            txtPaciente.Clear();
            cmbMedico.SelectedIndex = -1;
        }
        #endregion




        private void AccesoRecepcionista_Load(object sender, EventArgs e)
        {
            cmbFiltro.Items.Add("Fecha");
            cmbFiltro.Items.Add("Paciente");
            cmbFiltro.Items.Add("Medico");
            cmbFiltro.SelectedIndex = 0;
            CargarMedicos();
            Listado_citas("%");
            cmbMedico.SelectedIndex = -1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            // Habilita campos de entrada
            dtpCita.Enabled = true;
            dtpHora.Enabled = true;
            txtBoxMotivo.Enabled = true;
            txtPaciente.Enabled = true;
            cmbMedico.Enabled = true;

            // Limpia los campos
            dtpCita.Value = DateTime.Today;
            dtpHora.Value = DateTime.Now;
            txtBoxMotivo.Text = "";
            txtPaciente.Text = "";
            cmbMedico.Text = "";

            // Habilita botones
            Btn_guardar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_cancelar.Visible = true;
            Btn_guardar.Visible = true;
            txtPaciente.Focus();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (dgv_citas.CurrentRow == null ||
        string.IsNullOrEmpty(Convert.ToString(dgv_citas.CurrentRow.Cells["idCitas"].Value)))

            {
                MessageBox.Show("Selecciona primero una cita para editar.",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }

            nEstadoGuardar = 2; 

            dtpCita.Enabled = true;
            dtpHora.Enabled = true;
            txtBoxMotivo.Enabled = true;
            cmbMedico.Enabled = true;
            Btn_cancelar.Visible = true;
            Btn_guardar.Visible = true;
            txtPaciente.Focus();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv_citas.CurrentRow == null ||
        string.IsNullOrEmpty(Convert.ToString(dgv_citas.CurrentRow.Cells["idCitas"].Value)))
            {
                MessageBox.Show("Seleccione una cita para cancelar",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }

            int idCita = Convert.ToInt32(dgv_citas.CurrentRow.Cells["idCitas"].Value);

            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Está seguro de cancelar esta cita?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Opcion == DialogResult.Yes)
            {
                M_Recepcionista modelo = new M_Recepcionista();
                string Rpta = modelo.Eliminar_cita(idCita);

                if (Rpta.Equals("OK"))
                {
                    MessageBox.Show("Cita cancelada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listado_citas("");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
        

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpCita_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpHora_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_citas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                M_Recepcionista datos = new M_Recepcionista();
                P_Cita cita = new P_Cita();

                int idPaciente = datos.ObtenerIdPaciente(txtPaciente.Text.Trim());
                int idMedico = datos.ObtenerIdMedico(cmbMedico.Text.Trim());

                if (idPaciente == -1)
                {
                    MessageBox.Show("Paciente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (idMedico == -1)
                {
                    MessageBox.Show("Médico no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cita.FechaCita = dtpCita.Value.Date;
                cita.HoraCita = dtpHora.Value.ToString("HH:mm:ss");
                cita.Motivo = txtBoxMotivo.Text.Trim();
                cita.Paciente_idPaciente = idPaciente;
                cita.Medico_idMedico = idMedico;

                string resultado;

                if (nEstadoGuardar == 0) // NUEVA CITA
                {
                    resultado = datos.Guardar_cita(cita);
                }
                else if (nEstadoGuardar == 2) // ACTUALIZAR CITA
                {
                    cita.IdCitas = idCitaSeleccionada;
                    resultado = datos.Actualizar_cita(cita);
                }
                else
                {
                    MessageBox.Show("Estado de guardado inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (resultado == "OK")
                {
                    string mensaje = nEstadoGuardar == 0 ? "Cita guardada correctamente." : "Cita actualizada correctamente.";
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtPaciente.Clear();
                    txtBoxMotivo.Clear();
                    dtpCita.Value = DateTime.Now;
                    dtpHora.Value = DateTime.Now;
                    cmbMedico.SelectedIndex = -1;

                    txtPaciente.Enabled = false;
                    txtBoxMotivo.Enabled = false;
                    dtpCita.Enabled = false;
                    dtpHora.Enabled = false;
                    cmbMedico.Enabled = false;

                    idCitaSeleccionada = 0;
                    nEstadoGuardar = 0;

                    Btn_cancelar.Visible = false;
                    Btn_guardar.Visible = false;

                    Listado_citas("%");
                }
                else
                {
                    MessageBox.Show("Error: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            txtPaciente.Clear();
            txtBoxMotivo.Clear();
            dtpCita.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            cmbMedico.SelectedIndex = -1;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgv_citas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_item_cita();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Listado_citas("%" + txtBuscar.Text.Trim() + "%");
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }
    }
}
