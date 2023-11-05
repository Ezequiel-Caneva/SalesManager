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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            btnVer = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPedidos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPedidos.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvPedidos.BorderStyle = BorderStyle.None;
            dgvPedidos.CausesValidation = false;
            dgvPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Cursor = Cursors.Hand;
            dgvPedidos.EnableHeadersVisualStyles = false;
            dgvPedidos.GridColor = Color.SteelBlue;
            dgvPedidos.Location = new Point(117, 68);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPedidos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvPedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvPedidos.RowTemplate.Height = 25;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(590, 425);
            dgvPedidos.TabIndex = 75;
            dgvPedidos.CellClick += dgvPedidos_CellClick;
            // 
            // cbItemsPorPagina
            // 
            cbItemsPorPagina.FormattingEnabled = true;
            cbItemsPorPagina.Items.AddRange(new object[] { "1", "5", "10", "15", "20", "25", "50" });
            cbItemsPorPagina.Location = new Point(628, 499);
            cbItemsPorPagina.Name = "cbItemsPorPagina";
            cbItemsPorPagina.Size = new Size(29, 23);
            cbItemsPorPagina.TabIndex = 74;
            cbItemsPorPagina.SelectedIndexChanged += cbItemsPorPagina_SelectedIndexChanged;
            // 
            // txtPagina
            // 
            txtPagina.BackColor = SystemColors.ActiveCaption;
            txtPagina.Location = new Point(550, 499);
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
            btnAnterior.Location = new Point(508, 499);
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
            btnSiguiente.Location = new Point(586, 500);
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
            txt6.Location = new Point(117, 42);
            txt6.Name = "txt6";
            txt6.Size = new Size(227, 23);
            txt6.TabIndex = 70;
            txt6.Text = "Vizualizar Pedidos";
            txt6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfimado
            // 
            btnConfimado.BackColor = Color.FromArgb(45, 66, 91);
            btnConfimado.ForeColor = Color.White;
            btnConfimado.IconChar = FontAwesome.Sharp.IconChar.None;
            btnConfimado.IconColor = Color.Black;
            btnConfimado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfimado.Location = new Point(5, 97);
            btnConfimado.Name = "btnConfimado";
            btnConfimado.Size = new Size(90, 23);
            btnConfimado.TabIndex = 76;
            btnConfimado.Text = "Confimado";
            btnConfimado.UseVisualStyleBackColor = false;
            btnConfimado.Click += btnConfimado_Click;
            // 
            // bntPendiente
            // 
            bntPendiente.BackColor = Color.FromArgb(45, 66, 91);
            bntPendiente.ForeColor = Color.White;
            bntPendiente.IconChar = FontAwesome.Sharp.IconChar.None;
            bntPendiente.IconColor = Color.White;
            bntPendiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntPendiente.Location = new Point(5, 68);
            bntPendiente.Name = "bntPendiente";
            bntPendiente.Size = new Size(90, 23);
            bntPendiente.TabIndex = 77;
            bntPendiente.Text = "Pendiente";
            bntPendiente.UseVisualStyleBackColor = false;
            bntPendiente.Click += bntPendiente_Click;
            // 
            // btnDespachado
            // 
            btnDespachado.BackColor = Color.FromArgb(45, 66, 91);
            btnDespachado.ForeColor = Color.White;
            btnDespachado.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDespachado.IconColor = Color.Black;
            btnDespachado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDespachado.Location = new Point(5, 126);
            btnDespachado.Name = "btnDespachado";
            btnDespachado.Size = new Size(90, 23);
            btnDespachado.TabIndex = 78;
            btnDespachado.Text = "Despachado";
            btnDespachado.UseVisualStyleBackColor = false;
            btnDespachado.Click += btnDespachado_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AllowUserToResizeColumns = false;
            dgvDetalle.AllowUserToResizeRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetalle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetalle.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvDetalle.BorderStyle = BorderStyle.None;
            dgvDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.GridColor = Color.SteelBlue;
            dgvDetalle.Location = new Point(798, 68);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDetalle.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvDetalle.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(451, 425);
            dgvDetalle.TabIndex = 79;
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
            btnConfirmar.Location = new Point(734, 75);
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
            btnDespachar.Location = new Point(734, 75);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(38, 34);
            btnDespachar.TabIndex = 81;
            btnDespachar.UseVisualStyleBackColor = false;
            btnDespachar.Click += btnDespachar_Click;
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
            btnCancelar.Location = new Point(734, 115);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(38, 34);
            btnCancelar.TabIndex = 82;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
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
            btnFactura.Location = new Point(734, 115);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(38, 34);
            btnFactura.TabIndex = 83;
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = SystemColors.MenuHighlight;
            btnVer.FlatStyle = FlatStyle.Popup;
            btnVer.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnVer.IconColor = SystemColors.ActiveCaptionText;
            btnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVer.IconSize = 28;
            btnVer.Location = new Point(734, 75);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(38, 34);
            btnVer.TabIndex = 84;
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(45, 66, 91);
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 24;
            iconButton2.Location = new Point(663, 42);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(31, 23);
            iconButton2.TabIndex = 92;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(443, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 91;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1261, 624);
            Controls.Add(iconButton2);
            Controls.Add(textBox1);
            Controls.Add(btnVer);
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
        private FontAwesome.Sharp.IconButton btnVer;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox textBox1;
    }
}