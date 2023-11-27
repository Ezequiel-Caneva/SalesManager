namespace App.Presentation
{
    partial class subpromocion
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
            txt7 = new Label();
            btnPromocionar = new FontAwesome.Sharp.IconButton();
            txtDescuento = new TextBox();
            lbProducto = new Label();
            lblPrecio = new Label();
            SuspendLayout();
            // 
            // txt7
            // 
            txt7.AutoSize = true;
            txt7.BackColor = Color.FromArgb(40, 60, 90);
            txt7.ForeColor = Color.White;
            txt7.Location = new Point(30, 129);
            txt7.Name = "txt7";
            txt7.Size = new Size(79, 15);
            txt7.TabIndex = 111;
            txt7.Text = "Descuento %:";
            // 
            // btnPromocionar
            // 
            btnPromocionar.BackColor = Color.ForestGreen;
            btnPromocionar.Cursor = Cursors.Hand;
            btnPromocionar.FlatAppearance.BorderColor = Color.Black;
            btnPromocionar.FlatStyle = FlatStyle.Popup;
            btnPromocionar.IconChar = FontAwesome.Sharp.IconChar.Coins;
            btnPromocionar.IconColor = Color.Black;
            btnPromocionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPromocionar.IconSize = 16;
            btnPromocionar.Location = new Point(30, 186);
            btnPromocionar.Name = "btnPromocionar";
            btnPromocionar.Size = new Size(210, 31);
            btnPromocionar.TabIndex = 104;
            btnPromocionar.Text = "Promocionar";
            btnPromocionar.TextAlign = ContentAlignment.MiddleRight;
            btnPromocionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPromocionar.UseVisualStyleBackColor = false;
            btnPromocionar.Click += btnPromocionar_Click;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(30, 147);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(210, 23);
            txtDescuento.TabIndex = 112;
            // 
            // lbProducto
            // 
            lbProducto.AutoSize = true;
            lbProducto.ForeColor = Color.White;
            lbProducto.Location = new Point(30, 57);
            lbProducto.Name = "lbProducto";
            lbProducto.Size = new Size(59, 15);
            lbProducto.TabIndex = 113;
            lbProducto.Text = "Producto:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(30, 93);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 114;
            lblPrecio.Text = "Precio:";
            // 
            // subpromocion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(279, 238);
            Controls.Add(lblPrecio);
            Controls.Add(lbProducto);
            Controls.Add(txtDescuento);
            Controls.Add(txt7);
            Controls.Add(btnPromocionar);
            Name = "subpromocion";
            Text = "subpromocion";
            Load += subpromocion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMetodo;
        private Label txt7;
        private ComboBox cbCliente;
        private ComboBox cbFactura;
        private Label label1;
        private Label txt3;
        private Label txt1;
        private TextBox txtMonto;
        private FontAwesome.Sharp.IconButton btnPromocionar;
        private TextBox txtDescuento;
        private Label lbProducto;
        private Label lblPrecio;
    }
}