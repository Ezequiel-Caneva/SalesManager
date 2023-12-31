﻿namespace App.Presentation
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            proveedorid = new DataGridViewTextBoxColumn();
            razonsocial = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            proveedorBindingSource = new BindingSource(components);
            txt6 = new Label();
            cbItemsPorPagina = new ComboBox();
            txtPagina = new TextBox();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelcontenedor
            // 
            labelcontenedor.BackColor = Color.FromArgb(40, 60, 90);
            labelcontenedor.BorderStyle = BorderStyle.FixedSingle;
            labelcontenedor.Dock = DockStyle.Left;
            labelcontenedor.Location = new Point(0, 0);
            labelcontenedor.Name = "labelcontenedor";
            labelcontenedor.Size = new Size(210, 619);
            labelcontenedor.TabIndex = 1;
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
            btnEliminar.Location = new Point(0, 324);
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
            btnEditar.Location = new Point(0, 295);
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
            btnAgregar.Location = new Point(0, 266);
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
            Text1.BackColor = Color.FromArgb(40, 60, 90);
            Text1.ForeColor = Color.White;
            Text1.Location = new Point(0, 67);
            Text1.Name = "Text1";
            Text1.Size = new Size(54, 15);
            Text1.TabIndex = 36;
            Text1.Text = "Nombre:";
            // 
            // txtNombreProv
            // 
            txtNombreProv.Location = new Point(0, 85);
            txtNombreProv.Name = "txtNombreProv";
            txtNombreProv.Size = new Size(210, 23);
            txtNombreProv.TabIndex = 35;
            // 
            // Texto5
            // 
            Texto5.BackColor = Color.FromArgb(45, 66, 91);
            Texto5.BorderStyle = BorderStyle.FixedSingle;
            Texto5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Texto5.ForeColor = Color.White;
            Texto5.Location = new Point(0, 25);
            Texto5.Name = "Texto5";
            Texto5.Size = new Size(210, 27);
            Texto5.TabIndex = 40;
            Texto5.Text = "Agregar Proveedor";
            Texto5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRzProv
            // 
            txtRzProv.Location = new Point(0, 127);
            txtRzProv.Name = "txtRzProv";
            txtRzProv.Size = new Size(210, 23);
            txtRzProv.TabIndex = 41;
            // 
            // txtDirecProv
            // 
            txtDirecProv.Location = new Point(0, 171);
            txtDirecProv.Name = "txtDirecProv";
            txtDirecProv.Size = new Size(210, 23);
            txtDirecProv.TabIndex = 42;
            // 
            // txtTelProv
            // 
            txtTelProv.Location = new Point(0, 215);
            txtTelProv.Name = "txtTelProv";
            txtTelProv.Size = new Size(210, 23);
            txtTelProv.TabIndex = 43;
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.BackColor = Color.FromArgb(40, 60, 90);
            txt1.ForeColor = Color.White;
            txt1.Location = new Point(0, 109);
            txt1.Name = "txt1";
            txt1.Size = new Size(76, 15);
            txt1.TabIndex = 44;
            txt1.Text = "Razon Social:";
            // 
            // txt2
            // 
            txt2.AutoSize = true;
            txt2.BackColor = Color.FromArgb(40, 60, 90);
            txt2.ForeColor = Color.White;
            txt2.Location = new Point(0, 153);
            txt2.Name = "txt2";
            txt2.Size = new Size(60, 15);
            txt2.TabIndex = 45;
            txt2.Text = "Direccion:";
            // 
            // txt4
            // 
            txt4.AutoSize = true;
            txt4.BackColor = Color.FromArgb(40, 60, 90);
            txt4.ForeColor = Color.White;
            txt4.Location = new Point(0, 197);
            txt4.Name = "txt4";
            txt4.Size = new Size(55, 15);
            txt4.TabIndex = 46;
            txt4.Text = "Telefono:";
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.AllowUserToResizeColumns = false;
            dgvProveedores.AutoGenerateColumns = false;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { proveedorid, razonsocial, nombre, telefono, direccion });
            dgvProveedores.DataSource = proveedorBindingSource;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.GridColor = Color.White;
            dgvProveedores.Location = new Point(215, 31);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProveedores.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvProveedores.RowTemplate.Height = 25;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(1034, 494);
            dgvProveedores.TabIndex = 47;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            // 
            // proveedorid
            // 
            proveedorid.DataPropertyName = "proveedorid";
            proveedorid.FillWeight = 126.903557F;
            proveedorid.HeaderText = "N° Proveedor";
            proveedorid.Name = "proveedorid";
            proveedorid.ReadOnly = true;
            // 
            // razonsocial
            // 
            razonsocial.DataPropertyName = "razonsocial";
            razonsocial.FillWeight = 93.27411F;
            razonsocial.HeaderText = "Razon social";
            razonsocial.Name = "razonsocial";
            razonsocial.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.FillWeight = 93.27411F;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.FillWeight = 93.27411F;
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.DataPropertyName = "direccion";
            direccion.FillWeight = 93.27411F;
            direccion.HeaderText = "Direccion";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // proveedorBindingSource
            // 
            proveedorBindingSource.DataSource = typeof(Entities.Proveedor);
            // 
            // txt6
            // 
            txt6.BackColor = Color.FromArgb(45, 66, 91);
            txt6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt6.ForeColor = Color.White;
            txt6.Location = new Point(215, 2);
            txt6.Name = "txt6";
            txt6.Size = new Size(193, 23);
            txt6.TabIndex = 48;
            txt6.Text = "Lista de Proveedores";
            txt6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbItemsPorPagina
            // 
            cbItemsPorPagina.FormattingEnabled = true;
            cbItemsPorPagina.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "50" });
            cbItemsPorPagina.Location = new Point(1221, 528);
            cbItemsPorPagina.Name = "cbItemsPorPagina";
            cbItemsPorPagina.Size = new Size(29, 23);
            cbItemsPorPagina.TabIndex = 52;
            cbItemsPorPagina.SelectedIndexChanged += cbItemsPorPagina_SelectedIndexChanged;
            // 
            // txtPagina
            // 
            txtPagina.BackColor = SystemColors.ActiveCaption;
            txtPagina.Location = new Point(1145, 528);
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
            btnAnterior.Location = new Point(1103, 528);
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
            btnSiguiente.Location = new Point(1181, 528);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(34, 23);
            btnSiguiente.TabIndex = 49;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(45, 66, 91);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 24;
            btnBuscar.Location = new Point(1218, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(31, 23);
            btnBuscar.TabIndex = 92;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(1002, 6);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(214, 23);
            txtBuscar.TabIndex = 91;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1254, 619);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
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
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).EndInit();
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
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBuscar;
        private BindingSource proveedorBindingSource;
        private DataGridViewTextBoxColumn proveedorid;
        private DataGridViewTextBoxColumn razonsocial;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn direccion;
    }
}