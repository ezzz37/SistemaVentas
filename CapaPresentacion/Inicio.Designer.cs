namespace CapaPresentacion
{
    partial class Inicio
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
            menuStrip1 = new MenuStrip();
            menuUsuario = new FontAwesome.Sharp.IconMenuItem();
            menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            menuCompras = new FontAwesome.Sharp.IconMenuItem();
            menuClientes = new FontAwesome.Sharp.IconMenuItem();
            menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            menuReportes = new FontAwesome.Sharp.IconMenuItem();
            menuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            menuTitulo = new MenuStrip();
            lblusuario = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            contenedor = new Panel();
            menuStrip1.SuspendLayout();
            menuTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuUsuario, menuMantenedor, MenuVentas, menuCompras, menuClientes, menuProveedores, menuReportes, menuAcercaDe });
            menuStrip1.Location = new Point(0, 78);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1119, 73);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuario
            // 
            menuUsuario.AutoSize = false;
            menuUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            menuUsuario.IconColor = Color.Black;
            menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuario.IconSize = 50;
            menuUsuario.ImageScaling = ToolStripItemImageScaling.None;
            menuUsuario.Name = "menuUsuario";
            menuUsuario.Size = new Size(80, 69);
            menuUsuario.Text = "Usuarios";
            menuUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            menuUsuario.Click += menuUsuario_Click;
            // 
            // menuMantenedor
            // 
            menuMantenedor.AutoSize = false;
            menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            menuMantenedor.IconColor = Color.Black;
            menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuMantenedor.IconSize = 50;
            menuMantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menuMantenedor.Name = "menuMantenedor";
            menuMantenedor.Size = new Size(80, 69);
            menuMantenedor.Text = "Mantenedor";
            menuMantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuVentas
            // 
            MenuVentas.AutoSize = false;
            MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            MenuVentas.IconColor = Color.Black;
            MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuVentas.IconSize = 50;
            MenuVentas.ImageScaling = ToolStripItemImageScaling.None;
            MenuVentas.Name = "MenuVentas";
            MenuVentas.Size = new Size(80, 69);
            MenuVentas.Text = "Ventas";
            MenuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuCompras
            // 
            menuCompras.AutoSize = false;
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            menuCompras.IconColor = Color.Black;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.IconSize = 50;
            menuCompras.ImageScaling = ToolStripItemImageScaling.None;
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(80, 69);
            menuCompras.Text = "Compras";
            menuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuClientes
            // 
            menuClientes.AutoSize = false;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            menuClientes.IconColor = Color.Black;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.IconSize = 50;
            menuClientes.ImageScaling = ToolStripItemImageScaling.None;
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(80, 69);
            menuClientes.Text = "Clientes";
            menuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuProveedores
            // 
            menuProveedores.AutoSize = false;
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            menuProveedores.IconColor = Color.Black;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.IconSize = 50;
            menuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(80, 69);
            menuProveedores.Text = "Proveedores";
            menuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuReportes
            // 
            menuReportes.AutoSize = false;
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menuReportes.IconColor = Color.Black;
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReportes.IconSize = 50;
            menuReportes.ImageScaling = ToolStripItemImageScaling.None;
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(80, 69);
            menuReportes.Text = "Reportes";
            menuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuAcercaDe
            // 
            menuAcercaDe.AutoSize = false;
            menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuAcercaDe.IconColor = Color.Black;
            menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuAcercaDe.IconSize = 50;
            menuAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            menuAcercaDe.Name = "menuAcercaDe";
            menuAcercaDe.Size = new Size(80, 69);
            menuAcercaDe.Text = "Acerca de";
            menuAcercaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = Color.DarkGray;
            menuTitulo.Items.AddRange(new ToolStripItem[] { lblusuario, usuarioToolStripMenuItem });
            menuTitulo.Location = new Point(0, 0);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.RightToLeft = RightToLeft.Yes;
            menuTitulo.Size = new Size(1119, 78);
            menuTitulo.TabIndex = 1;
            menuTitulo.Text = "menuStrip2";
            menuTitulo.ItemClicked += menuStrip2_ItemClicked;
            // 
            // lblusuario
            // 
            lblusuario.ForeColor = Color.White;
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(71, 74);
            lblusuario.Text = "lblusuario";
            lblusuario.Click += toolStripMenuItem1_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.ForeColor = Color.White;
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(62, 74);
            usuarioToolStripMenuItem.Text = ":Usuario";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(438, 59);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Ventas";
            label1.TextAlign = ContentAlignment.BottomLeft;
            label1.Click += label1_Click;
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 151);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1119, 358);
            contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1119, 509);
            Controls.Add(contenedor);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuTitulo);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuTitulo.ResumeLayout(false);
            menuTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuTitulo;
        private Label label1;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuUsuario;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuAcercaDe;
        private Panel contenedor;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem lblusuario;
    }
}