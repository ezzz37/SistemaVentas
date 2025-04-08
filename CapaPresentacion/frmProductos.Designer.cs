namespace CapaPresentacion
{
    partial class frmProductos
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
            btnbuscar = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            txtbuscarpor = new Label();
            txtid = new TextBox();
            label10 = new Label();
            txtindice = new TextBox();
            label9 = new Label();
            btneliminar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            cboestado = new ComboBox();
            cbocategoria = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtdescripcion = new TextBox();
            txtnombre = new TextBox();
            txtcodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnexportar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
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
            btnbuscar.Location = new Point(1191, 67);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(45, 23);
            btnbuscar.TabIndex = 53;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click_1;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Codigo, Nombre, Descripcion, IdCategoria, Categoria, Stock, PrecioCompra, PrecioVenta, EstadoValor, Estado });
            dgvdata.Location = new Point(244, 127);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(1069, 427);
            dgvdata.TabIndex = 47;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 30;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 180;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 150;
            // 
            // IdCategoria
            // 
            IdCategoria.HeaderText = "IdCategoria";
            IdCategoria.Name = "IdCategoria";
            IdCategoria.ReadOnly = true;
            IdCategoria.Visible = false;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "PrecioCompra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "Estado Valor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
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
            btnlimpiarbuscador.Location = new Point(1242, 67);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(43, 23);
            btnlimpiarbuscador.TabIndex = 54;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(1050, 67);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(135, 23);
            txtbusqueda.TabIndex = 52;
            // 
            // cbobusqueda
            // 
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(923, 67);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(121, 23);
            cbobusqueda.TabIndex = 51;
            // 
            // txtbuscarpor
            // 
            txtbuscarpor.AutoSize = true;
            txtbuscarpor.BackColor = Color.White;
            txtbuscarpor.Font = new Font("Segoe UI", 10F);
            txtbuscarpor.Location = new Point(841, 67);
            txtbuscarpor.Name = "txtbuscarpor";
            txtbuscarpor.Size = new Size(76, 19);
            txtbuscarpor.TabIndex = 50;
            txtbuscarpor.Text = "Buscar Por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(183, 53);
            txtid.Name = "txtid";
            txtid.Size = new Size(23, 23);
            txtid.TabIndex = 49;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(244, 18);
            label10.Name = "label10";
            label10.Padding = new Padding(3, 6, 0, 0);
            label10.Size = new Size(1069, 84);
            label10.TabIndex = 48;
            label10.Text = "Lista de Productos:";
            // 
            // txtindice
            // 
            txtindice.Location = new Point(154, 53);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(23, 23);
            txtindice.TabIndex = 55;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(5, 9);
            label9.Name = "label9";
            label9.Size = new Size(216, 30);
            label9.TabIndex = 46;
            label9.Text = " Detalle del Producto";
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Red;
            btneliminar.Cursor = Cursors.Hand;
            btneliminar.FlatAppearance.BorderColor = Color.Black;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.ForeColor = Color.White;
            btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btneliminar.IconColor = Color.White;
            btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminar.IconSize = 18;
            btneliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btneliminar.Location = new Point(13, 384);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(194, 23);
            btneliminar.TabIndex = 45;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.MediumBlue;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatAppearance.BorderColor = Color.Black;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiar.IconColor = Color.White;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 18;
            btnlimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnlimpiar.Location = new Point(13, 355);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(194, 23);
            btnlimpiar.TabIndex = 44;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.ForestGreen;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderColor = Color.Black;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.ForeColor = Color.White;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardar.IconColor = Color.White;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 18;
            btnguardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnguardar.Location = new Point(13, 326);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(194, 23);
            btnguardar.TabIndex = 43;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click_1;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(13, 277);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(194, 23);
            cboestado.TabIndex = 42;
            // 
            // cbocategoria
            // 
            cbocategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbocategoria.FormattingEnabled = true;
            cbocategoria.Location = new Point(13, 229);
            cbocategoria.Name = "cbocategoria";
            cbocategoria.Size = new Size(194, 23);
            cbocategoria.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(13, 255);
            label8.Name = "label8";
            label8.Size = new Size(53, 19);
            label8.TabIndex = 40;
            label8.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(13, 207);
            label7.Name = "label7";
            label7.Size = new Size(68, 19);
            label7.TabIndex = 39;
            label7.Text = "Categoria";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(12, 175);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(194, 23);
            txtdescripcion.TabIndex = 34;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(12, 127);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(194, 23);
            txtnombre.TabIndex = 33;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(12, 79);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(194, 23);
            txtcodigo.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 153);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 31;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 30;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 29;
            label2.Text = "Codigo";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 692);
            label1.TabIndex = 28;
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
            btnexportar.Location = new Point(255, 67);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(142, 23);
            btnexportar.TabIndex = 56;
            btnexportar.Text = "Descargar Excel";
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 692);
            Controls.Add(btnexportar);
            Controls.Add(btnbuscar);
            Controls.Add(dgvdata);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(txtbuscarpor);
            Controls.Add(txtid);
            Controls.Add(label10);
            Controls.Add(txtindice);
            Controls.Add(label9);
            Controls.Add(btneliminar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(cboestado);
            Controls.Add(cbocategoria);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtdescripcion);
            Controls.Add(txtnombre);
            Controls.Add(txtcodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnbuscar;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private ComboBox cbobusqueda;
        private Label txtbuscarpor;
        private TextBox txtid;
        private Label label10;
        private TextBox txtindice;
        private Label label9;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private ComboBox cboestado;
        private ComboBox cbocategoria;
        private Label label8;
        private Label label7;
        private TextBox txtdescripcion;
        private TextBox txtnombre;
        private TextBox txtcodigo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton btnexportar;
    }
}