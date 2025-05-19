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
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            //Botones a activar
            dtpFechaNacimiento.Enabled = true;
            radioMasculino.Enabled = true;
            radioFemenino.Enabled = true;
            TxtNombre.Enabled = true;
            TxtCurp.Enabled = true;
            TxtTelefono.Enabled = true;
            password.Visible = true;
            TxtRepetirPassword.Visible = true;
            labelRepetirPassword.Visible = true;
            lbPassword.Visible = true;
            //Botones a desactivar
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnSalir.Enabled = false;
            btn_Nuevo.Enabled = false;


        }
    }
}
