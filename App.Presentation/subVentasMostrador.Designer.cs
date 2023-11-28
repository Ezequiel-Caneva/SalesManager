namespace App.Presentation
{
    partial class subVentasMostrador
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
            label1 = new Label();
            txtCliente = new TextBox();
            label2 = new Label();
            txtBuscar = new FontAwesome.Sharp.IconButton();
            btnCobrar = new FontAwesome.Sharp.IconButton();
            cbEnvio = new ComboBox();
            label3 = new Label();
            cbMetodo = new ComboBox();
            txt3 = new Label();
            txt1 = new Label();
            txtMonto = new TextBox();
            label4 = new Label();
            lblTotalVenta = new Label();
            label5 = new Label();
            lbCliente = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Dni del Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(105, 6);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(218, 23);
            txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(40, 60, 90);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(-7, 32);
            label2.Name = "label2";
            label2.Size = new Size(561, 12);
            label2.TabIndex = 95;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(45, 66, 91);
            txtBuscar.FlatStyle = FlatStyle.Popup;
            txtBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            txtBuscar.IconColor = Color.White;
            txtBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            txtBuscar.IconSize = 24;
            txtBuscar.Location = new Point(329, 6);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(31, 23);
            txtBuscar.TabIndex = 96;
            txtBuscar.UseVisualStyleBackColor = false;
            txtBuscar.Click += txtBuscar_Click;
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
            btnCobrar.Location = new Point(113, 219);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(210, 31);
            btnCobrar.TabIndex = 105;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.MiddleRight;
            btnCobrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // cbEnvio
            // 
            cbEnvio.FormattingEnabled = true;
            cbEnvio.Items.AddRange(new object[] { " ", "Si", "No" });
            cbEnvio.Location = new Point(113, 185);
            cbEnvio.Name = "cbEnvio";
            cbEnvio.Size = new Size(210, 23);
            cbEnvio.TabIndex = 106;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 188);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 107;
            label3.Text = "Envio a domicio:";
            // 
            // cbMetodo
            // 
            cbMetodo.FormattingEnabled = true;
            cbMetodo.Items.AddRange(new object[] { " ", "Efectivo", "Credito", "Cheque", "Deposito", "Debito", "Transferencia" });
            cbMetodo.Location = new Point(113, 152);
            cbMetodo.Name = "cbMetodo";
            cbMetodo.Size = new Size(210, 23);
            cbMetodo.TabIndex = 111;
            // 
            // txt3
            // 
            txt3.AutoSize = true;
            txt3.BackColor = Color.FromArgb(45, 66, 91);
            txt3.ForeColor = Color.White;
            txt3.Location = new Point(6, 155);
            txt3.Name = "txt3";
            txt3.Size = new Size(98, 15);
            txt3.TabIndex = 110;
            txt3.Text = "Metodo de pago:";
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.BackColor = Color.FromArgb(45, 66, 91);
            txt1.ForeColor = Color.White;
            txt1.Location = new Point(6, 122);
            txt1.Name = "txt1";
            txt1.Size = new Size(97, 15);
            txt1.TabIndex = 109;
            txt1.Text = "Monto a Abonar:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(113, 119);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(210, 23);
            txtMonto.TabIndex = 108;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(45, 66, 91);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 88);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 112;
            label4.Text = "Total de Venta:";
            // 
            // lblTotalVenta
            // 
            lblTotalVenta.AutoSize = true;
            lblTotalVenta.BackColor = Color.FromArgb(40, 60, 90);
            lblTotalVenta.ForeColor = Color.White;
            lblTotalVenta.Location = new Point(113, 88);
            lblTotalVenta.Name = "lblTotalVenta";
            lblTotalVenta.Size = new Size(0, 15);
            lblTotalVenta.TabIndex = 113;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(45, 66, 91);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 56);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 114;
            label5.Text = "Cliente:";
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.BackColor = Color.FromArgb(45, 66, 91);
            lbCliente.ForeColor = Color.White;
            lbCliente.Location = new Point(113, 56);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(0, 15);
            lbCliente.TabIndex = 116;
            // 
            // subVentasMostrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(410, 277);
            Controls.Add(lbCliente);
            Controls.Add(label5);
            Controls.Add(lblTotalVenta);
            Controls.Add(label4);
            Controls.Add(cbMetodo);
            Controls.Add(txt3);
            Controls.Add(txt1);
            Controls.Add(txtMonto);
            Controls.Add(label3);
            Controls.Add(cbEnvio);
            Controls.Add(btnCobrar);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Name = "subVentasMostrador";
            Text = "subVentasMostrador";
            Load += subVentasMostrador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private Label label2;
        private FontAwesome.Sharp.IconButton txtBuscar;
        private FontAwesome.Sharp.IconButton btnCobrar;
        private ComboBox cbEnvio;
        private Label label3;
        private ComboBox cbMetodo;
        private Label txt3;
        private Label txt1;
        private TextBox txtMonto;
        private Label label4;
        private Label lblTotalVenta;
        private Label label5;
        private Label lbCliente;
    }
}