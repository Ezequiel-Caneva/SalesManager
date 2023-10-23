namespace App.Presentation
{
    partial class subEnvios
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
            txtCodigoSeguimiento = new TextBox();
            txtFechaEn = new TextBox();
            txtFechaRecep = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbEmpresa = new ComboBox();
            btnConfirmar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtCodigoSeguimiento
            // 
            txtCodigoSeguimiento.Location = new Point(33, 45);
            txtCodigoSeguimiento.Name = "txtCodigoSeguimiento";
            txtCodigoSeguimiento.Size = new Size(185, 23);
            txtCodigoSeguimiento.TabIndex = 0;
            // 
            // txtFechaEn
            // 
            txtFechaEn.Location = new Point(33, 90);
            txtFechaEn.Name = "txtFechaEn";
            txtFechaEn.Size = new Size(185, 23);
            txtFechaEn.TabIndex = 1;
            // 
            // txtFechaRecep
            // 
            txtFechaRecep.Location = new Point(33, 134);
            txtFechaRecep.Name = "txtFechaRecep";
            txtFechaRecep.Size = new Size(185, 23);
            txtFechaRecep.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 3;
            label1.Text = "Codigo seguimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 71);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "Fecha Envio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 116);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha de recepcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 160);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 6;
            label4.Text = "Empresa de transporte:";
            // 
            // cbEmpresa
            // 
            cbEmpresa.FormattingEnabled = true;
            cbEmpresa.Items.AddRange(new object[] { "Oca ", "Correo Argentino", "Transporte Bin Pack" });
            cbEmpresa.Location = new Point(33, 178);
            cbEmpresa.Name = "cbEmpresa";
            cbEmpresa.Size = new Size(185, 23);
            cbEmpresa.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnConfirmar.IconColor = Color.Black;
            btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmar.Location = new Point(143, 207);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(-2, 0);
            label5.Name = "label5";
            label5.Size = new Size(280, 27);
            label5.TabIndex = 9;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subEnvios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(278, 246);
            Controls.Add(label5);
            Controls.Add(btnConfirmar);
            Controls.Add(cbEmpresa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFechaRecep);
            Controls.Add(txtFechaEn);
            Controls.Add(txtCodigoSeguimiento);
            Name = "subEnvios";
            Text = "subEnvios";
            Load += subEnvios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigoSeguimiento;
        private TextBox txtFechaEn;
        private TextBox txtFechaRecep;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbEmpresa;
        private FontAwesome.Sharp.IconButton btnConfirmar;
        private Label label5;
    }
}