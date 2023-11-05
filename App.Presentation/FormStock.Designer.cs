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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            cbRubro = new ComboBox();
            Texto7 = new Label();
            Texto8 = new Label();
            txtCategoria = new TextBox();
            label1 = new Label();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            txtPagina = new TextBox();
            cbItemsPorPagina = new ComboBox();
            productoBindingSource = new BindingSource(components);
            btnEliminarRubro = new FontAwesome.Sharp.IconButton();
            btnEditarRubro = new FontAwesome.Sharp.IconButton();
            btnAgregarRubro = new FontAwesome.Sharp.IconButton();
            btnMostrarProductos = new FontAwesome.Sharp.IconButton();
            btnMostrarRubros = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelcontenedor
            // 
            labelcontenedor.BackColor = Color.FromArgb(40, 60, 90);
            labelcontenedor.BorderStyle = BorderStyle.FixedSingle;
            labelcontenedor.Dock = DockStyle.Left;
            labelcontenedor.Location = new Point(0, 0);
            labelcontenedor.Name = "labelcontenedor";
            labelcontenedor.Size = new Size(291, 622);
            labelcontenedor.TabIndex = 0;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(39, 247);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(216, 23);
            txtNombreProducto.TabIndex = 1;
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Location = new Point(39, 291);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(216, 23);
            txtCantidadProducto.TabIndex = 2;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(39, 335);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(216, 23);
            txtPrecioProducto.TabIndex = 3;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(39, 379);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(216, 23);
            txtCodigoProducto.TabIndex = 5;
            // 
            // Texto1
            // 
            Texto1.AutoSize = true;
            Texto1.BackColor = Color.FromArgb(40, 60, 90);
            Texto1.ForeColor = Color.White;
            Texto1.Location = new Point(39, 229);
            Texto1.Name = "Texto1";
            Texto1.Size = new Size(125, 15);
            Texto1.TabIndex = 6;
            Texto1.Text = "Nombre del Producto:";
            // 
            // Texto2
            // 
            Texto2.AutoSize = true;
            Texto2.BackColor = Color.FromArgb(40, 60, 90);
            Texto2.ForeColor = Color.White;
            Texto2.Location = new Point(39, 273);
            Texto2.Name = "Texto2";
            Texto2.Size = new Size(58, 15);
            Texto2.TabIndex = 7;
            Texto2.Text = "Cantidad:";
            // 
            // Texto3
            // 
            Texto3.AutoSize = true;
            Texto3.BackColor = Color.FromArgb(40, 60, 90);
            Texto3.ForeColor = Color.White;
            Texto3.Location = new Point(39, 317);
            Texto3.Name = "Texto3";
            Texto3.Size = new Size(91, 15);
            Texto3.TabIndex = 8;
            Texto3.Text = "Precio de venta:";
            // 
            // Texto4
            // 
            Texto4.AutoSize = true;
            Texto4.BackColor = Color.FromArgb(40, 60, 90);
            Texto4.ForeColor = Color.White;
            Texto4.Location = new Point(39, 405);
            Texto4.Name = "Texto4";
            Texto4.Size = new Size(42, 15);
            Texto4.TabIndex = 9;
            Texto4.Text = "Rubro:";
            // 
            // Texto5
            // 
            Texto5.AutoSize = true;
            Texto5.BackColor = Color.FromArgb(40, 60, 90);
            Texto5.ForeColor = Color.White;
            Texto5.Location = new Point(39, 361);
            Texto5.Name = "Texto5";
            Texto5.Size = new Size(49, 15);
            Texto5.TabIndex = 10;
            Texto5.Text = "Codigo:";
            // 
            // Texto6
            // 
            Texto6.BackColor = Color.FromArgb(45, 66, 91);
            Texto6.BorderStyle = BorderStyle.FixedSingle;
            Texto6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Texto6.ForeColor = Color.White;
            Texto6.Location = new Point(0, 196);
            Texto6.Name = "Texto6";
            Texto6.Size = new Size(291, 27);
            Texto6.TabIndex = 11;
            Texto6.Text = "Gestionar Producto";
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
            btnAgregarProducto.Location = new Point(39, 461);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(216, 23);
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
            btnEditarProducto.Location = new Point(39, 490);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(216, 23);
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
            btnEliminarProducto.Location = new Point(39, 519);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(216, 23);
            btnEliminarProducto.TabIndex = 14;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToDeleteRows = false;
            dgvProducto.AllowUserToResizeColumns = false;
            dgvProducto.AllowUserToResizeRows = false;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProducto.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvProducto.BorderStyle = BorderStyle.None;
            dgvProducto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.EnableHeadersVisualStyles = false;
            dgvProducto.GridColor = Color.SteelBlue;
            dgvProducto.Location = new Point(349, 63);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dgvProducto.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvProducto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducto.RowTemplate.Height = 25;
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducto.Size = new Size(795, 478);
            dgvProducto.TabIndex = 15;
            dgvProducto.CellContentClick += dgvProducto_CellContentClick;
            // 
            // cbRubro
            // 
            cbRubro.FormattingEnabled = true;
            cbRubro.Location = new Point(39, 423);
            cbRubro.Name = "cbRubro";
            cbRubro.Size = new Size(216, 23);
            cbRubro.TabIndex = 16;
            // 
            // Texto7
            // 
            Texto7.BackColor = Color.FromArgb(45, 66, 91);
            Texto7.BorderStyle = BorderStyle.FixedSingle;
            Texto7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Texto7.ForeColor = Color.White;
            Texto7.Location = new Point(0, 25);
            Texto7.Name = "Texto7";
            Texto7.Size = new Size(291, 27);
            Texto7.TabIndex = 17;
            Texto7.Text = "Gestionar Rubro";
            Texto7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Texto8
            // 
            Texto8.AutoSize = true;
            Texto8.BackColor = Color.FromArgb(40, 60, 90);
            Texto8.ForeColor = Color.White;
            Texto8.Location = new Point(39, 58);
            Texto8.Name = "Texto8";
            Texto8.Size = new Size(61, 15);
            Texto8.TabIndex = 20;
            Texto8.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(39, 77);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(216, 23);
            txtCategoria.TabIndex = 18;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(45, 66, 91);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(349, 37);
            label1.Name = "label1";
            label1.Size = new Size(149, 23);
            label1.TabIndex = 25;
            label1.Text = "Lista de Productos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSiguiente
            // 
            btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.MailForward;
            btnSiguiente.IconColor = Color.Black;
            btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSiguiente.IconSize = 20;
            btnSiguiente.Location = new Point(918, 546);
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
            btnAnterior.Location = new Point(840, 545);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(36, 23);
            btnAnterior.TabIndex = 28;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // txtPagina
            // 
            txtPagina.BackColor = SystemColors.ActiveCaption;
            txtPagina.Location = new Point(882, 546);
            txtPagina.Name = "txtPagina";
            txtPagina.Size = new Size(30, 23);
            txtPagina.TabIndex = 29;
            txtPagina.TextChanged += txtPagina_TextChanged;
            // 
            // cbItemsPorPagina
            // 
            cbItemsPorPagina.FormattingEnabled = true;
            cbItemsPorPagina.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "50" });
            cbItemsPorPagina.Location = new Point(972, 547);
            cbItemsPorPagina.Name = "cbItemsPorPagina";
            cbItemsPorPagina.Size = new Size(29, 23);
            cbItemsPorPagina.TabIndex = 30;
            cbItemsPorPagina.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Entities.Producto);
            // 
            // btnEliminarRubro
            // 
            btnEliminarRubro.BackColor = Color.Red;
            btnEliminarRubro.Cursor = Cursors.Hand;
            btnEliminarRubro.FlatAppearance.BorderColor = Color.Black;
            btnEliminarRubro.FlatStyle = FlatStyle.Popup;
            btnEliminarRubro.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarRubro.IconColor = Color.Black;
            btnEliminarRubro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarRubro.IconSize = 16;
            btnEliminarRubro.Location = new Point(39, 164);
            btnEliminarRubro.Name = "btnEliminarRubro";
            btnEliminarRubro.Size = new Size(216, 23);
            btnEliminarRubro.TabIndex = 34;
            btnEliminarRubro.Text = "Eliminar";
            btnEliminarRubro.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarRubro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarRubro.UseVisualStyleBackColor = false;
            btnEliminarRubro.Click += btnEliminarRubro_Click;
            // 
            // btnEditarRubro
            // 
            btnEditarRubro.BackColor = Color.DodgerBlue;
            btnEditarRubro.Cursor = Cursors.Hand;
            btnEditarRubro.FlatAppearance.BorderColor = Color.Black;
            btnEditarRubro.FlatStyle = FlatStyle.Popup;
            btnEditarRubro.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnEditarRubro.IconColor = Color.Black;
            btnEditarRubro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarRubro.IconSize = 16;
            btnEditarRubro.Location = new Point(39, 135);
            btnEditarRubro.Name = "btnEditarRubro";
            btnEditarRubro.Size = new Size(216, 23);
            btnEditarRubro.TabIndex = 33;
            btnEditarRubro.Text = "Editar";
            btnEditarRubro.TextAlign = ContentAlignment.MiddleRight;
            btnEditarRubro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarRubro.UseVisualStyleBackColor = false;
            btnEditarRubro.Click += btnEditarRubro_Click;
            // 
            // btnAgregarRubro
            // 
            btnAgregarRubro.BackColor = Color.ForestGreen;
            btnAgregarRubro.Cursor = Cursors.Hand;
            btnAgregarRubro.FlatAppearance.BorderColor = Color.Black;
            btnAgregarRubro.FlatStyle = FlatStyle.Popup;
            btnAgregarRubro.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnAgregarRubro.IconColor = Color.Black;
            btnAgregarRubro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarRubro.IconSize = 16;
            btnAgregarRubro.Location = new Point(39, 106);
            btnAgregarRubro.Name = "btnAgregarRubro";
            btnAgregarRubro.Size = new Size(216, 23);
            btnAgregarRubro.TabIndex = 32;
            btnAgregarRubro.Text = "Agregar";
            btnAgregarRubro.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarRubro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarRubro.UseVisualStyleBackColor = false;
            btnAgregarRubro.Click += btnAgregarRubro_Click;
            // 
            // btnMostrarProductos
            // 
            btnMostrarProductos.BackColor = Color.FromArgb(45, 66, 91);
            btnMostrarProductos.ForeColor = Color.White;
            btnMostrarProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMostrarProductos.IconColor = Color.Black;
            btnMostrarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrarProductos.Location = new Point(1150, 65);
            btnMostrarProductos.Name = "btnMostrarProductos";
            btnMostrarProductos.Size = new Size(94, 23);
            btnMostrarProductos.TabIndex = 35;
            btnMostrarProductos.Text = "Productos";
            btnMostrarProductos.UseVisualStyleBackColor = false;
            btnMostrarProductos.Click += btnMostrarProductos_Click;
            // 
            // btnMostrarRubros
            // 
            btnMostrarRubros.BackColor = Color.FromArgb(45, 66, 91);
            btnMostrarRubros.ForeColor = Color.White;
            btnMostrarRubros.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMostrarRubros.IconColor = Color.Black;
            btnMostrarRubros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrarRubros.Location = new Point(1150, 94);
            btnMostrarRubros.Name = "btnMostrarRubros";
            btnMostrarRubros.Size = new Size(94, 23);
            btnMostrarRubros.TabIndex = 36;
            btnMostrarRubros.Text = "Rubros";
            btnMostrarRubros.UseVisualStyleBackColor = false;
            btnMostrarRubros.Click += btnMostrarRubros_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(45, 66, 91);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 24;
            btnBuscar.Location = new Point(1023, 34);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(31, 23);
            btnBuscar.TabIndex = 92;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(803, 34);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(214, 23);
            txtBuscar.TabIndex = 91;
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1281, 622);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnMostrarRubros);
            Controls.Add(btnMostrarProductos);
            Controls.Add(btnEliminarRubro);
            Controls.Add(btnEditarRubro);
            Controls.Add(btnAgregarRubro);
            Controls.Add(cbItemsPorPagina);
            Controls.Add(txtPagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(label1);
            Controls.Add(Texto8);
            Controls.Add(txtCategoria);
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
        private TextBox txtCategoria;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private TextBox txtPagina;
        private ComboBox cbItemsPorPagina;
        private BindingSource productoBindingSource;
        private DataGridViewButtonColumn btnSeleccionar;
        private FontAwesome.Sharp.IconButton btnEliminarRubro;
        private FontAwesome.Sharp.IconButton btnEditarRubro;
        private FontAwesome.Sharp.IconButton btnAgregarRubro;
        private FontAwesome.Sharp.IconButton btnMostrarProductos;
        private FontAwesome.Sharp.IconButton btnMostrarRubros;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBuscar;
    }
}