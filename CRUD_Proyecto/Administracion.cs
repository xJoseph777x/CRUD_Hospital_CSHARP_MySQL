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
    public partial class Administracion : Form
    {
        bool banderaDireccion = false, esMEdico = false;
        int opcion = 0;
        int idMedicoSeleccionado = 0;
        int idRecepcionistaSeleccionado = 0, idUsuario = 0;
        private bool esMedicoSeleccionado = false;
        private enum SeleccionUsuario { Ninguno, Medico, Recepcionista }
        private SeleccionUsuario ultimaSeleccion = SeleccionUsuario.Ninguno;

        public Administracion()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            dtpFechaNacimiento.Enabled = false;
            radioMasculino.Enabled = false;
            radioFemenino.Enabled = false;

            //Llenar el dataGridView
            Dgv_Admin medico = new Dgv_Admin();
            dgv_Medicos.DataSource = medico.ObtenerMedicos();
            Dgv_Admin usuario = new Dgv_Admin();
            dgvUsuarios.DataSource = usuario.ObtenerUsuarios();
            AjustarColumnas();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            //Botones a activar
            dtpFechaNacimiento.Enabled = true;
            radioMasculino.Enabled = true;
            radioFemenino.Enabled = true;
            radioMedico.Enabled = true;
            radioRecepcionista.Enabled = true;
            TxtNombre.Enabled = true;
            TxtCurp.Enabled = true;
            TxtCurp.Enabled = true;
            password.Visible = true;
            TxtRepetirPassword.Visible = true;
            labelRepetirPassword.Visible = true;
            lbPassword.Visible = true;
            password.Enabled = true;
            TxtRepetirPassword.Enabled = true;
            labelRepetirPassword.Enabled = true;
            lbPassword.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_guardar.Enabled = true;
            TxtTelefono.Enabled = true;
            //Botones a desactivar
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnSalir.Enabled = false;
            btn_Nuevo.Enabled = false;
            dgvUsuarios.Enabled = false;
            dgv_Medicos.Enabled = false;


            TxtNombre.Text = "";
            TxtCurp.Text = "";
            TxtTelefono.Text = "";
            txtDireccion.Text = "";
            password.Text = "";
            TxtRepetirPassword.Text = "";

            // Restablecer fecha
            dtpFechaNacimiento.Value = DateTime.Now;

            // Desmarcar radios
            radioMasculino.Checked = false;
            radioFemenino.Checked = false;
            radioMedico.Checked = false;
            radioRecepcionista.Checked = false;

            banderaDireccion = true;
            opcion = 1;
        }

        private void dgv_articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgv_Medicos.Rows[e.RowIndex];

                TxtNombre.Text = fila.Cells["NomMedico"].Value.ToString();
                TxtCurp.Text = fila.Cells["CURPMedico"].Value.ToString();
                TxtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();

                dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["NacimientoMedico"].Value);

                // Sexo (string): Masculino o Femenino
                string sexo = fila.Cells["sexo"].Value.ToString();
                radioMasculino.Checked = sexo == "Masculino";
                radioMasculino.Checked = sexo == "Femenino";

                // Tipo de usuario (médico)
                radioMasculino.Checked = true;

                if (e.RowIndex >= 0)
                {
                    var valor = dgv_Medicos.Rows[e.RowIndex];
                    idMedicoSeleccionado = Convert.ToInt32(fila.Cells["idMedico"].Value);
                    idRecepcionistaSeleccionado = 0;
                    idUsuario = idMedicoSeleccionado;
                }
                esMEdico = true;
                ultimaSeleccion = SeleccionUsuario.Medico;
                esMedicoSeleccionado = true;
                lbrespuesta.Text = "esMedicoSeleccionado";
            }
        }
        private void BtnAcutalizar_Click(object sender, EventArgs e)
        {
            Dgv_Admin medico = new Dgv_Admin();
            dgv_Medicos.DataSource = medico.ObtenerMedicos();
            AjustarColumnas();
        }

        private void AjustarColumnas()
        {
            dgv_Medicos.Columns["idMedico"].Width = 60;
            dgv_Medicos.Columns["NomMedico"].Width = 100;
            dgv_Medicos.Columns["CURPMedico"].Width = 110;
            dgv_Medicos.Columns["NacimientoMedico"].Width = 80;
            dgv_Medicos.Columns["sexo"].Width = 50;
            dgv_Medicos.Columns["Telefono"].Width = 80;
            dgv_Medicos.Columns["Direccion"].Width = 80;
            dgvUsuarios.Columns["idUsuario"].Width = 60;
            dgvUsuarios.Columns["NomUsuario"].Width = 140;
            dgvUsuarios.Columns["CURPUsuario"].Width = 160;
            dgvUsuarios.Columns["tipo"].Width = 50;
            dgvUsuarios.Columns["clave"].Width = 100;
            dgvUsuarios.Columns["sexo"].Width = 60;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dgv_Admin usuario = new Dgv_Admin();
            dgvUsuarios.DataSource = usuario.ObtenerUsuarios();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvUsuarios.Rows[e.RowIndex];

                TxtNombre.Text = fila.Cells["NomUsuario"].Value.ToString();
                TxtCurp.Text = fila.Cells["CURPUsuario"].Value.ToString();
                TxtTelefono.Text = ""; // Asumimos que no hay teléfono en tabla usuarios
                txtDireccion.Text = ""; // Igual

                dtpFechaNacimiento.Value = DateTime.Now;

                int sexo = Convert.ToInt32(fila.Cells["sexo"].Value);
                radioMasculino.Checked = sexo == 1;
                radioMasculino.Checked = sexo == 2;

                radioMasculino.Checked = true;

                if (e.RowIndex >= 0)
                {
                    var valor = dgvUsuarios.Rows[e.RowIndex];
                    idRecepcionistaSeleccionado = Convert.ToInt32(fila.Cells["idUsuario"].Value);
                    idMedicoSeleccionado = 0;
                    idUsuario = idRecepcionistaSeleccionado;
                }

                esMEdico = false;
                ultimaSeleccion = SeleccionUsuario.Recepcionista;
                esMedicoSeleccionado = false;
                lbrespuesta.Text = "NO MedicoSeleccionado";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimpiezaProfunda();
            dgvUsuarios.Enabled = true;
            dgv_Medicos.Enabled = true;
        }
        private void radioMedico_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioMedico.Checked && banderaDireccion)
            {
                txtDireccion.Enabled = true;
                txtDireccion.Text = "";
                lbDireccion.Visible = true;
            }
            else
            {
                txtDireccion.Enabled = false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (opcion == 1)
            {
                // Obtener datos de los controles
                string nombre = TxtNombre.Text.Trim();
                string curp = TxtCurp.Text.Trim();
                string clave = password.Text;
                string repetirClave = TxtRepetirPassword.Text;
                string telefono = TxtTelefono.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                DateTime nacimiento = dtpFechaNacimiento.Value;

                int sexo = radioMasculino.Checked ? 1 : 2; // 1 = Masculino, 2 = Femenino
                bool esMedico = radioMedico.Checked;

                // Llamar al método
                Dgv_Admin nuevo = new Dgv_Admin();
                bool registrado = nuevo.RegistrarUsuario(
                    nombre, curp, clave, repetirClave, sexo,
                    nacimiento, telefono, direccion, esMedico
                );

                if (registrado)
                {
                    MessageBox.Show("Registro exitoso.");
                    LimpiezaProfunda();
                    dgvUsuarios.Enabled = true;
                    dgv_Medicos.Enabled = true;
                }
                else
                    MessageBox.Show("Error al registrar. Verifica los datos.");
            }
            else if (opcion == 2)
            {
                if (esMEdico) 
                {
                    if (idMedicoSeleccionado == 0)
                    {
                        MessageBox.Show("Selecciona un médico.");
                        return;
                    }
                    string nombre = TxtNombre.Text.Trim();
                    string direccion = txtDireccion.Text.Trim();
                    string telefono = TxtTelefono.Text.Trim();
                    string nuevaClave = password.Text.Trim();

                    Dgv_Admin login = new Dgv_Admin();
                    bool exito = login.ActualizarDatosYContrasenaMedico(idMedicoSeleccionado, nombre, nombre, direccion, telefono, nuevaClave);

                    MessageBox.Show(exito ? "Médico actualizado." : "Error al actualizar médico.");
                    if (exito)
                    {
                        dgvUsuarios.Enabled = true;
                        dgv_Medicos.Enabled = true;
                        LimpiezaProfunda();
                    }
                }
                else
                {
                    if (idRecepcionistaSeleccionado == 0)
                    {
                        MessageBox.Show("Selecciona un recepcionista.");
                        return;
                    }
                    string nuevaClave = password.Text.Trim();
                    string nombre = TxtNombre.Text.Trim();

                    Dgv_Admin login = new Dgv_Admin();
                    bool exito = login.ActualizarDatosYContrasenaRecepcionista(idRecepcionistaSeleccionado, nombre, nuevaClave);

                    MessageBox.Show(exito ? "Recepcionista actualizado." : "Error al actualizar recepcionista.");
                    if (exito)
                    {
                        dgvUsuarios.Enabled = true;
                        dgv_Medicos.Enabled = true;
                        LimpiezaProfunda();
                    }
                        
                }
                
            }
            else if(opcion == 3)
            {
                
            }


        }
        private void LimpiezaProfunda()
        {
            
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnSalir.Enabled = true;
            btn_Nuevo.Enabled = true;

            // Deshabilitar o ocultar
            dtpFechaNacimiento.Enabled = false;
            radioMasculino.Enabled = false;
            radioFemenino.Enabled = false;
            radioMedico.Enabled = false;
            radioRecepcionista.Enabled = false;
            TxtNombre.Enabled = false;
            TxtCurp.Enabled = false;
            password.Visible = false;
            TxtRepetirPassword.Visible = false;
            labelRepetirPassword.Visible = false;
            lbPassword.Visible = false;
            btn_cancelar.Enabled = false;
            btn_guardar.Enabled = false;
            banderaDireccion = false;
            opcion = 0;

            // Limpiar valores
            dtpFechaNacimiento.Value = DateTime.Now; // o la fecha que prefieras
            radioMasculino.Checked = false;
            radioFemenino.Checked = false;
            radioMedico.Checked = false;
            radioRecepcionista.Checked = false;
            TxtNombre.Text = "";
            TxtCurp.Text = "";
            password.Text = "";
            TxtRepetirPassword.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (esMedicoSeleccionado)
            {
                if (dgv_Medicos.SelectedRows.Count > 0)
                {
                    Dgv_Admin borrar = new Dgv_Admin();
                    int idMedico = Convert.ToInt32(dgv_Medicos.SelectedRows[0].Cells["idMedico"].Value);
                    borrar.EliminarMedicoYUsuario(idMedico);
                    MessageBox.Show("Médico eliminado.");
                }
                else
                {
                    MessageBox.Show("Selecciona un médico.");
                }
            }
            else
            {
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    Dgv_Admin borrar = new Dgv_Admin();
                    int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["idUsuario"].Value);
                    borrar.EliminarSoloUsuario(idUsuario);
                    MessageBox.Show("Recepcionista eliminado.");
                }
                else
                {
                    MessageBox.Show("Selecciona un recepcionista.");
                }
            }

            TxtNombre.Text = "";
            TxtCurp.Text = "";
            TxtTelefono.Text = "";
            txtDireccion.Text = "";
            password.Text = "";
            TxtRepetirPassword.Text = "";

            // Restablecer fecha
            dtpFechaNacimiento.Value = DateTime.Now;

            // Desmarcar radios
            radioMasculino.Checked = false;
            radioFemenino.Checked = false;
            radioMedico.Checked = false;
            radioRecepcionista.Checked = false;


        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal(1);
            this.Hide();
            menu.Show();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            dtpFechaNacimiento.Enabled = false;
            radioMasculino.Enabled = false;
            radioFemenino.Enabled = false;
            radioMedico.Enabled = false;
            radioRecepcionista.Enabled = false;
            TxtNombre.Enabled = true;
            TxtCurp.Enabled = false;
            password.Visible = true;
            TxtRepetirPassword.Visible = true;
            labelRepetirPassword.Visible = true;
            lbPassword.Visible = true;
            password.Enabled = true;
            TxtRepetirPassword.Enabled = true;
            labelRepetirPassword.Enabled = true;
            lbPassword.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_guardar.Enabled = true;
            //Botones a desactivar
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnSalir.Enabled = false;
            btn_Nuevo.Enabled = false;

            if(esMEdico)
            {
                TxtTelefono.Enabled = true;
                txtDireccion.Enabled = true;
            }
            else 
            {
                TxtTelefono.Enabled = false;
                txtDireccion.Enabled = false;
            }

            dgvUsuarios.Enabled = false;
            dgv_Medicos.Enabled = false;

            opcion = 2;
        }

    }
}
