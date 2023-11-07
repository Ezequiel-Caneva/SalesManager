namespace App.Presentation
{
    partial class FormCompras
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txt4 = new Label();
            txt3 = new Label();
            txt1 = new Label();
            txtPrecioComp = new TextBox();
            txtCantidad = new TextBox();
            Texto5 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            labelcontenedor = new Label();
            label1 = new Label();
            cbProducto = new ComboBox();
            CbProveedor = new ComboBox();
            cbItemsPorPagina = new ComboBox();
            txtPagina = new TextBox();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            txt6 = new Label();
            dgvCompras = new DataGridView();
            productoid = new DataGridViewTextBoxColumn();
            nombreproducto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            preciocompra = new DataGridViewTextBoxColumn();
            proveedorid = new DataGridViewTextBoxColumn();
            proveedor = new DataGridViewTextBoxColumn();
            detalleCompraBindingSource = new BindingSource(components);
            cbRubro = new ComboBox();
            txt7 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detalleCompraBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txt4
            // 
            txt4.AutoSize = true;
            txt4.BackColor = Color.FromArgb(40, 60, 90);
            txt4.ForeColor = Color.White;
            txt4.Location = new Point(0, 247);
            txt4.Name = "txt4";
            txt4.Size = new Size(64, 15);
            txt4.TabIndex = 59;
            txt4.Text = "Proveedor:";
            // 
            // txt3
            // 
            txt3.AutoSize = true;
            txt3.BackColor = Color.FromArgb(40, 60, 90);
            txt3.ForeColor = Color.White;
            txt3.Location = new Point(-1, 203);
            txt3.Name = "txt3";
            txt3.Size = new Size(105, 15);
            txt3.TabIndex = 58;
            txt3.Text = "Precio de Compra:";
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.BackColor = Color.FromArgb(40, 60, 90);
            txt1.ForeColor = Color.WhiteSmoke;
            txt1.Location = new Point(-1, 159);
            txt1.Name = "txt1";
            txt1.Size = new Size(58, 15);
            txt1.TabIndex = 57;
            txt1.Text = "Cantidad:";
            // 
            // txtPrecioComp
            // 
            txtPrecioComp.Location = new Point(1, 221);
            txtPrecioComp.Name = "txtPrecioComp";
            txtPrecioComp.Size = new Size(209, 23);
            txtPrecioComp.TabIndex = 55;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(1, 177);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(209, 23);
            txtCantidad.TabIndex = 54;
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
            Texto5.Text = "Cargar Compras";
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
            btnEliminar.Location = new Point(0, 367);
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
            btnEditar.Location = new Point(0, 338);
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
            btnAgregar.Location = new Point(0, 309);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(210, 23);
            btnAgregar.TabIndex = 50;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // labelcontenedor
            // 
            labelcontenedor.BackColor = Color.FromArgb(40, 60, 90);
            labelcontenedor.BorderStyle = BorderStyle.FixedSingle;
            labelcontenedor.Dock = DockStyle.Left;
            labelcontenedor.Location = new Point(0, 0);
            labelcontenedor.Name = "labelcontenedor";
            labelcontenedor.Size = new Size(211, 594);
            labelcontenedor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 60, 90);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-2, 115);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 60;
            label1.Text = "Producto:";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(0, 133);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(210, 23);
            cbProducto.TabIndex = 62;
            // 
            // CbProveedor
            // 
            CbProveedor.FormattingEnabled = true;
            CbProveedor.Location = new Point(-1, 265);
            CbProveedor.Name = "CbProveedor";
            CbProveedor.Size = new Size(210, 23);
            CbProveedor.TabIndex = 63;
            // 
            // cbItemsPorPagina
            // 
            cbItemsPorPagina.FormattingEnabled = true;
            cbItemsPorPagina.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "50" });
            cbItemsPorPagina.Location = new Point(1218, 542);
            cbItemsPorPagina.Name = "cbItemsPorPagina";
            cbItemsPorPagina.Size = new Size(31, 23);
            cbItemsPorPagina.TabIndex = 68;
            cbItemsPorPagina.SelectedIndexChanged += cbItemsPorPagina_SelectedIndexChanged;
            // 
            // txtPagina
            // 
            txtPagina.BackColor = SystemColors.ActiveCaption;
            txtPagina.BorderStyle = BorderStyle.FixedSingle;
            txtPagina.Location = new Point(1138, 543);
            txtPagina.Name = "txtPagina";
            txtPagina.Size = new Size(32, 23);
            txtPagina.TabIndex = 67;
            txtPagina.TextChanged += txtPagina_TextChanged;
            // 
            // btnAnterior
            // 
            btnAnterior.AccessibleDescription = "";
            btnAnterior.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            btnAnterior.IconColor = Color.Black;
            btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnterior.IconSize = 20;
            btnAnterior.Location = new Point(1094, 542);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(38, 23);
            btnAnterior.TabIndex = 66;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.MailForward;
            btnSiguiente.IconColor = Color.Black;
            btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSiguiente.IconSize = 20;
            btnSiguiente.Location = new Point(1176, 542);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(36, 23);
            btnSiguiente.TabIndex = 65;
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
            txt6.Size = new Size(163, 23);
            txt6.TabIndex = 64;
            txt6.Text = "Lista de Compras";
            txt6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.AllowUserToResizeColumns = false;
            dgvCompras.AllowUserToResizeRows = false;
            dgvCompras.AutoGenerateColumns = false;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvCompras.BorderStyle = BorderStyle.None;
            dgvCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { productoid, nombreproducto, cantidad, preciocompra, proveedorid, proveedor });
            dgvCompras.DataSource = detalleCompraBindingSource;
            dgvCompras.EnableHeadersVisualStyles = false;
            dgvCompras.GridColor = Color.White;
            dgvCompras.Location = new Point(215, 31);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvCompras.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCompras.RowTemplate.Height = 25;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.Size = new Size(1034, 494);
            dgvCompras.TabIndex = 69;
            dgvCompras.CellContentClick += dgvCompras_CellContentClick;
            dgvCompras.CellContentDoubleClick += dgvCompras_CellContentDoubleClick;
            // 
            // productoid
            // 
            productoid.DataPropertyName = "productoid";
            productoid.HeaderText = "N° Producto";
            productoid.Name = "productoid";
            productoid.ReadOnly = true;
            // 
            // nombreproducto
            // 
            nombreproducto.DataPropertyName = "nombreproducto";
            nombreproducto.HeaderText = "Nombre Producto";
            nombreproducto.Name = "nombreproducto";
            nombreproducto.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "cantidad";
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            // 
            // preciocompra
            // 
            preciocompra.DataPropertyName = "preciocompra";
            preciocompra.HeaderText = "Precio de Compra";
            preciocompra.Name = "preciocompra";
            preciocompra.ReadOnly = true;
            // 
            // proveedorid
            // 
            proveedorid.DataPropertyName = "proveedorid";
            proveedorid.HeaderText = "N° Proveedor";
            proveedorid.Name = "proveedorid";
            proveedorid.ReadOnly = true;
            // 
            // proveedor
            // 
            proveedor.DataPropertyName = "proveedor";
            proveedor.HeaderText = "Proveedor";
            proveedor.Name = "proveedor";
            proveedor.ReadOnly = true;
            // 
            // detalleCompraBindingSource
            // 
            detalleCompraBindingSource.DataSource = typeof(Entities.DetalleCompra);
            // 
            // cbRubro
            // 
            cbRubro.FormattingEnabled = true;
            cbRubro.Location = new Point(0, 89);
            cbRubro.Name = "cbRubro";
            cbRubro.Size = new Size(210, 23);
            cbRubro.TabIndex = 63;
            cbRubro.SelectedIndexChanged += cbRubro_SelectedIndexChanged;
            // 
            // txt7
            // 
            txt7.AutoSize = true;
            txt7.BackColor = Color.FromArgb(40, 60, 90);
            txt7.ForeColor = Color.White;
            txt7.Location = new Point(0, 71);
            txt7.Name = "txt7";
            txt7.Size = new Size(42, 15);
            txt7.TabIndex = 70;
            txt7.Text = "Rubro:";
            // 
            // iconButton2
            // 
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 24;
            iconButton2.Location = new Point(1218, 6);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(33, 23);
            iconButton2.TabIndex = 92;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(1002, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 91;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1285, 594);
            Controls.Add(iconButton2);
            Controls.Add(textBox1);
            Controls.Add(txt7);
            Controls.Add(dgvCompras);
            Controls.Add(cbItemsPorPagina);
            Controls.Add(txtPagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(txt6);
            Controls.Add(cbRubro);
            Controls.Add(CbProveedor);
            Controls.Add(cbProducto);
            Controls.Add(label1);
            Controls.Add(txt4);
            Controls.Add(txt3);
            Controls.Add(txt1);
            Controls.Add(txtPrecioComp);
            Controls.Add(txtCantidad);
            Controls.Add(Texto5);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(labelcontenedor);
            Name = "FormCompras";
            Text = "FormCompras";
            Load += FormCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)detalleCompraBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt4;
        private Label txt3;
        private Label txt1;
        private TextBox txtPrecioComp;
        private TextBox txtCantidad;
        private Label Texto5;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Label labelcontenedor;
        private Label label1;
        private ComboBox cbProducto;
        private ComboBox CbProveedor;
        private ComboBox cbItemsPorPagina;
        private TextBox txtPagina;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private Label txt6;
        private DataGridView dgvCompras;
        private ComboBox cbRubro;
        private Label txt7;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox textBox1;
        private BindingSource detalleCompraBindingSource;
        private DataGridViewTextBoxColumn productoid;
        private DataGridViewTextBoxColumn nombreproducto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn preciocompra;
        private DataGridViewTextBoxColumn proveedorid;
        private DataGridViewTextBoxColumn proveedor;
    }
}