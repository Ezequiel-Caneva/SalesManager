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
            txt6 = new Label();
            dgvCobros = new DataGridView();
            txt7 = new Label();
            cbCliente = new ComboBox();
            cbFactura = new ComboBox();
            label1 = new Label();
            txt3 = new Label();
            txt1 = new Label();
            txtPrecioComp = new TextBox();
            txtCantidad = new TextBox();
            Texto5 = new Label();
            btnCobrar = new FontAwesome.Sharp.IconButton();
            labelcontenedor = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCobros).BeginInit();
            SuspendLayout();
            // 
            // txt6
            // 
            txt6.BackColor = Color.FromArgb(45, 66, 91);
            txt6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt6.ForeColor = Color.White;
            txt6.Location = new Point(349, 37);
            txt6.Name = "txt6";
            txt6.Size = new Size(227, 23);
            txt6.TabIndex = 102;
            txt6.Text = "Deudas del Cliente:";
            txt6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCobros
            // 
            dgvCobros.AllowUserToDeleteRows = false;
            dgvCobros.BackgroundColor = Color.White;
            dgvCobros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCobros.Location = new Point(349, 63);
            dgvCobros.Name = "dgvCobros";
            dgvCobros.ReadOnly = true;
            dgvCobros.RowTemplate.Height = 25;
            dgvCobros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCobros.Size = new Size(945, 407);
            dgvCobros.TabIndex = 101;
            // 
            // txt7
            // 
            txt7.AutoSize = true;
            txt7.BackColor = Color.FromArgb(40, 60, 90);
            txt7.ForeColor = Color.White;
            txt7.Location = new Point(32, 73);
            txt7.Name = "txt7";
            txt7.Size = new Size(47, 15);
            txt7.TabIndex = 100;
            txt7.Text = "Cliente:";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(31, 93);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(210, 23);
            cbCliente.TabIndex = 98;
            // 
            // cbFactura
            // 
            cbFactura.FormattingEnabled = true;
            cbFactura.Location = new Point(31, 137);
            cbFactura.Name = "cbFactura";
            cbFactura.Size = new Size(210, 23);
            cbFactura.TabIndex = 97;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 60, 90);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 119);
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
            txt3.Location = new Point(30, 207);
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
            txt1.Location = new Point(30, 163);
            txt1.Name = "txt1";
            txt1.Size = new Size(97, 15);
            txt1.TabIndex = 93;
            txt1.Text = "Monto a Abonar:";
            // 
            // txtPrecioComp
            // 
            txtPrecioComp.Location = new Point(31, 225);
            txtPrecioComp.Name = "txtPrecioComp";
            txtPrecioComp.Size = new Size(210, 23);
            txtPrecioComp.TabIndex = 92;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(32, 181);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(210, 23);
            txtCantidad.TabIndex = 91;
            // 
            // Texto5
            // 
            Texto5.BackColor = Color.FromArgb(45, 66, 91);
            Texto5.BorderStyle = BorderStyle.FixedSingle;
            Texto5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Texto5.ForeColor = Color.White;
            Texto5.Location = new Point(0, 25);
            Texto5.Name = "Texto5";
            Texto5.Size = new Size(291, 27);
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
            btnCobrar.Location = new Point(32, 264);
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
            labelcontenedor.Size = new Size(291, 579);
            labelcontenedor.TabIndex = 88;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1362, 579);
            Controls.Add(txt6);
            Controls.Add(dgvCobros);
            Controls.Add(txt7);
            Controls.Add(cbCliente);
            Controls.Add(cbFactura);
            Controls.Add(label1);
            Controls.Add(txt3);
            Controls.Add(txt1);
            Controls.Add(txtPrecioComp);
            Controls.Add(txtCantidad);
            Controls.Add(Texto5);
            Controls.Add(btnCobrar);
            Controls.Add(labelcontenedor);
            Name = "FormVentas";
            Text = "FormVentas";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCobros).EndInit();
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
        private TextBox txtPrecioComp;
        private TextBox txtCantidad;
        private Label Texto5;
        private FontAwesome.Sharp.IconButton btnCobrar;
        private Label labelcontenedor;
    }
}