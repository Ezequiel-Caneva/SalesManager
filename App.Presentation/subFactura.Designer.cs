namespace App.Presentation
{
    partial class subFactura
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
            lblFactura = new Label();
            SuspendLayout();
            // 
            // lblFactura
            // 
            lblFactura.BackColor = Color.White;
            lblFactura.BorderStyle = BorderStyle.FixedSingle;
            lblFactura.Dock = DockStyle.Left;
            lblFactura.Location = new Point(0, 0);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(234, 211);
            lblFactura.TabIndex = 48;
            lblFactura.Click += lblFactura_Click;
            // 
            // subFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(lblFactura);
            Name = "subFactura";
            Text = "subPedidos";
            Load += subFactura_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblFactura;
    }
}