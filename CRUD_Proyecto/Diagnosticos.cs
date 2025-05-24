using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Proyecto
{
    public partial class Diagnosticos : Form
    {
 
        private int tipoUsuario;

        public Diagnosticos(int tipo)
        {
            InitializeComponent();
            tipoUsuario = tipo;
        }

        private void Diagnosticos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCitaPorNombre_Click(object sender, EventArgs e)
        {
            actualizarDataGRid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal(tipoUsuario);
            menuPrincipal.Show();
            this.Hide();
        }

        private void ActualizarCita_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCita = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idCitas"].Value);
                string diag = txtDiagnostico.Text;
                string trat = txtTratamiento.Text;
                string obs = txtObservaciones.Text;

                Dgv_Citas citas = new Dgv_Citas();
                citas.ActualizarCita(idCita, diag, trat, obs);

                MessageBox.Show("Cita actualizada correctamente.");
                actualizarDataGRid();
            }
            else
                MessageBox.Show("Seleccione una cita por favor.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que no se trata del encabezado
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txtDiagnostico.Enabled = true;
                txtTratamiento.Enabled = true;
                txtObservaciones.Enabled = true;

                txtDiagnostico.Text = fila.Cells["Diagnostico"].Value?.ToString();
                txtTratamiento.Text = fila.Cells["Tratamiento"].Value?.ToString();
                txtObservaciones.Text = fila.Cells["Observaciones"].Value?.ToString();
            }
        }

        private void actualizarDataGRid()
        {
            Dgv_Citas citas = new Dgv_Citas();
            DataTable tabla = citas.ObtenerCitasPorNombrePaciente(txtNombre.Text);

            if (tabla.Rows.Count > 0)
            {
                dataGridView1.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("No se encontraron citas para ese nombre.");
                dataGridView1.DataSource = null;
            }
        }
    }
}
