namespace App.Presentation
{
    partial class FormPedidos
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
            dgvPedidos = new DataGridView();
            cbItemsPorPagina = new ComboBox();
            txtPagina = new TextBox();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            txt6 = new Label();
            btnConfimado = new FontAwesome.Sharp.IconButton();
            bntPendiente = new FontAwesome.Sharp.IconButton();
            btnDespachado = new FontAwesome.Sharp.IconButton();
            dgvDetalle = new DataGridView();
            btnConfirmar = new FontAwesome.Sharp.IconButton();
            btnDespachar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            btnFactura = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.BackgroundColor = Color.White;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(101, 68);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowTemplate.Height = 25;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(493, 425);
            dgvPedidos.TabIndex = 75;
            dgvPedidos.CellClick += dgvPedidos_CellClick;
            dgvPedidos.CellContentDoubleClick += dgvPedidos_CellContentDoubleClick;
            dgvPedidos.CellFormatting += dgvPedidos_CellFormatting;
            // 
            // cbItemsPorPagina
            // 
            cbItemsPorPagina.FormattingEnabled = true;
            cbItemsPorPagina.Items.AddRange(new object[] { "1", "5", "10", "15", "20", "25", "50" });
            cbItemsPorPagina.Location = new Point(531, 497);
            cbItemsPorPagina.Name = "cbItemsPorPagina";
            cbItemsPorPagina.Size = new Size(29, 23);
            cbItemsPorPagina.TabIndex = 74;
            cbItemsPorPagina.SelectedIndexChanged += cbItemsPorPagina_SelectedIndexChanged;
            // 
            // txtPagina
            // 
            txtPagina.BackColor = SystemColors.ActiveCaption;
            txtPagina.Location = new Point(453, 498);
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
            btnAnterior.Location = new Point(411, 497);
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
            btnSiguiente.Location = new Point(489, 498);
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
            txt6.Location = new Point(101, 32);
            txt6.Name = "txt6";
            txt6.Size = new Size(227, 23);
            txt6.TabIndex = 70;
            txt6.Text = "Vizualizar Pedidos";
            txt6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfimado
            // 
            btnConfimado.IconChar = FontAwesome.Sharp.IconChar.None;
            btnConfimado.IconColor = Color.Black;
            btnConfimado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfimado.Location = new Point(5, 97);
            btnConfimado.Name = "btnConfimado";
            btnConfimado.Size = new Size(90, 23);
            btnConfimado.TabIndex = 76;
            btnConfimado.Text = "Confimado";
            btnConfimado.UseVisualStyleBackColor = true;
            btnConfimado.Click += btnConfimado_Click;
            // 
            // bntPendiente
            // 
            bntPendiente.IconChar = FontAwesome.Sharp.IconChar.None;
            bntPendiente.IconColor = Color.Black;
            bntPendiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntPendiente.Location = new Point(5, 68);
            bntPendiente.Name = "bntPendiente";
            bntPendiente.Size = new Size(90, 23);
            bntPendiente.TabIndex = 77;
            bntPendiente.Text = "Pendiente";
            bntPendiente.UseVisualStyleBackColor = true;
            bntPendiente.Click += bntPendiente_Click;
            // 
            // btnDespachado
            // 
            btnDespachado.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDespachado.IconColor = Color.Black;
            btnDespachado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDespachado.Location = new Point(5, 126);
            btnDespachado.Name = "btnDespachado";
            btnDespachado.Size = new Size(90, 23);
            btnDespachado.TabIndex = 78;
            btnDespachado.Text = "Despachado";
            btnDespachado.UseVisualStyleBackColor = true;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(677, 68);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(501, 425);
            dgvDetalle.TabIndex = 79;
            dgvDetalle.CellContentDoubleClick += dgvDetalle_CellContentDoubleClick;
            dgvDetalle.CellFormatting += dgvDetalle_CellFormatting;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.DarkGreen;
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.ForeColor = SystemColors.ControlLightLight;
            btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnConfirmar.IconColor = Color.Black;
            btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmar.IconSize = 28;
            btnConfirmar.Location = new Point(614, 75);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(38, 34);
            btnConfirmar.TabIndex = 80;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnDespachar
            // 
            btnDespachar.BackColor = SystemColors.MenuHighlight;
            btnDespachar.FlatStyle = FlatStyle.Popup;
            btnDespachar.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            btnDespachar.IconColor = SystemColors.ActiveCaptionText;
            btnDespachar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDespachar.IconSize = 28;
            btnDespachar.Location = new Point(614, 75);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(38, 34);
            btnDespachar.TabIndex = 81;
            btnDespachar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 28;
            btnCancelar.Location = new Point(614, 115);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(38, 34);
            btnCancelar.TabIndex = 82;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // iconToolStripButton1
            // 
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconToolStripButton1.IconColor = Color.Black;
            iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton1.Name = "iconToolStripButton1";
            iconToolStripButton1.Size = new Size(23, 23);
            iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.CadetBlue;
            btnFactura.FlatStyle = FlatStyle.Popup;
            btnFactura.ForeColor = SystemColors.ActiveCaptionText;
            btnFactura.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btnFactura.IconColor = Color.Black;
            btnFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFactura.IconSize = 28;
            btnFactura.Location = new Point(614, 155);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(38, 34);
            btnFactura.TabIndex = 83;
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1241, 624);
            Controls.Add(btnFactura);
            Controls.Add(btnCancelar);
            Controls.Add(btnDespachar);
            Controls.Add(btnConfirmar);
            Controls.Add(dgvDetalle);
            Controls.Add(btnDespachado);
            Controls.Add(bntPendiente);
            Controls.Add(btnConfimado);
            Controls.Add(dgvPedidos);
            Controls.Add(cbItemsPorPagina);
            Controls.Add(txtPagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(txt6);
            Name = "FormPedidos";
            Text = "FormPedidos";
            Load += FormPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvPedidos;
        private ComboBox cbItemsPorPagina;
        private TextBox txtPagina;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private Label txt6;
        private FontAwesome.Sharp.IconButton btnConfimado;
        private FontAwesome.Sharp.IconButton bntPendiente;
        private FontAwesome.Sharp.IconButton btnDespachado;
        private DataGridView dgvDetalle;
        private FontAwesome.Sharp.IconButton btnConfirmar;
        private FontAwesome.Sharp.IconButton btnDespachar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconButton btnFactura;
    }
}