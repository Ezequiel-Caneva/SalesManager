namespace App.Presentation
{
    partial class FormUsuarios
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
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txt1 = new Label();
            txtContrasenia = new TextBox();
            txtDni = new TextBox();
            Texto5 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnCrear = new FontAwesome.Sharp.IconButton();
            Text1 = new Label();
            labelcontenedor = new Label();
            txtNombre = new TextBox();
            txtasd = new Label();
            txtZona = new TextBox();
            dgvVendedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(40, 60, 90);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 273);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 109;
            label2.Text = "Zona:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 60, 90);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 217);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 108;
            label1.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 106;
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.BackColor = Color.FromArgb(40, 60, 90);
            txt1.ForeColor = Color.White;
            txt1.Location = new Point(40, 108);
            txt1.Name = "txt1";
            txt1.Size = new Size(28, 15);
            txt1.TabIndex = 103;
            txt1.Text = "Dni:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(41, 177);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(210, 23);
            txtContrasenia.TabIndex = 101;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(40, 126);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(210, 23);
            txtDni.TabIndex = 100;
            // 
            // Texto5
            // 
            Texto5.BackColor = Color.FromArgb(45, 66, 91);
            Texto5.BorderStyle = BorderStyle.FixedSingle;
            Texto5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Texto5.ForeColor = Color.White;
            Texto5.Location = new Point(0, 9);
            Texto5.Name = "Texto5";
            Texto5.Size = new Size(291, 27);
            Texto5.TabIndex = 99;
            Texto5.Text = "Registrar Vendedor";
            Texto5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 16;
            btnEliminar.Location = new Point(40, 363);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(210, 23);
            btnEliminar.TabIndex = 98;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.ForestGreen;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatAppearance.BorderColor = Color.Black;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnCrear.IconColor = Color.Black;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.IconSize = 16;
            btnCrear.Location = new Point(40, 334);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(210, 23);
            btnCrear.TabIndex = 96;
            btnCrear.Text = "Crear";
            btnCrear.TextAlign = ContentAlignment.MiddleRight;
            btnCrear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // Text1
            // 
            Text1.AutoSize = true;
            Text1.BackColor = Color.FromArgb(40, 60, 90);
            Text1.ForeColor = Color.White;
            Text1.Location = new Point(40, 57);
            Text1.Name = "Text1";
            Text1.Size = new Size(54, 15);
            Text1.TabIndex = 95;
            Text1.Text = "Nombre:";
            // 
            // labelcontenedor
            // 
            labelcontenedor.BackColor = Color.FromArgb(40, 60, 90);
            labelcontenedor.BorderStyle = BorderStyle.FixedSingle;
            labelcontenedor.Dock = DockStyle.Left;
            labelcontenedor.Location = new Point(0, 0);
            labelcontenedor.Name = "labelcontenedor";
            labelcontenedor.Size = new Size(291, 595);
            labelcontenedor.TabIndex = 112;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 94;
            // 
            // txtasd
            // 
            txtasd.AutoSize = true;
            txtasd.BackColor = Color.FromArgb(40, 60, 90);
            txtasd.ForeColor = Color.White;
            txtasd.Location = new Point(40, 159);
            txtasd.Name = "txtasd";
            txtasd.Size = new Size(70, 15);
            txtasd.TabIndex = 113;
            txtasd.Text = "Contraseña:";
            // 
            // txtZona
            // 
            txtZona.Location = new Point(41, 291);
            txtZona.Name = "txtZona";
            txtZona.Size = new Size(210, 23);
            txtZona.TabIndex = 114;
            // 
            // dgvVendedores
            // 
            dgvVendedores.AllowUserToDeleteRows = false;
            dgvVendedores.AllowUserToResizeColumns = false;
            dgvVendedores.AllowUserToResizeRows = false;
            dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVendedores.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvVendedores.BorderStyle = BorderStyle.None;
            dgvVendedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.EnableHeadersVisualStyles = false;
            dgvVendedores.GridColor = Color.SteelBlue;
            dgvVendedores.Location = new Point(322, 38);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVendedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVendedores.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvVendedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvVendedores.RowTemplate.Height = 25;
            dgvVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendedores.Size = new Size(795, 478);
            dgvVendedores.TabIndex = 115;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1147, 595);
            Controls.Add(dgvVendedores);
            Controls.Add(txtZona);
            Controls.Add(txtasd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txt1);
            Controls.Add(txtContrasenia);
            Controls.Add(txtDni);
            Controls.Add(Texto5);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(Text1);
            Controls.Add(txtNombre);
            Controls.Add(labelcontenedor);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtCodPostal;
        private Label label2;
        private Label label1;
        private TextBox txtCiudad;
        private TextBox txtEmail;
        private Label txt4;
        private Label txt2;
        private Label txt1;
        private TextBox txtTel;
        private TextBox txtContrasenia;
        private TextBox txtDni;
        private Label Texto5;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private Label Text1;
        private Label labelcontenedor;
        private TextBox txtNombre;
        private Label txtasd;
        private TextBox txtZona;
        private DataGridView dgvVendedores;
    }
}