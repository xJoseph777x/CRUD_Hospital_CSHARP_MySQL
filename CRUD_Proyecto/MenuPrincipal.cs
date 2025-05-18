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
                lb_Tipo.Text = "Administrador";
            else if (tipoUsuario == 2)
                lb_Tipo.Text = "Médico";
            else if (tipoUsuario == 3)
                lb_Tipo.Text = "Recepcionista";
        }
    }
}
