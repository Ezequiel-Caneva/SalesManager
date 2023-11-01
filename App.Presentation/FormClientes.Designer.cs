namespace App.Presentation
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
            cbItemsPorPagina = new ComboBox();
            txtPagina = new TextBox();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            txt6 = new Label();
            labelcontenedor = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txt4
            // 
            txt4.AutoSize = true;
            txt4.BackColor = Color.White;
            txt4.Location = new Point(34, 181);
            txt4.Name = "txt4";
            txt4.Size = new Size(55, 15);
            txt4.TabIndex = 59;
            txt4.Text = "Telefono:";
            // 
            // txt2
            // 
            txt2.AutoSize = true;
            txt2.BackColor = Color.White;
            txt2.Location = new Point(34, 137);
            txt2.Name = "txt2";
            txt2.Size = new Size(60, 15);
            txt2.TabIndex = 58;
            txt2.Text = "Direccion:";
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.BackColor = Color.White;
            txt1.Location = new Point(97, 114);
            txt1.Name = "txt1";
            txt1.Size = new Size(28, 15);
            txt1.TabIndex = 57;
            txt1.Text = "Dni:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(35, 199);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(210, 23);
            txtTel.TabIndex = 56;
            // 
            // txtDirec
            // 
            txtDirec.Location = new Point(35, 155);
            txtDirec.Name = "txtDirec";
            txtDirec.Size = new Size(210, 23);
            txtDirec.TabIndex = 55;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(35, 111);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(210, 23);
            txtDni.TabIndex = 54;
            // 
            // Texto5
            // 
            Texto5.BackColor = SystemColors.ActiveCaption;
            Texto5.BorderStyle = BorderStyle.FixedSingle;
            Texto5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Texto5.Location = new Point(-6, 23);
            Texto5.Name = "Texto5";
            Texto5.Size = new Size(291, 27);
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
            btnEliminar.Location = new Point(35, 429);
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
            btnEditar.Location = new Point(35, 400);
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
            btnAgregar.Location = new Point(35, 371);
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
            Text1.BackColor = Color.White;
            Text1.Location = new Point(35, 50);
            Text1.Name = "Text1";
            Text1.Size = new Size(54, 15);
            Text1.TabIndex = 49;
            Text1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 48;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 60;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(35, 284);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(210, 23);
            txtCiudad.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(34, 225);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 62;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(34, 266);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 63;
            label2.Text = "Ciudad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(34, 313);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 65;
            label3.Text = "Codigo Postal:";
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(35, 331);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(210, 23);
            txtCodPostal.TabIndex = 64;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(407, 61);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(618, 425);
            dgvClientes.TabIndex = 75;
            dgvClientes.CellContentDoubleClick += dgvClientes_CellContentDoubleClick;
            // 
            // cbItemsPorPagina
            // 
            cbItemsPorPagina.FormattingEnabled = true;
            cbItemsPorPagina.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "50" });
            cbItemsPorPagina.Location = new Point(867, 492);
            cbItemsPorPagina.Name = "cbItemsPorPagina";
            cbItemsPorPagina.Size = new Size(29, 23);
            cbItemsPorPagina.TabIndex = 74;
            cbItemsPorPagina.SelectedIndexChanged += cbItemsPorPagina_SelectedIndexChanged;
            // 
            // txtPagina
            // 
            txtPagina.BackColor = SystemColors.ActiveCaption;
            txtPagina.Location = new Point(780, 492);
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
            btnAnterior.Location = new Point(738, 492);
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
            btnSiguiente.Location = new Point(816, 492);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(34, 23);
            btnSiguiente.TabIndex = 71;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // txt6
            // 
            txt6.BackColor = Color.White;
            txt6.BorderStyle = BorderStyle.FixedSingle;
            txt6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt6.Location = new Point(407, 32);
            txt6.Name = "txt6";
            txt6.Size = new Size(227, 23);
            txt6.TabIndex = 70;
            txt6.Text = "Lista de Clientes";
            txt6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelcontenedor
            // 
            labelcontenedor.Anchor = AnchorStyles.None;
            labelcontenedor.BackColor = Color.White;
            labelcontenedor.BorderStyle = BorderStyle.FixedSingle;
            labelcontenedor.ImageAlign = ContentAlignment.MiddleLeft;
            labelcontenedor.Location = new Point(-46, 0);
            labelcontenedor.Name = "labelcontenedor";
            labelcontenedor.Size = new Size(291, 597);
            labelcontenedor.TabIndex = 47;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.MenuHighlight;
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton2.IconColor = SystemColors.ActiveCaptionText;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 24;
            iconButton2.Location = new Point(902, 32);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(31, 23);
            iconButton2.TabIndex = 92;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(682, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 91;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1128, 594);
            Controls.Add(iconButton2);
            Controls.Add(textBox1);
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
        private Label labelcontenedor;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox textBox1;
    }
}