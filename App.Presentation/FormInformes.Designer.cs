namespace App.Presentation
{
    partial class FormInformes
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnVendedores = new FontAwesome.Sharp.IconButton();
            bntVentas = new FontAwesome.Sharp.IconButton();
            btnProductos = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            dgvInformes = new DataGridView();
            monthCalendar1 = new MonthCalendar();
            btnSeleccionar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
            btnExportar = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvInformes).BeginInit();
            SuspendLayout();
            // 
            // btnVendedores
            // 
            btnVendedores.BackColor = Color.FromArgb(45, 66, 91);
            btnVendedores.ForeColor = Color.White;
            btnVendedores.IconChar = FontAwesome.Sharp.IconChar.None;
            btnVendedores.IconColor = Color.Black;
            btnVendedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVendedores.Location = new Point(46, 70);
            btnVendedores.Name = "btnVendedores";
            btnVendedores.Size = new Size(190, 31);
            btnVendedores.TabIndex = 96;
            btnVendedores.Text = "Vendedores";
            btnVendedores.UseVisualStyleBackColor = false;
            btnVendedores.Click += btnVendedores_Click;
            // 
            // bntVentas
            // 
            bntVentas.BackColor = Color.FromArgb(45, 66, 91);
            bntVentas.ForeColor = Color.White;
            bntVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            bntVentas.IconColor = Color.White;
            bntVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntVentas.Location = new Point(46, 33);
            bntVentas.Name = "bntVentas";
            bntVentas.Size = new Size(190, 31);
            bntVentas.TabIndex = 95;
            bntVentas.Text = "Ventas";
            bntVentas.UseVisualStyleBackColor = false;
            bntVentas.Click += bntVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(45, 66, 91);
            btnProductos.ForeColor = Color.White;
            btnProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            btnProductos.IconColor = Color.Black;
            btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductos.Location = new Point(46, 107);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(190, 30);
            btnProductos.TabIndex = 94;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(40, 60, 90);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(284, 576);
            label1.TabIndex = 97;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvInformes
            // 
            dgvInformes.AllowUserToDeleteRows = false;
            dgvInformes.AllowUserToResizeColumns = false;
            dgvInformes.AllowUserToResizeRows = false;
            dgvInformes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInformes.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvInformes.BorderStyle = BorderStyle.None;
            dgvInformes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvInformes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvInformes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformes.EnableHeadersVisualStyles = false;
            dgvInformes.GridColor = Color.White;
            dgvInformes.Location = new Point(314, 12);
            dgvInformes.Name = "dgvInformes";
            dgvInformes.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvInformes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvInformes.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dgvInformes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvInformes.RowTemplate.Height = 25;
            dgvInformes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInformes.Size = new Size(817, 519);
            dgvInformes.TabIndex = 98;
            dgvInformes.CellContentClick += dgvInformes_CellContentClick;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.White;
            monthCalendar1.Location = new Point(18, 191);
            monthCalendar1.MaxSelectionCount = 90;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 99;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(45, 66, 91);
            btnSeleccionar.ForeColor = Color.White;
            btnSeleccionar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSeleccionar.IconColor = Color.Black;
            btnSeleccionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeleccionar.Location = new Point(166, 365);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(100, 38);
            btnSeleccionar.TabIndex = 100;
            btnSeleccionar.Text = "Seleccionar Fecha";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 338);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 101;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 361);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 102;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(45, 66, 91);
            btnExportar.ForeColor = Color.White;
            btnExportar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExportar.IconColor = Color.Black;
            btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportar.Location = new Point(1142, 12);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(100, 38);
            btnExportar.TabIndex = 103;
            btnExportar.Text = "Exportar a Excel";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(45, 66, 91);
            btnClientes.ForeColor = Color.White;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClientes.IconColor = Color.Black;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.Location = new Point(46, 143);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(190, 31);
            btnClientes.TabIndex = 104;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1254, 570);
            Controls.Add(btnClientes);
            Controls.Add(btnExportar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSeleccionar);
            Controls.Add(monthCalendar1);
            Controls.Add(dgvInformes);
            Controls.Add(btnVendedores);
            Controls.Add(bntVentas);
            Controls.Add(btnProductos);
            Controls.Add(label1);
            Name = "FormInformes";
            Text = "nm";
            Load += FormInformes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInformes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVendedores;
        private FontAwesome.Sharp.IconButton bntVentas;
        private FontAwesome.Sharp.IconButton btnProductos;
        private Label label1;
        private DataGridView dgvInformes;
        private MonthCalendar monthCalendar1;
        private FontAwesome.Sharp.IconButton btnSeleccionar;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnExportar;
        private FontAwesome.Sharp.IconButton btnClientes;
    }
}