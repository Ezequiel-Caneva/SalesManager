namespace App.Presentation
{
    partial class FormProveedores
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
            labelcontenedor = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            Text1 = new Label();
            txtNombreProv = new TextBox();
            Texto5 = new Label();
            txtRzProv = new TextBox();
            txtDirecProv = new TextBox();
            txtTelProv = new TextBox();
            txt1 = new Label();
            txt2 = new Label();
            txt4 = new Label();
            dgvProveedores = new DataGridView();
            txt6 = new Label();
            cbItemsPorPagina = new ComboBox();
            txtPagina = new TextBox();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // labelcontenedor
            // 
            labelcontenedor.BackColor = Color.White;
            labelcontenedor.BorderStyle = BorderStyle.FixedSingle;
            labelcontenedor.Dock = DockStyle.Left;
            labelcontenedor.Location = new Point(0, 0);
            labelcontenedor.Name = "labelcontenedor";
            labelcontenedor.Size = new Size(291, 619);
            labelcontenedor.TabIndex = 1;
            labelcontenedor.Click += labelcontenedor_Click;
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
            btnEliminar.Location = new Point(22, 326);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(210, 23);
            btnEliminar.TabIndex = 39;
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
            btnEditar.Location = new Point(22, 297);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(210, 23);
            btnEditar.TabIndex = 38;
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
            btnAgregar.Location = new Point(22, 268);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(210, 23);
            btnAgregar.TabIndex = 37;
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
            Text1.Location = new Point(23, 67);
            Text1.Name = "Text1";
            Text1.Size = new Size(54, 15);
            Text1.TabIndex = 36;
            Text1.Text = "Nombre:";
            Text1.Click += Text1_Click;
            // 
            // txtNombreProv
            // 
            txtNombreProv.Location = new Point(22, 85);
            txtNombreProv.Name = "txtNombreProv";
            txtNombreProv.Size = new Size(210, 23);
            txtNombreProv.TabIndex = 35;
            txtNombreProv.TextChanged += txtNombreProv_TextChanged;
            // 
            // Texto5
            // 
            Texto5.BackColor = SystemColors.ButtonFace;
            Texto5.BorderStyle = BorderStyle.FixedSingle;
            Texto5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Texto5.Location = new Point(0, 20);
            Texto5.Name = "Texto5";
            Texto5.Size = new Size(213, 27);
            Texto5.TabIndex = 40;
            Texto5.Text = "Agregar Proveedor";
            Texto5.TextAlign = ContentAlignment.MiddleCenter;
            Texto5.Click += Texto5_Click;
            // 
            // txtRzProv
            // 
            txtRzProv.Location = new Point(22, 129);
            txtRzProv.Name = "txtRzProv";
            txtRzProv.Size = new Size(210, 23);
            txtRzProv.TabIndex = 41;
            txtRzProv.TextChanged += txtRzProv_TextChanged;
            // 
            // txtDirecProv
            // 
            txtDirecProv.Location = new Point(22, 173);
            txtDirecProv.Name = "txtDirecProv";
            txtDirecProv.Size = new Size(210, 23);
            txtDirecProv.TabIndex = 42;
            txtDirecProv.TextChanged += txtDirecProv_TextChanged;
            // 
            // txtTelProv
            // 
            txtTelProv.Location = new Point(22, 217);
            txtTelProv.Name = "txtTelProv";
            txtTelProv.Size = new Size(210, 23);
            txtTelProv.TabIndex = 43;
            txtTelProv.TextChanged += txtTelProv_TextChanged;
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.BackColor = Color.White;
            txt1.Location = new Point(22, 111);
            txt1.Name = "txt1";
            txt1.Size = new Size(76, 15);
            txt1.TabIndex = 44;
            txt1.Text = "Razon Social:";
            txt1.Click += txt1_Click;
            // 
            // txt2
            // 
            txt2.AutoSize = true;
            txt2.BackColor = Color.White;
            txt2.Location = new Point(22, 155);
            txt2.Name = "txt2";
            txt2.Size = new Size(60, 15);
            txt2.TabIndex = 45;
            txt2.Text = "Direccion:";
            txt2.Click += txt2_Click;
            // 
            // txt4
            // 
            txt4.AutoSize = true;
            txt4.BackColor = Color.White;
            txt4.Location = new Point(22, 199);
            txt4.Name = "txt4";
            txt4.Size = new Size(55, 15);
            txt4.TabIndex = 46;
            txt4.Text = "Telefono:";
            txt4.Click += txt4_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(329, 67);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowTemplate.Height = 25;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(577, 425);
            dgvProveedores.TabIndex = 47;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            dgvProveedores.CellContentDoubleClick += dgvProveedores_CellContentDoubleClick;
            // 
            // txt6
            // 
            txt6.BackColor = Color.White;
            txt6.BorderStyle = BorderStyle.FixedSingle;
            txt6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt6.Location = new Point(329, 24);
            txt6.Name = "txt6";
            txt6.Size = new Size(227, 23);
            txt6.TabIndex = 48;
            txt6.Text = "Lista de Proveedores";
            txt6.TextAlign = ContentAlignment.MiddleCenter;
            txt6.Click += txt6_Click;
            // 
            // cbItemsPorPagina
            // 
            cbItemsPorPagina.FormattingEnabled = true;
            cbItemsPorPagina.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "50" });
            cbItemsPorPagina.Location = new Point(877, 498);
            cbItemsPorPagina.Name = "cbItemsPorPagina";
            cbItemsPorPagina.Size = new Size(29, 23);
            cbItemsPorPagina.TabIndex = 52;
            cbItemsPorPagina.SelectedIndexChanged += cbItemsPorPagina_SelectedIndexChanged;
            // 
            // txtPagina
            // 
            txtPagina.BackColor = SystemColors.ActiveCaption;
            txtPagina.Location = new Point(783, 498);
            txtPagina.Name = "txtPagina";
            txtPagina.Size = new Size(30, 23);
            txtPagina.TabIndex = 51;
            txtPagina.TextChanged += txtPagina_TextChanged;
            // 
            // btnAnterior
            // 
            btnAnterior.AccessibleDescription = "";
            btnAnterior.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            btnAnterior.IconColor = Color.Black;
            btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnterior.IconSize = 20;
            btnAnterior.Location = new Point(741, 498);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(36, 23);
            btnAnterior.TabIndex = 50;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.MailForward;
            btnSiguiente.IconColor = Color.Black;
            btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSiguiente.IconSize = 20;
            btnSiguiente.Location = new Point(819, 498);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(34, 23);
            btnSiguiente.TabIndex = 49;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1040, 619);
            Controls.Add(cbItemsPorPagina);
            Controls.Add(txtPagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(txt6);
            Controls.Add(dgvProveedores);
            Controls.Add(txt4);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(txtTelProv);
            Controls.Add(txtDirecProv);
            Controls.Add(txtRzProv);
            Controls.Add(Texto5);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(Text1);
            Controls.Add(txtNombreProv);
            Controls.Add(labelcontenedor);
            Name = "FormProveedores";
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelcontenedor;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Label Text1;
        private TextBox txtNombreProv;
        private Label Texto5;
        private TextBox txtRzProv;
        private TextBox txtDirecProv;
        private TextBox txtTelProv;
        private Label txt1;
        private Label txt2;
        private Label txt4;
        private DataGridView dgvProveedores;
        private Label txt6;
        private ComboBox cbItemsPorPagina;
        private TextBox txtPagina;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private FontAwesome.Sharp.IconButton btnSiguiente;
    }
}