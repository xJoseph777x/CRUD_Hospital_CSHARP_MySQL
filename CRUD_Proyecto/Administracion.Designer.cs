namespace CRUD_Proyecto
{
    partial class Administracion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAcutalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Medicos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.radioFemenino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioRecepcionista = new System.Windows.Forms.RadioButton();
            this.radioMedico = new System.Windows.Forms.RadioButton();
            this.lbPassword = new System.Windows.Forms.Label();
            this.labelRepetirPassword = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCurp = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.TxtRepetirPassword = new System.Windows.Forms.TextBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbrespuesta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(725, 148);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 23);
            this.btnBuscar.TabIndex = 49;
            this.btnBuscar.Text = "------";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(462, 148);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(257, 20);
            this.Txt_Buscar.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-113, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Buscar:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ImageKey = "1486564399-close_81512.png";
            this.BtnSalir.Location = new System.Drawing.Point(605, 22);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(114, 93);
            this.BtnSalir.TabIndex = 46;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ImageKey = "business_deletethedatabase_exit_db_delete_busines_2346.png";
            this.BtnEliminar.Location = new System.Drawing.Point(462, 22);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(114, 93);
            this.BtnEliminar.TabIndex = 44;
            this.BtnEliminar.Text = "eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.ImageKey = "Exit-Page_icon-icons.com_53732.png";
            this.BtnActualizar.Location = new System.Drawing.Point(318, 22);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(114, 93);
            this.BtnActualizar.TabIndex = 43;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.ImageKey = "nuevo.png";
            this.btn_Nuevo.Location = new System.Drawing.Point(184, 22);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(114, 93);
            this.btn_Nuevo.TabIndex = 42;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(158, 482);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(85, 39);
            this.btn_guardar.TabIndex = 41;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(35, 487);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(78, 34);
            this.btn_cancelar.TabIndex = 40;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-113, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Stock Actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Telefono:";
            // 
            // BtnAcutalizar
            // 
            this.BtnAcutalizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAcutalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcutalizar.Location = new System.Drawing.Point(353, 148);
            this.BtnAcutalizar.Name = "BtnAcutalizar";
            this.BtnAcutalizar.Size = new System.Drawing.Size(56, 23);
            this.BtnAcutalizar.TabIndex = 34;
            this.BtnAcutalizar.Text = "------";
            this.BtnAcutalizar.UseVisualStyleBackColor = true;
            this.BtnAcutalizar.Click += new System.EventHandler(this.BtnAcutalizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-113, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Medida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-113, -14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Articulo:";
            // 
            // dgv_Medicos
            // 
            this.dgv_Medicos.AllowUserToAddRows = false;
            this.dgv_Medicos.AllowUserToDeleteRows = false;
            this.dgv_Medicos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Medicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Medicos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Medicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Medicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medicos.Location = new System.Drawing.Point(353, 180);
            this.dgv_Medicos.Name = "dgv_Medicos";
            this.dgv_Medicos.ReadOnly = true;
            this.dgv_Medicos.RowHeadersWidth = 51;
            this.dgv_Medicos.Size = new System.Drawing.Size(548, 157);
            this.dgv_Medicos.TabIndex = 27;
            this.dgv_Medicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_articulos_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "CURP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Nombre Completo:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(119, 204);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(219, 20);
            this.dtpFechaNacimiento.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMasculino);
            this.groupBox1.Controls.Add(this.radioFemenino);
            this.groupBox1.Location = new System.Drawing.Point(119, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 41);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Location = new System.Drawing.Point(97, 18);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioMasculino.TabIndex = 1;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "Masculino";
            this.radioMasculino.UseVisualStyleBackColor = true;
            // 
            // radioFemenino
            // 
            this.radioFemenino.AutoSize = true;
            this.radioFemenino.Location = new System.Drawing.Point(6, 18);
            this.radioFemenino.Name = "radioFemenino";
            this.radioFemenino.Size = new System.Drawing.Size(71, 17);
            this.radioFemenino.TabIndex = 0;
            this.radioFemenino.TabStop = true;
            this.radioFemenino.Text = "Femenino";
            this.radioFemenino.UseVisualStyleBackColor = true;
            this.radioFemenino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioRecepcionista);
            this.groupBox2.Controls.Add(this.radioMedico);
            this.groupBox2.Location = new System.Drawing.Point(119, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 41);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioRecepcionista
            // 
            this.radioRecepcionista.AutoSize = true;
            this.radioRecepcionista.Enabled = false;
            this.radioRecepcionista.Location = new System.Drawing.Point(97, 19);
            this.radioRecepcionista.Name = "radioRecepcionista";
            this.radioRecepcionista.Size = new System.Drawing.Size(93, 17);
            this.radioRecepcionista.TabIndex = 1;
            this.radioRecepcionista.TabStop = true;
            this.radioRecepcionista.Text = "Recepcionista";
            this.radioRecepcionista.UseVisualStyleBackColor = true;
            // 
            // radioMedico
            // 
            this.radioMedico.AutoSize = true;
            this.radioMedico.Enabled = false;
            this.radioMedico.Location = new System.Drawing.Point(6, 18);
            this.radioMedico.Name = "radioMedico";
            this.radioMedico.Size = new System.Drawing.Size(60, 17);
            this.radioMedico.TabIndex = 0;
            this.radioMedico.TabStop = true;
            this.radioMedico.Text = "Medico";
            this.radioMedico.UseVisualStyleBackColor = true;
            this.radioMedico.CheckedChanged += new System.EventHandler(this.radioMedico_CheckedChanged_1);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(60, 419);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 57;
            this.lbPassword.Text = "Password:";
            this.lbPassword.Visible = false;
            // 
            // labelRepetirPassword
            // 
            this.labelRepetirPassword.AutoSize = true;
            this.labelRepetirPassword.Location = new System.Drawing.Point(19, 456);
            this.labelRepetirPassword.Name = "labelRepetirPassword";
            this.labelRepetirPassword.Size = new System.Drawing.Size(93, 13);
            this.labelRepetirPassword.TabIndex = 59;
            this.labelRepetirPassword.Text = "Repetir Password:";
            this.labelRepetirPassword.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(119, 148);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(219, 20);
            this.TxtNombre.TabIndex = 61;
            // 
            // TxtCurp
            // 
            this.TxtCurp.Enabled = false;
            this.TxtCurp.Location = new System.Drawing.Point(119, 174);
            this.TxtCurp.Name = "TxtCurp";
            this.TxtCurp.Size = new System.Drawing.Size(219, 20);
            this.TxtCurp.TabIndex = 62;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Enabled = false;
            this.TxtTelefono.Location = new System.Drawing.Point(119, 292);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(148, 20);
            this.TxtTelefono.TabIndex = 63;
            // 
            // password
            // 
            this.password.Enabled = false;
            this.password.Location = new System.Drawing.Point(125, 419);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(171, 20);
            this.password.TabIndex = 64;
            // 
            // TxtRepetirPassword
            // 
            this.TxtRepetirPassword.Enabled = false;
            this.TxtRepetirPassword.Location = new System.Drawing.Point(125, 456);
            this.TxtRepetirPassword.Name = "TxtRepetirPassword";
            this.TxtRepetirPassword.Size = new System.Drawing.Size(171, 20);
            this.TxtRepetirPassword.TabIndex = 65;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(353, 392);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.Size = new System.Drawing.Size(548, 164);
            this.dgvUsuarios.TabIndex = 66;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(725, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 69;
            this.button1.Text = "------";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(462, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 68;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(353, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "------";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(121, 379);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(177, 20);
            this.txtDireccion.TabIndex = 71;
            this.txtDireccion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(64, 379);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(55, 13);
            this.lbDireccion.TabIndex = 70;
            this.lbDireccion.Text = "Direccion:";
            // 
            // lbrespuesta
            // 
            this.lbrespuesta.AutoSize = true;
            this.lbrespuesta.Location = new System.Drawing.Point(83, 63);
            this.lbrespuesta.Name = "lbrespuesta";
            this.lbrespuesta.Size = new System.Drawing.Size(35, 13);
            this.lbrespuesta.TabIndex = 72;
            this.lbrespuesta.Text = "label9";
            this.lbrespuesta.Visible = false;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 568);
            this.Controls.Add(this.lbrespuesta);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.TxtRepetirPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtCurp);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.labelRepetirPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAcutalizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Medicos);
            this.Name = "Administracion";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAcutalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Medicos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFemenino;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioRecepcionista;
        private System.Windows.Forms.RadioButton radioMedico;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label labelRepetirPassword;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCurp;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox TxtRepetirPassword;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbrespuesta;
    }
}