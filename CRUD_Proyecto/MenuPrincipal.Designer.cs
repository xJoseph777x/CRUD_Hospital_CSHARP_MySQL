namespace CRUD_Proyecto
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Tipo = new System.Windows.Forms.Label();
            this.btnEntrarAdministracion = new System.Windows.Forms.Button();
            this.BtnEntrarAccesoMedico = new System.Windows.Forms.Button();
            this.BtnReccepcionista = new System.Windows.Forms.Button();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.btnHisotirialMedico = new System.Windows.Forms.Button();
            this.btnDiagnostico = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Tipo
            // 
            this.lb_Tipo.AutoSize = true;
            this.lb_Tipo.Location = new System.Drawing.Point(44, 22);
            this.lb_Tipo.Name = "lb_Tipo";
            this.lb_Tipo.Size = new System.Drawing.Size(35, 13);
            this.lb_Tipo.TabIndex = 0;
            this.lb_Tipo.Text = "label1";
            this.lb_Tipo.Click += new System.EventHandler(this.lb_Tipo_Click);
            // 
            // btnEntrarAdministracion
            // 
            this.btnEntrarAdministracion.Location = new System.Drawing.Point(311, 22);
            this.btnEntrarAdministracion.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrarAdministracion.Name = "btnEntrarAdministracion";
            this.btnEntrarAdministracion.Size = new System.Drawing.Size(252, 31);
            this.btnEntrarAdministracion.TabIndex = 1;
            this.btnEntrarAdministracion.Text = "Administrar";
            this.btnEntrarAdministracion.UseVisualStyleBackColor = true;
            this.btnEntrarAdministracion.Visible = false;
            this.btnEntrarAdministracion.Click += new System.EventHandler(this.EntrarAdministracion_Click);
            // 
            // BtnEntrarAccesoMedico
            // 
            this.BtnEntrarAccesoMedico.Location = new System.Drawing.Point(47, 234);
            this.BtnEntrarAccesoMedico.Name = "BtnEntrarAccesoMedico";
            this.BtnEntrarAccesoMedico.Size = new System.Drawing.Size(252, 31);
            this.BtnEntrarAccesoMedico.TabIndex = 2;
            this.BtnEntrarAccesoMedico.Text = "Medico";
            this.BtnEntrarAccesoMedico.UseVisualStyleBackColor = true;
            this.BtnEntrarAccesoMedico.Visible = false;
            this.BtnEntrarAccesoMedico.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnReccepcionista
            // 
            this.BtnReccepcionista.Location = new System.Drawing.Point(47, 108);
            this.BtnReccepcionista.Name = "BtnReccepcionista";
            this.BtnReccepcionista.Size = new System.Drawing.Size(252, 31);
            this.BtnReccepcionista.TabIndex = 3;
            this.BtnReccepcionista.Text = "Recepcionista";
            this.BtnReccepcionista.UseVisualStyleBackColor = true;
            this.BtnReccepcionista.Visible = false;
            this.BtnReccepcionista.Click += new System.EventHandler(this.BtnReccepcionista_Click);
            // 
            // btnHisotirialMedico
            // 
            this.btnHisotirialMedico.Location = new System.Drawing.Point(47, 189);
            this.btnHisotirialMedico.Name = "btnHisotirialMedico";
            this.btnHisotirialMedico.Size = new System.Drawing.Size(252, 31);
            this.btnHisotirialMedico.TabIndex = 4;
            this.btnHisotirialMedico.Text = "Historial Medico";
            this.btnHisotirialMedico.UseVisualStyleBackColor = true;
            this.btnHisotirialMedico.Visible = false;
            this.btnHisotirialMedico.Click += new System.EventHandler(this.btnHisotirialMedico_Click);
            // 
            // btnDiagnostico
            // 
            this.btnDiagnostico.Location = new System.Drawing.Point(47, 147);
            this.btnDiagnostico.Name = "btnDiagnostico";
            this.btnDiagnostico.Size = new System.Drawing.Size(252, 31);
            this.btnDiagnostico.TabIndex = 5;
            this.btnDiagnostico.Text = "Diagnostico";
            this.btnDiagnostico.UseVisualStyleBackColor = true;
            this.btnDiagnostico.Click += new System.EventHandler(this.btnDiagnostico_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(501, 311);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 43);
            this.cerrar.TabIndex = 6;
            this.cerrar.Text = "Cerrar Programa";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.btnDiagnostico);
            this.Controls.Add(this.btnHisotirialMedico);
            this.Controls.Add(this.BtnReccepcionista);
            this.Controls.Add(this.BtnEntrarAccesoMedico);
            this.Controls.Add(this.btnEntrarAdministracion);
            this.Controls.Add(this.lb_Tipo);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Tipo;
        private System.Windows.Forms.Button btnEntrarAdministracion;
        private System.Windows.Forms.Button BtnEntrarAccesoMedico;
        private System.Windows.Forms.Button BtnReccepcionista;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.Button btnHisotirialMedico;
        private System.Windows.Forms.Button btnDiagnostico;
        private System.Windows.Forms.Button cerrar;
    }
}