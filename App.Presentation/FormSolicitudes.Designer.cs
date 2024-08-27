namespace App.Presentation
{
    partial class FormSolicitudes
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvSolicitudes = new DataGridView();
            solicitudid = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            mensaje = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            solicitudBindingSource = new BindingSource(components);
            txt6 = new Label();
            labelcontenedor = new Label();
            bntPendiente = new FontAwesome.Sharp.IconButton();
            btnConfimado = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)solicitudBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.AllowUserToDeleteRows = false;
            dgvSolicitudes.AllowUserToResizeColumns = false;
            dgvSolicitudes.AllowUserToResizeRows = false;
            dgvSolicitudes.AutoGenerateColumns = false;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSolicitudes.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvSolicitudes.BorderStyle = BorderStyle.None;
            dgvSolicitudes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { solicitudid, nombre, email, telefono, mensaje, estado });
            dgvSolicitudes.DataSource = solicitudBindingSource;
            dgvSolicitudes.EnableHeadersVisualStyles = false;
            dgvSolicitudes.GridColor = Color.White;
            dgvSolicitudes.Location = new Point(96, 26);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSolicitudes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSolicitudes.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dgvSolicitudes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudes.Size = new Size(978, 510);
            dgvSolicitudes.TabIndex = 94;
            // 
            // solicitudid
            // 
            solicitudid.DataPropertyName = "solicitudid";
            solicitudid.HeaderText = "N° Solicitud";
            solicitudid.Name = "solicitudid";
            solicitudid.ReadOnly = true;
            solicitudid.Width = 114;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 92;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 70;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 95;
            // 
            // mensaje
            // 
            mensaje.DataPropertyName = "mensaje";
            mensaje.HeaderText = "Mensaje";
            mensaje.Name = "mensaje";
            mensaje.ReadOnly = true;
            mensaje.Width = 96;
            // 
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 82;
            // 
            // solicitudBindingSource
            // 
            solicitudBindingSource.DataSource = typeof(Entities.Solicitud);
            // 
            // txt6
            // 
            txt6.BackColor = Color.FromArgb(45, 66, 91);
            txt6.Font = new Font("Segoe UI", 12F);
            txt6.ForeColor = Color.White;
            txt6.Location = new Point(81, 0);
            txt6.Name = "txt6";
            txt6.Size = new Size(193, 23);
            txt6.TabIndex = 95;
            txt6.Text = "Solicitudes";
            txt6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelcontenedor
            // 
            labelcontenedor.BackColor = Color.FromArgb(40, 60, 90);
            labelcontenedor.BorderStyle = BorderStyle.FixedSingle;
            labelcontenedor.Dock = DockStyle.Left;
            labelcontenedor.Location = new Point(0, 0);
            labelcontenedor.Name = "labelcontenedor";
            labelcontenedor.Size = new Size(90, 635);
            labelcontenedor.TabIndex = 96;
            // 
            // bntPendiente
            // 
            bntPendiente.BackColor = Color.FromArgb(45, 66, 91);
            bntPendiente.ForeColor = Color.White;
            bntPendiente.IconChar = FontAwesome.Sharp.IconChar.None;
            bntPendiente.IconColor = Color.White;
            bntPendiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntPendiente.Location = new Point(0, 26);
            bntPendiente.Name = "bntPendiente";
            bntPendiente.Size = new Size(90, 31);
            bntPendiente.TabIndex = 98;
            bntPendiente.Text = "Pendiente";
            bntPendiente.UseVisualStyleBackColor = false;
            bntPendiente.Click += bntPendiente_Click;
            // 
            // btnConfimado
            // 
            btnConfimado.BackColor = Color.FromArgb(45, 66, 91);
            btnConfimado.ForeColor = Color.White;
            btnConfimado.IconChar = FontAwesome.Sharp.IconChar.None;
            btnConfimado.IconColor = Color.Black;
            btnConfimado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfimado.Location = new Point(0, 63);
            btnConfimado.Name = "btnConfimado";
            btnConfimado.Size = new Size(90, 31);
            btnConfimado.TabIndex = 97;
            btnConfimado.Text = "Confimado";
            btnConfimado.UseVisualStyleBackColor = false;
            btnConfimado.Click += btnConfimado_Click;
            // 
            // FormSolicitudes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1118, 635);
            Controls.Add(bntPendiente);
            Controls.Add(btnConfimado);
            Controls.Add(labelcontenedor);
            Controls.Add(txt6);
            Controls.Add(dgvSolicitudes);
            Name = "FormSolicitudes";
            Text = "FormSolicitudes";
            Load += FormSolicitudes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            ((System.ComponentModel.ISupportInitialize)solicitudBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSolicitudes;
        private Label txt6;
        private Label labelcontenedor;
        private DataGridViewTextBoxColumn solicitudid;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn mensaje;
        private DataGridViewTextBoxColumn estado;
        private BindingSource solicitudBindingSource;
        private FontAwesome.Sharp.IconButton bntPendiente;
        private FontAwesome.Sharp.IconButton btnConfimado;
    }
}