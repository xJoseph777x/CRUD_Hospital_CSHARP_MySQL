namespace CRUD_Proyecto
{
    partial class HistorialMedico
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
            this.label1 = new System.Windows.Forms.Label();
            this.PacienteEntry = new System.Windows.Forms.TextBox();
            this.dgv_pacientes = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoga un tipo de filtro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PacienteEntry
            // 
            this.PacienteEntry.Enabled = false;
            this.PacienteEntry.Location = new System.Drawing.Point(452, 43);
            this.PacienteEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PacienteEntry.Name = "PacienteEntry";
            this.PacienteEntry.Size = new System.Drawing.Size(232, 22);
            this.PacienteEntry.TabIndex = 1;
            this.PacienteEntry.TextChanged += new System.EventHandler(this.PacienteEntry_TextChanged);
            // 
            // dgv_pacientes
            // 
            this.dgv_pacientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes.Location = new System.Drawing.Point(16, 166);
            this.dgv_pacientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_pacientes.Name = "dgv_pacientes";
            this.dgv_pacientes.RowHeadersWidth = 51;
            this.dgv_pacientes.Size = new System.Drawing.Size(1035, 373);
            this.dgv_pacientes.TabIndex = 2;
            this.dgv_pacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pacientes_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Paciente",
            "Fecha",
            "Medico"});
            this.comboBox1.Location = new System.Drawing.Point(452, 75);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtrar por:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(452, 108);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2025, 5, 22, 1, 47, 35, 0);
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(321, 112);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(118, 16);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "Escoga una fecha:";
            this.labelFecha.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = true;
            this.btnRegresar.Location = new System.Drawing.Point(30, 37);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 26);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // HistorialMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgv_pacientes);
            this.Controls.Add(this.PacienteEntry);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HistorialMedico";
            this.Text = "HistorialMedico";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PacienteEntry;
        private System.Windows.Forms.DataGridView dgv_pacientes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Button btnRegresar;
    }
}