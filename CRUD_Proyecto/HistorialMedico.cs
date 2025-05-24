using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_Proyecto
{
    public partial class HistorialMedico : Form
    {

        private int tipoUsuario;

        public HistorialMedico(int tipo)
        {
            InitializeComponent();
            tipoUsuario = tipo;
            this.Load += HistorialMedico_Load;
        }

        private DataTable Table;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HistorialMedico_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=equipo;password=hola123;database=mydb;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    c.idCitas AS ID,
                    p.NomPaciente AS Nombre,
                    m.NomMedico AS Doctor,
                    DATE_FORMAT(c.fechaCita, '%d/%m/%Y') AS Fecha
                FROM citas c
                INNER JOIN paciente p ON c.Paciente_idPaciente = p.idPaciente
                INNER JOIN medico m ON c.Medico_idMedico = m.idMedico
                ORDER BY c.fechaCita DESC;
            ";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    Table = new DataTable();
                    adapter.Fill(Table);
                    dgv_pacientes.DataSource = Table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void dgv_pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Obtener el valor de la selección del ComboBox.
            int selectedIndex = comboBox1.SelectedIndex;
            

            // Verifica si se ha seleccionado una opción
            if (selectedIndex != -1)
            {
                PacienteEntry.Enabled = true;
                // Obtiene el texto del elemento seleccionado
                string seleccion = comboBox1.SelectedItem.ToString();

                // Actualiza el control de texto (en este caso, un TextBox)
                if (seleccion == "Paciente")
                {
                    PacienteEntry.Clear();
                    label1.Text = "Nombre del Paciente:";
                }
                if (seleccion == "Fecha")
                {
                    label1.Text = "Fecha de consulta:";
                    dateTimePicker1.Visible = true;
                    labelFecha.Visible = true;
                }
                else
                {
                    dateTimePicker1.Visible = false;
                    labelFecha.Visible = false;
                }
                if (seleccion == "Medico")
                {
                    PacienteEntry.Clear();
                    label1.Text = "Nombre del medico:";
                }
            }
        }

        private void PacienteEntry_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(PacienteEntry.Text))
            {
                dgv_pacientes.DataSource = Table;
                return;
            }

            string filtro = PacienteEntry.Text.ToLower();
            string columna = "";

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Paciente":
                    columna = "Nombre";
                    break;
                case "Medico":
                    columna = "Doctor";
                    break;
                case "Fecha":
                    columna = "Fecha";
                    break;
            }

            DataView vista = new DataView(Table);
            vista.RowFilter = $"{columna} LIKE '%{filtro.Replace("'", "''")}%'"; // Previene errores con comillas

            dgv_pacientes.DataSource = vista.ToTable();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            PacienteEntry.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal(tipoUsuario);
            menuPrincipal.Show();
            this.Close();
        }
    }
}
