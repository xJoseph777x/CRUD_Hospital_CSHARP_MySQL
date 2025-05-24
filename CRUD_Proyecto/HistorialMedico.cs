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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CRUD_Proyecto
{
    public partial class HistorialMedico : Form
    {
        public HistorialMedico()
        {
            InitializeComponent();
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
            if (e.RowIndex >= 0 && dgv_pacientes.Columns[e.ColumnIndex].Name == "btnHistorial")
            {
                int idCita = Convert.ToInt32(dgv_pacientes.Rows[e.RowIndex].Cells["ID"].Value);
                GenerarPDFHistorial(idCita);
            }
        }

        private void GenerarPDFHistorial(int idCita)
        {
            string connectionString = "server=localhost;user=equipo;password=hola123;database=mydb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Obtener datos del paciente y su historial
                string query = @"
            SELECT 
                p.NomPaciente,
                p.NacimientoPaciente,
                p.idPaciente,
                c.fechaCita,
                c.horaCita,
                c.Observaciones,
                m.NomMedico
            FROM citas c
            INNER JOIN paciente p ON c.Paciente_idPaciente = p.idPaciente
            INNER JOIN medico m ON c.Medico_idMedico = m.idMedico
            WHERE c.idCitas = @idCita;
        ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCita", idCita);

                var reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("No se encontró la cita.");
                    return;
                }

                // Capturar datos
                string nombre = reader["NomPaciente"].ToString();
                string nacimiento = Convert.ToDateTime(reader["NacimientoPaciente"]).ToString("dd/MM/yyyy");
                string idPaciente = reader["idPaciente"].ToString();
                string fecha = Convert.ToDateTime(reader["fechaCita"]).ToString("dd/MM/yyyy");
                string hora = reader["horaCita"].ToString();
                string notas = reader["Observaciones"].ToString();
                string medico = reader["NomMedico"].ToString();

                reader.Close();

                // Crear PDF
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = $"Historial_{nombre}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    // Título
                    doc.Add(new Paragraph("Historial Clínico del Paciente", FontFactory.GetFont("Arial")));
                    doc.Add(new Paragraph(" "));

                    // Información paciente
                    doc.Add(new Paragraph($"Nombre: {nombre}"));
                    doc.Add(new Paragraph($"Fecha de Nacimiento: {nacimiento}"));
                    doc.Add(new Paragraph($"ID de Paciente: {idPaciente}"));
                    doc.Add(new Paragraph(" "));

                    // Tabla de evolución
                    PdfPTable table = new PdfPTable(2);
                    table.WidthPercentage = 100;
                    table.AddCell("Fecha/Hora");
                    table.AddCell("Notas");

                    table.AddCell($"{fecha} {hora}");
                    table.AddCell(notas);

                    doc.Add(table);
                    doc.Add(new Paragraph(" "));

                    // Firma
                    doc.Add(new Paragraph($"Nombre del Médico/Profesional: {medico}"));
                    doc.Add(new Paragraph("Especialidad Clínica: ____________________________"));
                    doc.Add(new Paragraph("Firma del Médico/Profesional: ___________________"));

                    doc.Close();

                    MessageBox.Show("PDF generado exitosamente.");
                }
            }
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

            if (!dgv_pacientes.Columns.Contains("Historial"))
            {
                DataGridViewButtonColumn btnHistorial = new DataGridViewButtonColumn();
                btnHistorial.HeaderText = "Historial";
                btnHistorial.Name = "btnHistorial";
                btnHistorial.Text = "Ver PDF";
                btnHistorial.UseColumnTextForButtonValue = true;
                dgv_pacientes.Columns.Add(btnHistorial);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            PacienteEntry.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AccesoMedico acceso = new AccesoMedico();
            acceso.Show();
            this.Close();
        }
    }
}
