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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnVendedores = new FontAwesome.Sharp.IconButton();
            bntVentas = new FontAwesome.Sharp.IconButton();
            btnProductos = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            dgvInformes = new DataGridView();
            monthCalendar1 = new MonthCalendar();
            btnSeleccionar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
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
            btnVendedores.Location = new Point(46, 107);
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
            btnProductos.Location = new Point(46, 70);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(190, 31);
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
            label1.Size = new Size(284, 722);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInformes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInformes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformes.EnableHeadersVisualStyles = false;
            dgvInformes.GridColor = Color.White;
            dgvInformes.Location = new Point(314, 12);
            dgvInformes.Name = "dgvInformes";
            dgvInformes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInformes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInformes.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dgvInformes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvInformes.RowTemplate.Height = 25;
            dgvInformes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInformes.Size = new Size(817, 519);
            dgvInformes.TabIndex = 98;
            dgvInformes.CellContentClick += dgvInformes_CellContentClick;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.White;
            monthCalendar1.Location = new Point(18, 164);
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
            btnSeleccionar.Location = new Point(156, 338);
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
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1191, 716);
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
    }
}