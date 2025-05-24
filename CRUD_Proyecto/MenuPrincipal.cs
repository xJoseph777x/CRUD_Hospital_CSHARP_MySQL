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
    public partial class MenuPrincipal : Form
    {
        private int tipoUsuario;

        public MenuPrincipal(int tipo)
        {
            InitializeComponent();
            tipoUsuario = tipo;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (tipoUsuario == 1)
            {
                lb_Tipo.Text = "Administrador";
                btnEntrarAdministracion.Visible = true;
                BtnEntrarAccesoMedico.Visible = true;
                BtnReccepcionista.Visible = true;
                btnHisotirialMedico.Visible=true;
                btnDiagnostico.Visible = true;
            }
            else if (tipoUsuario == 2)
            {
                lb_Tipo.Text = "Médico";
                BtnEntrarAccesoMedico.Visible = true;
                btnHisotirialMedico.Visible = true;
                btnDiagnostico.Visible = true;
            }
            else if (tipoUsuario == 3)
            {
                lb_Tipo.Text = "Recepcionista";
                BtnReccepcionista.Visible = true;
                btnHisotirialMedico.Visible = true;
            }
        }

        private void EntrarAdministracion_Click(object sender, EventArgs e)
        {
            Administracion admin = new Administracion();
            this.Hide();
            admin.Show();
        }

        private void lb_Tipo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccesoMedico accesoMedico = new AccesoMedico(tipoUsuario);
            accesoMedico.Show();
            this.Hide();
        }

        private void BtnReccepcionista_Click(object sender, EventArgs e)
        {
            AccesoRecepcionista Recepcionista = new AccesoRecepcionista(tipoUsuario);
            Recepcionista.Show();
            this.Hide();
        }

        private void btnHisotirialMedico_Click(object sender, EventArgs e)
        {
            HistorialMedico historialMedico = new HistorialMedico(tipoUsuario);
            historialMedico.Show();
            this.Hide();
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            Diagnosticos diagnosticos = new Diagnosticos(tipoUsuario);
            diagnosticos.Show();
            this.Hide();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
