namespace CapaPresentacion
{
    partial class frmReporteCompras
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
            label10 = new Label();
            label1 = new Label();
            txtfechainicio = new DateTimePicker();
            txtfechafin = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            cboproveedor = new ComboBox();
            label4 = new Label();
            dgvdata = new DataGridView();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistrado = new DataGridViewTextBoxColumn();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnexportar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            txtbuscarpor = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Padding = new Padding(6, 0, 0, 0);
            label10.Size = new Size(1251, 88);
            label10.TabIndex = 73;
            label10.Text = "Reporte Compras:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(45, 54);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 74;
            label1.Text = "Fecha Inicio:";
            // 
            // txtfechainicio
            // 
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Format = DateTimePickerFormat.Short;
            txtfechainicio.Location = new Point(145, 54);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(96, 23);
            txtfechainicio.TabIndex = 75;
            // 
            // txtfechafin
            // 
            txtfechafin.CustomFormat = "dd/MM/yyyy";
            txtfechafin.Format = DateTimePickerFormat.Short;
            txtfechafin.Location = new Point(352, 54);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new Size(96, 23);
            txtfechafin.TabIndex = 77;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(252, 54);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 76;
            label2.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(462, 54);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 78;
            label3.Text = "Proveedores:";
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.White;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.Transparent;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(744, 54);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(45, 23);
            btnbuscar.TabIndex = 80;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // cboproveedor
            // 
            cboproveedor.FormattingEnabled = true;
            cboproveedor.Location = new Point(568, 54);
            cboproveedor.Name = "cboproveedor";
            cboproveedor.Size = new Size(170, 23);
            cboproveedor.TabIndex = 79;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Padding = new Padding(2, 0, 0, 0);
            label4.Size = new Size(1251, 541);
            label4.TabIndex = 83;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistrado, DocumentoProveedor, RazonSocial, CodigoProducto, NombreProducto, Categoria, PrecioCompra, PrecioVenta, Cantidad, SubTotal });
            dgvdata.Location = new Point(25, 171);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(1228, 470);
            dgvdata.TabIndex = 84;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.ReadOnly = true;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.Name = "MontoTotal";
            MontoTotal.ReadOnly = true;
            // 
            // UsuarioRegistrado
            // 
            UsuarioRegistrado.HeaderText = "Usuario Registrado";
            UsuarioRegistrado.Name = "UsuarioRegistrado";
            UsuarioRegistrado.ReadOnly = true;
            // 
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "Documento Proveedor";
            DocumentoProveedor.Name = "DocumentoProveedor";
            DocumentoProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // btnexportar
            // 
            btnexportar.BackColor = Color.White;
            btnexportar.Cursor = Cursors.Hand;
            btnexportar.FlatAppearance.BorderColor = Color.Black;
            btnexportar.FlatStyle = FlatStyle.Flat;
            btnexportar.ForeColor = Color.Black;
            btnexportar.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnexportar.IconColor = Color.Black;
            btnexportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexportar.IconSize = 18;
            btnexportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnexportar.Location = new Point(25, 131);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(142, 23);
            btnexportar.TabIndex = 85;
            btnexportar.Text = "Descargar Excel";
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 18;
            iconButton1.Location = new Point(1159, 132);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(45, 23);
            iconButton1.TabIndex = 89;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.BackColor = Color.White;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.ForeColor = Color.Transparent;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.Black;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 18;
            btnlimpiarbuscador.Location = new Point(1210, 132);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(43, 23);
            btnlimpiarbuscador.TabIndex = 90;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(1018, 132);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(135, 23);
            txtbusqueda.TabIndex = 88;
            // 
            // cbobusqueda
            // 
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(891, 132);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(121, 23);
            cbobusqueda.TabIndex = 87;
            // 
            // txtbuscarpor
            // 
            txtbuscarpor.AutoSize = true;
            txtbuscarpor.BackColor = Color.White;
            txtbuscarpor.Font = new Font("Segoe UI", 10F);
            txtbuscarpor.Location = new Point(809, 132);
            txtbuscarpor.Name = "txtbuscarpor";
            txtbuscarpor.Size = new Size(76, 19);
            txtbuscarpor.TabIndex = 86;
            txtbuscarpor.Text = "Buscar Por:";
            // 
            // frmReporteCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 779);
            Controls.Add(iconButton1);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(txtbuscarpor);
            Controls.Add(btnexportar);
            Controls.Add(dgvdata);
            Controls.Add(label4);
            Controls.Add(btnbuscar);
            Controls.Add(cboproveedor);
            Controls.Add(label3);
            Controls.Add(txtfechafin);
            Controls.Add(label2);
            Controls.Add(txtfechainicio);
            Controls.Add(label1);
            Controls.Add(label10);
            Name = "frmReporteCompras";
            Text = "frmReporteCompras";
            Load += frmReporteCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Label label1;
        private DateTimePicker txtfechainicio;
        private DateTimePicker txtfechafin;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private ComboBox cboproveedor;
        private Label label4;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistrado;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton btnexportar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private ComboBox cbobusqueda;
        private Label txtbuscarpor;
    }
}