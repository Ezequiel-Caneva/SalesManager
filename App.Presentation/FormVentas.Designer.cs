namespace App.Presentation
{
    partial class FormVentas
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
            txt6 = new Label();
            dgvCobros = new DataGridView();
            fecha = new DataGridViewTextBoxColumn();
            pagoid = new DataGridViewTextBoxColumn();
            nrofactura = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            tipo_comprobante = new DataGridViewTextBoxColumn();
            nro_comprobante = new DataGridViewTextBoxColumn();
            metodopago = new DataGridViewTextBoxColumn();
            debito = new DataGridViewTextBoxColumn();
            credito = new DataGridViewTextBoxColumn();
            saldo = new DataGridViewTextBoxColumn();
            cobroBindingSource = new BindingSource(components);
            txt7 = new Label();
            cbCliente = new ComboBox();
            cbFactura = new ComboBox();
            label1 = new Label();
            txt3 = new Label();
            txt1 = new Label();
            txtMonto = new TextBox();
            Texto5 = new Label();
            btnCobrar = new FontAwesome.Sharp.IconButton();
            labelcontenedor = new Label();
            cbMetodo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCobros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cobroBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txt6
            // 
            txt6.BackColor = Color.FromArgb(45, 66, 91);
            txt6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt6.ForeColor = Color.White;
            txt6.Location = new Point(215, 2);
            txt6.Name = "txt6";
            txt6.Size = new Size(188, 23);
            txt6.TabIndex = 102;
            txt6.Text = "Deudas del Cliente";
            txt6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCobros
            // 
            dgvCobros.AllowUserToDeleteRows = false;
            dgvCobros.AutoGenerateColumns = false;
            dgvCobros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCobros.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvCobros.BorderStyle = BorderStyle.None;
            dgvCobros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCobros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCobros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCobros.Columns.AddRange(new DataGridViewColumn[] { fecha, pagoid, nrofactura, cliente, tipo_comprobante, nro_comprobante, metodopago, debito, credito, saldo });
            dgvCobros.DataSource = cobroBindingSource;
            dgvCobros.EnableHeadersVisualStyles = false;
            dgvCobros.GridColor = Color.White;
            dgvCobros.Location = new Point(215, 31);
            dgvCobros.Name = "dgvCobros";
            dgvCobros.ReadOnly = true;
            dgvCobros.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvCobros.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCobros.RowTemplate.Height = 25;
            dgvCobros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCobros.Size = new Size(1034, 494);
            dgvCobros.TabIndex = 101;
            // 
            // fecha
            // 
            fecha.DataPropertyName = "fecha";
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // pagoid
            // 
            pagoid.DataPropertyName = "pagoid";
            pagoid.HeaderText = "N° Pago";
            pagoid.Name = "pagoid";
            pagoid.ReadOnly = true;
            // 
            // nrofactura
            // 
            nrofactura.DataPropertyName = "nrofactura";
            nrofactura.HeaderText = "N° Fac";
            nrofactura.Name = "nrofactura";
            nrofactura.ReadOnly = true;
            // 
            // cliente
            // 
            cliente.DataPropertyName = "cliente";
            cliente.HeaderText = "Cliente";
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            // 
            // tipo_comprobante
            // 
            tipo_comprobante.DataPropertyName = "tipo_comprobante";
            tipo_comprobante.HeaderText = "Tipo";
            tipo_comprobante.Name = "tipo_comprobante";
            tipo_comprobante.ReadOnly = true;
            // 
            // nro_comprobante
            // 
            nro_comprobante.DataPropertyName = "nro_comprobante";
            nro_comprobante.HeaderText = "N° Com";
            nro_comprobante.Name = "nro_comprobante";
            nro_comprobante.ReadOnly = true;
            // 
            // metodopago
            // 
            metodopago.DataPropertyName = "metodopago";
            metodopago.HeaderText = "Metodo";
            metodopago.Name = "metodopago";
            metodopago.ReadOnly = true;
            // 
            // debito
            // 
            debito.DataPropertyName = "debito";
            debito.HeaderText = "Debito";
            debito.Name = "debito";
            debito.ReadOnly = true;
            // 
            // credito
            // 
            credito.DataPropertyName = "credito";
            credito.HeaderText = "Credito";
            credito.Name = "credito";
            credito.ReadOnly = true;
            // 
            // saldo
            // 
            saldo.DataPropertyName = "saldo";
            saldo.HeaderText = "Saldo";
            saldo.Name = "saldo";
            saldo.ReadOnly = true;
            // 
            // cobroBindingSource
            // 
            cobroBindingSource.DataSource = typeof(Entities.Cobro);
            // 
            // txt7
            // 
            txt7.AutoSize = true;
            txt7.BackColor = Color.FromArgb(40, 60, 90);
            txt7.ForeColor = Color.White;
            txt7.Location = new Point(-3, 73);
            txt7.Name = "txt7";
            txt7.Size = new Size(47, 15);
            txt7.TabIndex = 100;
            txt7.Text = "Cliente:";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Items.AddRange(new object[] { "All" });
            cbCliente.Location = new Point(-1, 91);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(210, 23);
            cbCliente.TabIndex = 98;
            // 
            // cbFactura
            // 
            cbFactura.FormattingEnabled = true;
            cbFactura.Items.AddRange(new object[] { "All" });
            cbFactura.Location = new Point(-1, 135);
            cbFactura.Name = "cbFactura";
            cbFactura.Size = new Size(210, 23);
            cbFactura.TabIndex = 97;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 60, 90);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-3, 117);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 96;
            label1.Text = "Factura:";
            // 
            // txt3
            // 
            txt3.AutoSize = true;
            txt3.BackColor = Color.FromArgb(40, 60, 90);
            txt3.ForeColor = Color.White;
            txt3.Location = new Point(-2, 205);
            txt3.Name = "txt3";
            txt3.Size = new Size(98, 15);
            txt3.TabIndex = 94;
            txt3.Text = "Metodo de pago:";
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.BackColor = Color.FromArgb(40, 60, 90);
            txt1.ForeColor = Color.White;
            txt1.Location = new Point(-2, 161);
            txt1.Name = "txt1";
            txt1.Size = new Size(97, 15);
            txt1.TabIndex = 93;
            txt1.Text = "Monto a Abonar:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(0, 179);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(210, 23);
            txtMonto.TabIndex = 91;
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
            Texto5.TabIndex = 90;
            Texto5.Text = "Cobrar ";
            Texto5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.ForestGreen;
            btnCobrar.Cursor = Cursors.Hand;
            btnCobrar.FlatAppearance.BorderColor = Color.Black;
            btnCobrar.FlatStyle = FlatStyle.Popup;
            btnCobrar.IconChar = FontAwesome.Sharp.IconChar.Coins;
            btnCobrar.IconColor = Color.Black;
            btnCobrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCobrar.IconSize = 16;
            btnCobrar.Location = new Point(0, 262);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(210, 31);
            btnCobrar.TabIndex = 89;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.MiddleRight;
            btnCobrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // labelcontenedor
            // 
            labelcontenedor.BackColor = Color.FromArgb(40, 60, 90);
            labelcontenedor.BorderStyle = BorderStyle.FixedSingle;
            labelcontenedor.Dock = DockStyle.Left;
            labelcontenedor.Location = new Point(0, 0);
            labelcontenedor.Name = "labelcontenedor";
            labelcontenedor.Size = new Size(210, 579);
            labelcontenedor.TabIndex = 88;
            // 
            // cbMetodo
            // 
            cbMetodo.FormattingEnabled = true;
            cbMetodo.Items.AddRange(new object[] { " ", "Efectivo", "Credito", "Cheque", "Deposito", "Debito", "Transferencia" });
            cbMetodo.Location = new Point(0, 223);
            cbMetodo.Name = "cbMetodo";
            cbMetodo.Size = new Size(210, 23);
            cbMetodo.TabIndex = 103;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1404, 579);
            Controls.Add(cbMetodo);
            Controls.Add(txt6);
            Controls.Add(dgvCobros);
            Controls.Add(txt7);
            Controls.Add(cbCliente);
            Controls.Add(cbFactura);
            Controls.Add(label1);
            Controls.Add(txt3);
            Controls.Add(txt1);
            Controls.Add(txtMonto);
            Controls.Add(Texto5);
            Controls.Add(btnCobrar);
            Controls.Add(labelcontenedor);
            Name = "FormVentas";
            Text = "FormVentas";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCobros).EndInit();
            ((System.ComponentModel.ISupportInitialize)cobroBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt6;
        private DataGridView dgvCobros;
        private Label txt7;
        private ComboBox cbCliente;
        private ComboBox cbFactura;
        private Label label1;
        private Label txt3;
        private Label txt1;
        private TextBox txtMonto;
        private Label Texto5;
        private FontAwesome.Sharp.IconButton btnCobrar;
        private Label labelcontenedor;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn pagoid;
        private DataGridViewTextBoxColumn nrofactura;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn tipo_comprobante;
        private DataGridViewTextBoxColumn nro_comprobante;
        private DataGridViewTextBoxColumn metodopago;
        private DataGridViewTextBoxColumn debito;
        private DataGridViewTextBoxColumn credito;
        private DataGridViewTextBoxColumn saldo;
        private BindingSource cobroBindingSource;
        private ComboBox cbMetodo;
    }
}