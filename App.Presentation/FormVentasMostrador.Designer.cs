namespace App.Presentation
{
    partial class FormVentasMostrador
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
            dgvProductos = new DataGridView();
            dgvLista = new DataGridView();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            txt6 = new Label();
            label1 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnAceptar = new FontAwesome.Sharp.IconButton();
            cbItemsPorPagina = new ComboBox();
            txtPagina = new TextBox();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            txtproductoselec = new Label();
            txtlistado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(35, 37);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(493, 421);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.AllowUserToResizeColumns = false;
            dgvLista.AllowUserToResizeRows = false;
            dgvLista.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvLista.BorderStyle = BorderStyle.None;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(595, 37);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.RowHeadersVisible = false;
            dgvLista.RowTemplate.Height = 25;
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(436, 421);
            dgvLista.TabIndex = 1;
            dgvLista.CellContentClick += dgvLista_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.MenuHighlight;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            btnAgregar.IconColor = SystemColors.ActiveCaptionText;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 28;
            btnAgregar.Location = new Point(534, 48);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(38, 31);
            btnAgregar.TabIndex = 85;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.IndianRed;
            btnQuitar.FlatStyle = FlatStyle.Popup;
            btnQuitar.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btnQuitar.IconColor = SystemColors.ActiveCaptionText;
            btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitar.IconSize = 28;
            btnQuitar.Location = new Point(534, 85);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(38, 31);
            btnQuitar.TabIndex = 86;
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // txt6
            // 
            txt6.BackColor = Color.White;
            txt6.BorderStyle = BorderStyle.FixedSingle;
            txt6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt6.Location = new Point(67, 8);
            txt6.Name = "txt6";
            txt6.Size = new Size(146, 23);
            txt6.TabIndex = 87;
            txt6.Text = "Productos:";
            txt6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(595, 8);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 88;
            label1.Text = "Listar productos:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(259, 10);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(214, 23);
            txtBuscar.TabIndex = 89;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.MenuHighlight;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = SystemColors.ActiveCaptionText;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 24;
            btnBuscar.Location = new Point(479, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(31, 23);
            btnBuscar.TabIndex = 90;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAceptar.IconColor = Color.Black;
            btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAceptar.Location = new Point(924, 484);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(107, 48);
            btnAceptar.TabIndex = 92;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // cbItemsPorPagina
            // 
            cbItemsPorPagina.FormattingEnabled = true;
            cbItemsPorPagina.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "50" });
            cbItemsPorPagina.Location = new Point(480, 464);
            cbItemsPorPagina.Name = "cbItemsPorPagina";
            cbItemsPorPagina.Size = new Size(29, 23);
            cbItemsPorPagina.TabIndex = 96;
            cbItemsPorPagina.SelectedIndexChanged += cbItemsPorPagina_SelectedIndexChanged;
            // 
            // txtPagina
            // 
            txtPagina.BackColor = SystemColors.ActiveCaption;
            txtPagina.Location = new Point(393, 464);
            txtPagina.Name = "txtPagina";
            txtPagina.Size = new Size(30, 23);
            txtPagina.TabIndex = 95;
            txtPagina.TextChanged += txtPagina_TextChanged;
            // 
            // btnAnterior
            // 
            btnAnterior.AccessibleDescription = "";
            btnAnterior.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            btnAnterior.IconColor = Color.Black;
            btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnterior.IconSize = 20;
            btnAnterior.Location = new Point(351, 464);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(36, 23);
            btnAnterior.TabIndex = 94;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.MailForward;
            btnSiguiente.IconColor = Color.Black;
            btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSiguiente.IconSize = 20;
            btnSiguiente.Location = new Point(429, 464);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(34, 23);
            btnSiguiente.TabIndex = 93;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // txtproductoselec
            // 
            txtproductoselec.AutoSize = true;
            txtproductoselec.ForeColor = SystemColors.Control;
            txtproductoselec.Location = new Point(12, 37);
            txtproductoselec.Name = "txtproductoselec";
            txtproductoselec.Size = new Size(0, 15);
            txtproductoselec.TabIndex = 97;
            // 
            // txtlistado
            // 
            txtlistado.AutoSize = true;
            txtlistado.ForeColor = Color.White;
            txtlistado.Location = new Point(931, 10);
            txtlistado.Name = "txtlistado";
            txtlistado.Size = new Size(0, 15);
            txtlistado.TabIndex = 98;
            // 
            // FormVentasMostrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1067, 559);
            Controls.Add(txtlistado);
            Controls.Add(txtproductoselec);
            Controls.Add(cbItemsPorPagina);
            Controls.Add(txtPagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAceptar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(txt6);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvLista);
            Controls.Add(dgvProductos);
            Name = "FormVentasMostrador";
            Text = "FormVentasMostrador";
            Load += FormVentasMostrador_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private DataGridView dgvLista;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private Label txt6;
        private Label label1;
        private TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private ComboBox cbItemsPorPagina;
        private TextBox txtPagina;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private Label txtproductoselec;
        private Label txtlistado;
    }
}