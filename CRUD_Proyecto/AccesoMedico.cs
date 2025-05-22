using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_Proyecto
{
    public partial class AccesoMedico : Form
    {
        public AccesoMedico()
        {
            InitializeComponent();
        }

        private void AccesoMedico_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }
        private void LimpiarCampos()
        {
            TxtNombre.Clear();
            TxtCurp.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
            radioMasculino.Checked = false;
            radioFemenino.Checked = false;
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                string sexo = radioFemenino.Checked ? "Femenino" : "Masculino";

                Login login = new Login();
                login.InsertarPaciente(
                    TxtNombre.Text,
                    TxtCurp.Text,
                    dtpFechaNacimiento.Value,
                    sexo,
                    TxtTelefono.Text,
                    TxtDireccion.Text
                );

                MessageBox.Show("Paciente registrado correctamente.");

                // 👇 Esto refresca el DataGridView
                CargarPacientes();
                MessageBox.Show("Paciente registrado correctamente.");
                CargarPacientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar paciente: " + ex.Message);
            }
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona un paciente para actualizar.");
                    return;
                }

                int idPaciente = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["idPaciente"].Value);
                string sexo = radioFemenino.Checked ? "Femenino" : "Masculino";

                Login login = new Login();
                login.ActualizarPaciente(
                    idPaciente,
                    TxtNombre.Text,
                    TxtCurp.Text,
                    dtpFechaNacimiento.Value,
                    sexo,
                    TxtTelefono.Text,
                    TxtDireccion.Text
                );

                MessageBox.Show("Paciente actualizado correctamente.");
                CargarPacientes(); // Vuelve a cargar los datos en el grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar paciente: " + ex.Message);
            }
        }
        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPacientes.Rows[e.RowIndex];

                TxtNombre.Text = fila.Cells["NomPaciente"].Value.ToString();
                TxtCurp.Text = fila.Cells["CURPPaciente"].Value.ToString();
                dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["NacimientoPaciente"].Value);
                string sexo = fila.Cells["sexoPaciente"].Value.ToString();
                if (sexo == "Femenino") radioFemenino.Checked = true;
                else radioMasculino.Checked = true;
                TxtTelefono.Text = fila.Cells["TelefonoPaciente"].Value.ToString();
                TxtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
            }
        }
        private void HabilitarCampos(bool habilitar)
        {
            TxtNombre.Enabled = habilitar;
            TxtCurp.Enabled = habilitar;
            dtpFechaNacimiento.Enabled = habilitar;
            radioMasculino.Enabled = habilitar;
            radioFemenino.Enabled = habilitar;
            TxtTelefono.Enabled = habilitar;
            TxtDireccion.Enabled = habilitar;
        }
        private void CargarPacientes()
        {
            try
            {
                Login login = new Login();
                dgvPacientes.DataSource = login.ObtenerPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona un paciente para eliminar.");
                    return;
                }

                var confirm = MessageBox.Show("¿Estás seguro de que quieres eliminar este paciente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                int idPaciente = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["idPaciente"].Value);

                Login login = new Login();
                login.EliminarPaciente(idPaciente);

                MessageBox.Show("Paciente eliminado correctamente.");
                CargarPacientes(); // Recargar tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar paciente: " + ex.Message);
            }
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCurp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioMedico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioRecepcionista_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRepetirPassword_Click(object sender, EventArgs e)
        {

        }

        private void TxtRepetirPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAcutalizar_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void radioFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona un paciente para actualizar.");
                    return;
                }

                int idPaciente = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["idPaciente"].Value);
                string sexo = radioFemenino.Checked ? "Femenino" : "Masculino";

                Login login = new Login();
                login.ActualizarPaciente(
                    idPaciente,
                    TxtNombre.Text,
                    TxtCurp.Text,
                    dtpFechaNacimiento.Value,
                    sexo,
                    TxtTelefono.Text,
                    TxtDireccion.Text
                );

                MessageBox.Show("Paciente actualizado correctamente.");
                CargarPacientes(); // Vuelve a cargar los datos en el grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar paciente: " + ex.Message);
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona un paciente para eliminar.");
                    return;
                }

                var confirm = MessageBox.Show("¿Estás seguro de que quieres eliminar este paciente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                int idPaciente = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["idPaciente"].Value);

                Login login = new Login();
                login.EliminarPaciente(idPaciente);

                MessageBox.Show("Paciente eliminado correctamente.");
                CargarPacientes(); // Recargar tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar paciente: " + ex.Message);
            }
        }
    }
}