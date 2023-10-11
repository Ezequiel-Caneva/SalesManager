namespace App.Presentation
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuVentasMostrador = new FontAwesome.Sharp.IconMenuItem();
            menuPedidos = new FontAwesome.Sharp.IconMenuItem();
            menuVentas = new FontAwesome.Sharp.IconMenuItem();
            menuCompras = new FontAwesome.Sharp.IconMenuItem();
            menuClientes = new FontAwesome.Sharp.IconMenuItem();
            menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            menuStock = new FontAwesome.Sharp.IconMenuItem();
            menuInformes = new FontAwesome.Sharp.IconMenuItem();
            menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            menuStrip2 = new MenuStrip();
            contenedor = new Panel();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 37);
            label1.TabIndex = 0;
            label1.Text = "Sistema de ventas";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuVentasMostrador, menuPedidos, menuVentas, menuCompras, menuClientes, menuProveedores, menuStock, menuInformes, menuUsuarios });
            menuStrip1.Location = new Point(0, 58);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1271, 73);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuVentasMostrador
            // 
            menuVentasMostrador.AutoSize = false;
            menuVentasMostrador.IconChar = FontAwesome.Sharp.IconChar.Coins;
            menuVentasMostrador.IconColor = Color.Black;
            menuVentasMostrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuVentasMostrador.IconSize = 50;
            menuVentasMostrador.ImageScaling = ToolStripItemImageScaling.None;
            menuVentasMostrador.Name = "menuVentasMostrador";
            menuVentasMostrador.Size = new Size(122, 69);
            menuVentasMostrador.Text = "Venta en Mostrador";
            menuVentasMostrador.TextImageRelation = TextImageRelation.ImageAboveText;
            menuVentasMostrador.Click += menuVentasMostrador_Click;
            // 
            // menuPedidos
            // 
            menuPedidos.AutoSize = false;
            menuPedidos.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            menuPedidos.IconColor = Color.Black;
            menuPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuPedidos.IconSize = 50;
            menuPedidos.ImageScaling = ToolStripItemImageScaling.None;
            menuPedidos.Name = "menuPedidos";
            menuPedidos.Size = new Size(122, 69);
            menuPedidos.Text = "Pedidos";
            menuPedidos.TextImageRelation = TextImageRelation.ImageAboveText;
            menuPedidos.Click += menuPedidos_Click;
            // 
            // menuVentas
            // 
            menuVentas.AutoSize = false;
            menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuVentas.IconColor = Color.Black;
            menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuVentas.IconSize = 50;
            menuVentas.ImageScaling = ToolStripItemImageScaling.None;
            menuVentas.Name = "menuVentas";
            menuVentas.Size = new Size(122, 69);
            menuVentas.Text = "Ventas";
            menuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            menuVentas.Click += menuVentas_Click;
            // 
            // menuCompras
            // 
            menuCompras.AutoSize = false;
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            menuCompras.IconColor = Color.Black;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.IconSize = 50;
            menuCompras.ImageScaling = ToolStripItemImageScaling.None;
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(122, 69);
            menuCompras.Text = "Compras";
            menuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            menuCompras.Click += menuCompras_Click;
            // 
            // menuClientes
            // 
            menuClientes.AutoSize = false;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            menuClientes.IconColor = Color.Black;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.IconSize = 50;
            menuClientes.ImageScaling = ToolStripItemImageScaling.None;
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(122, 69);
            menuClientes.Text = "Clientes";
            menuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuClientes.Click += menuClientes_Click;
            // 
            // menuProveedores
            // 
            menuProveedores.AutoSize = false;
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            menuProveedores.IconColor = Color.Black;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.IconSize = 50;
            menuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(122, 69);
            menuProveedores.Text = "Proveedores";
            menuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            menuProveedores.Click += menuProveedores_Click;
            // 
            // menuStock
            // 
            menuStock.AutoSize = false;
            menuStock.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            menuStock.IconColor = Color.Black;
            menuStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuStock.IconSize = 50;
            menuStock.ImageScaling = ToolStripItemImageScaling.None;
            menuStock.Name = "menuStock";
            menuStock.Size = new Size(122, 69);
            menuStock.Text = "Stock";
            menuStock.TextImageRelation = TextImageRelation.ImageAboveText;
            menuStock.Click += menuStock_Click;
            // 
            // menuInformes
            // 
            menuInformes.AutoSize = false;
            menuInformes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menuInformes.IconColor = Color.Black;
            menuInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuInformes.IconSize = 50;
            menuInformes.ImageScaling = ToolStripItemImageScaling.None;
            menuInformes.Name = "menuInformes";
            menuInformes.Size = new Size(122, 69);
            menuInformes.Text = "Informes";
            menuInformes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuInformes.Click += menuInformes_Click;
            // 
            // menuUsuarios
            // 
            menuUsuarios.AutoSize = false;
            menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            menuUsuarios.IconColor = Color.Black;
            menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuarios.IconSize = 50;
            menuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            menuUsuarios.Name = "menuUsuarios";
            menuUsuarios.Size = new Size(122, 69);
            menuUsuarios.Text = "Usuarios";
            menuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            menuUsuarios.Click += menuUsuarios_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.SteelBlue;
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.RightToLeft = RightToLeft.Yes;
            menuStrip2.Size = new Size(1271, 58);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // contenedor
            // 
            contenedor.AutoSize = true;
            contenedor.Controls.Add(label2);
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 131);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1271, 608);
            contenedor.TabIndex = 3;
            contenedor.Paint += contenedor_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 52);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 739);
            Controls.Add(contenedor);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contenedor.ResumeLayout(false);
            contenedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem menuPedidos;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuInformes;
        private FontAwesome.Sharp.IconMenuItem menuVentasMostrador;
        private Panel contenedor;
        private DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private FontAwesome.Sharp.IconMenuItem menuStock;
        private Label label2;
    }
}