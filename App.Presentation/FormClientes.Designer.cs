﻿namespace App.Presentation
{
    partial class FormClientes
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txt4 = new Label();
            txt2 = new Label();
            txt1 = new Label();
            txtTel = new TextBox();
            txtDirec = new TextBox();
            txtDni = new TextBox();
            Texto5 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            Text1 = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtCiudad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCodPostal = new TextBox();
            dgvClientes = new DataGridView();
            clienteid = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            ciudad = new DataGridViewTextBoxColumn();
            codigopostal = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            cbItemsPorPagina = new ComboBox();
            txtPagina = new TextBox();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            txt6 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBusar = new TextBox();
            labelcontenedor = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txt4
            // 
            txt4.AutoSize = true;
            txt4.BackColor = Color.FromArgb(40, 60, 90);
            txt4.ForeColor = Color.White;
            txt4.Location = new Point(-1, 206);
            txt4.Name = "txt4";
            txt4.Size = new Size(55, 15);
            txt4.TabIndex = 59;
            txt4.Text = "Telefono:";
            // 
            // txt2
            // 
            txt2.AutoSize = true;
            txt2.BackColor = Color.FromArgb(40, 60, 90);
            txt2.ForeColor = Color.White;
            txt2.Location = new Point(0, 162);
            txt2.Name = "txt2";
            txt2.Size = new Size(60, 15);
            txt2.TabIndex = 58;
            txt2.Text = "Direccion:";
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.BackColor = Color.FromArgb(40, 60, 90);
            txt1.ForeColor = Color.White;
            txt1.Location = new Point(1, 118);
            txt1.Name = "txt1";
            txt1.Size = new Size(28, 15);
            txt1.TabIndex = 57;
            txt1.Text = "Dni:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(-1, 224);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(210, 23);
            txtTel.TabIndex = 56;
            // 
            // txtDirec
            // 
            txtDirec.Location = new Point(1, 180);
            txtDirec.Name = "txtDirec";
            txtDirec.Size = new Size(210, 23);
            txtDirec.TabIndex = 55;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(0, 136);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(210, 23);
            txtDni.TabIndex = 54;
            // 
            // Texto5
            // 
            Texto5.BackColor = Color.FromArgb(45, 66, 91);
            Texto5.BorderStyle = BorderStyle.FixedSingle;
            Texto5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Texto5.ForeColor = Color.White;
            Texto5.Location = new Point(0, 25);
            Texto5.Name = "Texto5";
            Texto5.Size = new Size(211, 27);
            Texto5.TabIndex = 53;
            Texto5.Text = "Agregar Cliente";
            Texto5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 16;
            btnEliminar.Location = new Point(1, 456);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(210, 23);
            btnEliminar.TabIndex = 52;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.Black;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 16;
            btnEditar.Location = new Point(1, 427);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(210, 23);
            btnEditar.TabIndex = 51;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.ForestGreen;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.Black;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 16;
            btnAgregar.Location = new Point(0, 398);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(210, 23);
            btnAgregar.TabIndex = 50;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Text1
            // 
            Text1.AutoSize = true;
            Text1.BackColor = Color.FromArgb(40, 60, 90);
            Text1.ForeColor = Color.White;
            Text1.Location = new Point(0, 74);
            Text1.Name = "Text1";
            Text1.Size = new Size(54, 15);
            Text1.TabIndex = 49;
            Text1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(0, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 48;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(0, 268);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 60;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(1, 312);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(210, 23);
            txtCiudad.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 60, 90);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-1, 250);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 62;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(40, 60, 90);
            label2.ForeColor = Color.White;
            label2.Location = new Point(-1, 294);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 63;
            label2.Text = "Ciudad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(40, 60, 90);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 338);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 65;
            label3.Text = "Codigo Postal:";
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(1, 356);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(210, 23);
            txtCodPostal.TabIndex = 64;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clienteid, nombre, dni, direccion, telefono, email, ciudad, codigopostal });
            dgvClientes.DataSource = clienteBindingSource;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.White;
            dgvClientes.Location = new Point(215, 31);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1034, 494);
            dgvClientes.TabIndex = 75;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // clienteid
            // 
            clienteid.DataPropertyName = "clienteid";
            clienteid.HeaderText = "N° Cliente";
            clienteid.Name = "clienteid";
            clienteid.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // dni
            // 
            dni.DataPropertyName = "dni";
            dni.HeaderText = "Dni";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.DataPropertyName = "direccion";
            direccion.HeaderText = "Direccion";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // ciudad
            // 
            ciudad.DataPropertyName = "ciudad";
            ciudad.HeaderText = "Ciudad";
            ciudad.Name = "ciudad";
            ciudad.ReadOnly = true;
            // 
            // codigopostal
            // 
            codigopostal.DataPropertyName = "codigopostal";
            codigopostal.HeaderText = "C.P";
            codigopostal.Name = "codigopostal";
            codigopostal.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Entities.Cliente);
            // 
            // cbItemsPorPagina
            // 
            cbItemsPorPagina.FormattingEnabled = true;
            cbItemsPorPagina.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "50" });
            cbItemsPorPagina.Location = new Point(1220, 533);
            cbItemsPorPagina.Name = "cbItemsPorPagina";
            cbItemsPorPagina.Size = new Size(29, 23);
            cbItemsPorPagina.TabIndex = 74;
            cbItemsPorPagina.SelectedIndexChanged += cbItemsPorPagina_SelectedIndexChanged;
            // 
            // txtPagina
            // 
            txtPagina.BackColor = SystemColors.ActiveCaption;
            txtPagina.Location = new Point(1146, 533);
            txtPagina.Name = "txtPagina";
            txtPagina.Size = new Size(30, 23);
            txtPagina.TabIndex = 73;
            txtPagina.TextChanged += txtPagina_TextChanged;
            // 
            // btnAnterior
            // 
            btnAnterior.AccessibleDescription = "";
            btnAnterior.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            btnAnterior.IconColor = Color.Black;
            btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnterior.IconSize = 20;
            btnAnterior.Location = new Point(1104, 533);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(36, 23);
            btnAnterior.TabIndex = 72;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.MailForward;
            btnSiguiente.IconColor = Color.Black;
            btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSiguiente.IconSize = 20;
            btnSiguiente.Location = new Point(1182, 533);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(34, 23);
            btnSiguiente.TabIndex = 71;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // txt6
            // 
            txt6.BackColor = Color.FromArgb(45, 66, 91);
            txt6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt6.ForeColor = Color.White;
            txt6.Location = new Point(215, 2);
            txt6.Name = "txt6";
            txt6.Size = new Size(152, 23);
            txt6.TabIndex = 70;
            txt6.Text = "Lista de Clientes";
            txt6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(45, 66, 91);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 24;
            btnBuscar.Location = new Point(1218, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(31, 23);
            btnBuscar.TabIndex = 92;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += iconButton2_Click;
            // 
            // txtBusar
            // 
            txtBusar.BorderStyle = BorderStyle.FixedSingle;
            txtBusar.Location = new Point(1002, 6);
            txtBusar.Name = "txtBusar";
            txtBusar.Size = new Size(214, 23);
            txtBusar.TabIndex = 91;
            txtBusar.TextChanged += textBox1_TextChanged;
            // 
            // labelcontenedor
            // 
            labelcontenedor.BackColor = Color.FromArgb(40, 60, 90);
            labelcontenedor.BorderStyle = BorderStyle.FixedSingle;
            labelcontenedor.Dock = DockStyle.Left;
            labelcontenedor.Location = new Point(0, 0);
            labelcontenedor.Name = "labelcontenedor";
            labelcontenedor.Size = new Size(211, 594);
            labelcontenedor.TabIndex = 93;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1285, 594);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusar);
            Controls.Add(dgvClientes);
            Controls.Add(cbItemsPorPagina);
            Controls.Add(txtPagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(txt6);
            Controls.Add(label3);
            Controls.Add(txtCodPostal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCiudad);
            Controls.Add(txtEmail);
            Controls.Add(txt4);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(txtTel);
            Controls.Add(txtDirec);
            Controls.Add(txtDni);
            Controls.Add(Texto5);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(Text1);
            Controls.Add(txtNombre);
            Controls.Add(labelcontenedor);
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt4;
        private Label txt2;
        private Label txt1;
        private TextBox txtTel;
        private TextBox txtDirec;
        private TextBox txtDni;
        private Label Texto5;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Label Text1;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtCiudad;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCodPostal;
        private DataGridView dgvClientes;
        private ComboBox cbItemsPorPagina;
        private TextBox txtPagina;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private Label txt6;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBusar;
        private Label labelcontenedor;
        private BindingSource clienteBindingSource;
        private DataGridViewTextBoxColumn clienteid;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn ciudad;
        private DataGridViewTextBoxColumn codigopostal;
    }
}