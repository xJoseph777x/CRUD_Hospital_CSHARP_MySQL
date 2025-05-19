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
            this.SuspendLayout();
            // 
            // lb_Tipo
            // 
            this.lb_Tipo.AutoSize = true;
            this.lb_Tipo.Location = new System.Drawing.Point(104, 52);
            this.lb_Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Tipo.Name = "lb_Tipo";
            this.lb_Tipo.Size = new System.Drawing.Size(44, 16);
            this.lb_Tipo.TabIndex = 0;
            this.lb_Tipo.Text = "label1";
            this.lb_Tipo.Click += new System.EventHandler(this.lb_Tipo_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lb_Tipo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Tipo;
    }
}