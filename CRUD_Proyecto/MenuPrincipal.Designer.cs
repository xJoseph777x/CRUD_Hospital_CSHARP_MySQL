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
            this.SuspendLayout();
            // 
            // lb_Tipo
            // 
            this.lb_Tipo.AutoSize = true;
            this.lb_Tipo.Location = new System.Drawing.Point(78, 42);
            this.lb_Tipo.Name = "lb_Tipo";
            this.lb_Tipo.Size = new System.Drawing.Size(35, 13);
            this.lb_Tipo.TabIndex = 0;
            this.lb_Tipo.Text = "label1";
            // 
            // btnEntrarAdministracion
            // 
            this.btnEntrarAdministracion.Location = new System.Drawing.Point(572, 42);
            this.btnEntrarAdministracion.Name = "btnEntrarAdministracion";
            this.btnEntrarAdministracion.Size = new System.Drawing.Size(75, 23);
            this.btnEntrarAdministracion.TabIndex = 1;
            this.btnEntrarAdministracion.Text = "Administrar";
            this.btnEntrarAdministracion.UseVisualStyleBackColor = true;
            this.btnEntrarAdministracion.Visible = false;
            this.btnEntrarAdministracion.Click += new System.EventHandler(this.EntrarAdministracion_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}