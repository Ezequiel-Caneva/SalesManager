namespace App.Presentation
{
    partial class FormStock
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
            labelcontenedor = new Label();
            txtNombreProducto = new TextBox();
            txtCantidadProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            Texto1 = new Label();
            Texto2 = new Label();
            Texto3 = new Label();
            Texto4 = new Label();
            Texto5 = new Label();
            Texto6 = new Label();
            btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            btnEditarProducto = new FontAwesome.Sharp.IconButton();
            btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            dgvProducto = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            cbRubro = new ComboBox();
            Texto7 = new Label();
            Texto8 = new Label();
            Texto9 = new Label();
            textBox4 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            cbBuscarRubro = new ComboBox();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            txtPagina = new TextBox();
            cbItemsPorPagina = new ComboBox();
            productoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelcontenedor
            // 
            labelcontenedor.BackColor = Color.White;
            labelcontenedor.BorderStyle = BorderStyle.FixedSingle;
            labelcontenedor.Dock = DockStyle.Left;
            labelcontenedor.Location = new Point(0, 0);
            labelcontenedor.Name = "labelcontenedor";
            labelcontenedor.Size = new Size(213, 622);
            labelcontenedor.TabIndex = 0;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(27, 229);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(146, 23);
            txtNombreProducto.TabIndex = 1;
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Location = new Point(27, 273);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(146, 23);
            txtCantidadProducto.TabIndex = 2;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(27, 317);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(146, 23);
            txtPrecioProducto.TabIndex = 3;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(27, 361);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(146, 23);
            txtCodigoProducto.TabIndex = 5;
            // 
            // Texto1
            // 
            Texto1.AutoSize = true;
            Texto1.BackColor = Color.White;
            Texto1.Location = new Point(27, 211);
            Texto1.Name = "Texto1";
            Texto1.Size = new Size(125, 15);
            Texto1.TabIndex = 6;
            Texto1.Text = "Nombre del Producto:";
            // 
            // Texto2
            // 
            Texto2.AutoSize = true;
            Texto2.BackColor = Color.White;
            Texto2.Location = new Point(27, 255);
            Texto2.Name = "Texto2";
            Texto2.Size = new Size(58, 15);
            Texto2.TabIndex = 7;
            Texto2.Text = "Cantidad:";
            // 
            // Texto3
            // 
            Texto3.AutoSize = true;
            Texto3.BackColor = Color.White;
            Texto3.Location = new Point(27, 299);
            Texto3.Name = "Texto3";
            Texto3.Size = new Size(91, 15);
            Texto3.TabIndex = 8;
            Texto3.Text = "Precio de venta:";
            // 
            // Texto4
            // 
            Texto4.AutoSize = true;
            Texto4.BackColor = Color.White;
            Texto4.Location = new Point(27, 387);
            Texto4.Name = "Texto4";
            Texto4.Size = new Size(42, 15);
            Texto4.TabIndex = 9;
            Texto4.Text = "Rubro:";
            // 
            // Texto5
            // 
            Texto5.AutoSize = true;
            Texto5.BackColor = Color.White;
            Texto5.Location = new Point(27, 343);
            Texto5.Name = "Texto5";
            Texto5.Size = new Size(49, 15);
            Texto5.TabIndex = 10;
            Texto5.Text = "Codigo:";
            // 
            // Texto6
            // 
            Texto6.BackColor = SystemColors.ButtonFace;
            Texto6.BorderStyle = BorderStyle.FixedSingle;
            Texto6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Texto6.Location = new Point(0, 172);
            Texto6.Name = "Texto6";
            Texto6.Size = new Size(213, 27);
            Texto6.TabIndex = 11;
            Texto6.Text = "Agregar Producto";
            Texto6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.ForestGreen;
            btnAgregarProducto.Cursor = Cursors.Hand;
            btnAgregarProducto.FlatAppearance.BorderColor = Color.Black;
            btnAgregarProducto.FlatStyle = FlatStyle.Popup;
            btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnAgregarProducto.IconColor = Color.Black;
            btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarProducto.IconSize = 16;
            btnAgregarProducto.Location = new Point(27, 445);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(146, 23);
            btnAgregarProducto.TabIndex = 12;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.BackColor = Color.DodgerBlue;
            btnEditarProducto.Cursor = Cursors.Hand;
            btnEditarProducto.FlatAppearance.BorderColor = Color.Black;
            btnEditarProducto.FlatStyle = FlatStyle.Popup;
            btnEditarProducto.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnEditarProducto.IconColor = Color.Black;
            btnEditarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarProducto.IconSize = 16;
            btnEditarProducto.Location = new Point(27, 474);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(146, 23);
            btnEditarProducto.TabIndex = 13;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnEditarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarProducto.UseVisualStyleBackColor = false;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Red;
            btnEliminarProducto.Cursor = Cursors.Hand;
            btnEliminarProducto.FlatAppearance.BorderColor = Color.Black;
            btnEliminarProducto.FlatStyle = FlatStyle.Popup;
            btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarProducto.IconColor = Color.Black;
            btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarProducto.IconSize = 16;
            btnEliminarProducto.Location = new Point(27, 503);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(146, 23);
            btnEliminarProducto.TabIndex = 14;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToDeleteRows = false;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProducto.BackgroundColor = Color.White;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar });
            dgvProducto.Location = new Point(256, 48);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dgvProducto.RowTemplate.Height = 25;
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducto.Size = new Size(577, 478);
            dgvProducto.TabIndex = 15;
            dgvProducto.CellContentDoubleClick += dgvProducto_CellContentDoubleClick;
            dgvProducto.CellEndEdit += dgvProducto_CellEndEdit;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 21;
            // 
            // cbRubro
            // 
            cbRubro.FormattingEnabled = true;
            cbRubro.Location = new Point(27, 405);
            cbRubro.Name = "cbRubro";
            cbRubro.Size = new Size(146, 23);
            cbRubro.TabIndex = 16;
            // 
            // Texto7
            // 
            Texto7.BackColor = SystemColors.ButtonFace;
            Texto7.BorderStyle = BorderStyle.FixedSingle;
            Texto7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Texto7.Location = new Point(0, 9);
            Texto7.Name = "Texto7";
            Texto7.Size = new Size(213, 27);
            Texto7.TabIndex = 17;
            Texto7.Text = "Buscar Producto";
            Texto7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Texto8
            // 
            Texto8.AutoSize = true;
            Texto8.BackColor = Color.White;
            Texto8.Location = new Point(27, 41);
            Texto8.Name = "Texto8";
            Texto8.Size = new Size(33, 15);
            Texto8.TabIndex = 20;
            Texto8.Text = "Tipo:";
            // 
            // Texto9
            // 
            Texto9.AutoSize = true;
            Texto9.BackColor = Color.White;
            Texto9.Location = new Point(27, 85);
            Texto9.Name = "Texto9";
            Texto9.Size = new Size(42, 15);
            Texto9.TabIndex = 21;
            Texto9.Text = "Rubro:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(27, 59);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 23);
            textBox4.TabIndex = 18;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.DodgerBlue;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 16;
            iconButton1.Location = new Point(27, 132);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(146, 23);
            iconButton1.TabIndex = 22;
            iconButton1.Text = "Buscar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(256, 13);
            label1.Name = "label1";
            label1.Size = new Size(149, 23);
            label1.TabIndex = 25;
            label1.Text = "Lista de Productos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbBuscarRubro
            // 
            cbBuscarRubro.FormattingEnabled = true;
            cbBuscarRubro.Location = new Point(27, 103);
            cbBuscarRubro.Name = "cbBuscarRubro";
            cbBuscarRubro.Size = new Size(146, 23);
            cbBuscarRubro.TabIndex = 26;
            // 
            // btnSiguiente
            // 
            btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.MailForward;
            btnSiguiente.IconColor = Color.Black;
            btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSiguiente.IconSize = 20;
            btnSiguiente.Location = new Point(690, 532);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(34, 23);
            btnSiguiente.TabIndex = 27;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.AccessibleDescription = "";
            btnAnterior.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            btnAnterior.IconColor = Color.Black;
            btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnterior.IconSize = 20;
            btnAnterior.Location = new Point(612, 532);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(36, 23);
            btnAnterior.TabIndex = 28;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // txtPagina
            // 
            txtPagina.BackColor = SystemColors.ActiveCaption;
            txtPagina.Location = new Point(654, 532);
            txtPagina.Name = "txtPagina";
            txtPagina.Size = new Size(30, 23);
            txtPagina.TabIndex = 29;
            txtPagina.TextChanged += txtPagina_TextChanged;
            // 
            // cbItemsPorPagina
            // 
            cbItemsPorPagina.FormattingEnabled = true;
            cbItemsPorPagina.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "50" });
            cbItemsPorPagina.Location = new Point(744, 532);
            cbItemsPorPagina.Name = "cbItemsPorPagina";
            cbItemsPorPagina.Size = new Size(29, 23);
            cbItemsPorPagina.TabIndex = 30;
            cbItemsPorPagina.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Entities.Producto);
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1075, 622);
            Controls.Add(cbItemsPorPagina);
            Controls.Add(txtPagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(cbBuscarRubro);
            Controls.Add(label1);
            Controls.Add(iconButton1);
            Controls.Add(Texto9);
            Controls.Add(Texto8);
            Controls.Add(textBox4);
            Controls.Add(Texto7);
            Controls.Add(cbRubro);
            Controls.Add(dgvProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(Texto6);
            Controls.Add(Texto5);
            Controls.Add(Texto4);
            Controls.Add(Texto3);
            Controls.Add(Texto2);
            Controls.Add(Texto1);
            Controls.Add(txtCodigoProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(txtCantidadProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(labelcontenedor);
            Name = "FormStock";
            Text = "FormStock";
            Load += FormStock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelcontenedor;
        private TextBox txtNombreProducto;
        private TextBox txtCantidadProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtCodigoProducto;
        private Label Texto1;
        private Label Texto2;
        private Label Texto3;
        private Label Texto4;
        private Label Texto5;
        private Label Texto6;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private FontAwesome.Sharp.IconButton btnEditarProducto;
        private FontAwesome.Sharp.IconButton btnEliminarProducto;
        private DataGridView dgvProducto;
        private ComboBox cbRubro;
        private Label Texto7;
        private Label Texto8;
        private Label Texto9;
        private TextBox textBox4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private ComboBox cbBuscarRubro;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private TextBox txtPagina;
        private ComboBox cbItemsPorPagina;
        private BindingSource productoBindingSource;
        private DataGridViewButtonColumn btnSeleccionar;
    }
}