using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text;
            string password = TxtPassword.Text;

            Login login = new Login();
            int tipo = login.ObtenerTipoUsuario(usuario, password);

            if (tipo > 0)
            {
                MessageBox.Show("¡Login exitoso!");

                MenuPrincipal menu = new MenuPrincipal(tipo);
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal(1);
            this.Hide();
            menu.Show();
        }
    }
}
