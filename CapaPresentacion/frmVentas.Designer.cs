namespace CapaPresentacion
{
    partial class frmVentas
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
            btnregistrar = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            btnagregar = new FontAwesome.Sharp.IconButton();
            txtproducto = new TextBox();
            txttotalapagar = new TextBox();
            txtcantidadproducto = new NumericUpDown();
            groupBox3 = new GroupBox();
            label11 = new Label();
            label9 = new Label();
            txtstockproducto = new TextBox();
            label8 = new Label();
            txtprecioproducto = new TextBox();
            txtidproducto = new TextBox();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            txtcodproducto = new TextBox();
            label6 = new Label();
            label7 = new Label();
            buscarcliente = new FontAwesome.Sharp.IconButton();
            groupBox2 = new GroupBox();
            txtnombrecliente = new TextBox();
            txtidproveedor = new TextBox();
            txtdocumentocliente = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbotipodocumento = new ComboBox();
            txtfecha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            dgvdata = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            label10 = new Label();
            label13 = new Label();
            txtpagacon = new TextBox();
            label14 = new Label();
            txtcambio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtcantidadproducto).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // btnregistrar
            // 
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnregistrar.IconColor = Color.RoyalBlue;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.IconSize = 35;
            btnregistrar.Location = new Point(937, 532);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(136, 37);
            btnregistrar.TabIndex = 40;
            btnregistrar.Text = "Crear Venta";
            btnregistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(937, 322);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 38;
            label12.Text = "Total a Pagar:";
            // 
            // btnagregar
            // 
            btnagregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnagregar.IconColor = Color.DarkGreen;
            btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregar.Location = new Point(927, 214);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(136, 79);
            btnagregar.TabIndex = 37;
            btnagregar.Text = "Agregar";
            btnagregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(303, 51);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(203, 23);
            txtproducto.TabIndex = 34;
            // 
            // txttotalapagar
            // 
            txttotalapagar.Location = new Point(937, 345);
            txttotalapagar.Name = "txttotalapagar";
            txttotalapagar.Size = new Size(136, 23);
            txttotalapagar.TabIndex = 39;
            txttotalapagar.Text = "0";
            // 
            // txtcantidadproducto
            // 
            txtcantidadproducto.Location = new Point(744, 50);
            txtcantidadproducto.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtcantidadproducto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtcantidadproducto.Name = "txtcantidadproducto";
            txtcantidadproducto.Size = new Size(97, 23);
            txtcantidadproducto.TabIndex = 33;
            txtcantidadproducto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(txtcantidadproducto);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtstockproducto);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtprecioproducto);
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(btnbuscarproducto);
            groupBox3.Controls.Add(txtcodproducto);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(70, 205);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(851, 88);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion de Producto";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(743, 28);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 32;
            label11.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(628, 28);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 31;
            label9.Text = "stock:";
            // 
            // txtstockproducto
            // 
            txtstockproducto.Location = new Point(628, 50);
            txtstockproducto.Name = "txtstockproducto";
            txtstockproducto.Size = new Size(110, 23);
            txtstockproducto.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(512, 28);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 29;
            label8.Text = "Precio:";
            // 
            // txtprecioproducto
            // 
            txtprecioproducto.Location = new Point(512, 50);
            txtprecioproducto.Name = "txtprecioproducto";
            txtprecioproducto.Size = new Size(110, 23);
            txtprecioproducto.TabIndex = 28;
            txtprecioproducto.KeyPress += txtprecioproducto_KeyPress;
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(205, 25);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(41, 23);
            txtidproducto.TabIndex = 27;
            txtidproducto.Visible = false;
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.BackColor = Color.White;
            btnbuscarproducto.Cursor = Cursors.Hand;
            btnbuscarproducto.FlatAppearance.BorderColor = Color.Black;
            btnbuscarproducto.FlatStyle = FlatStyle.Flat;
            btnbuscarproducto.ForeColor = Color.Transparent;
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproducto.IconColor = Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproducto.IconSize = 18;
            btnbuscarproducto.Location = new Point(252, 50);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(45, 23);
            btnbuscarproducto.TabIndex = 26;
            btnbuscarproducto.UseVisualStyleBackColor = false;
            btnbuscarproducto.Click += btnbuscarproducto_Click;
            // 
            // txtcodproducto
            // 
            txtcodproducto.Location = new Point(15, 51);
            txtcodproducto.Name = "txtcodproducto";
            txtcodproducto.Size = new Size(231, 23);
            txtcodproducto.TabIndex = 2;
            txtcodproducto.KeyDown += txtcodproducto_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(303, 28);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 1;
            label6.Text = "Producto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(15, 28);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 0;
            label7.Text = "Cod.Producto:";
            // 
            // buscarcliente
            // 
            buscarcliente.BackColor = Color.White;
            buscarcliente.Cursor = Cursors.Hand;
            buscarcliente.FlatAppearance.BorderColor = Color.Black;
            buscarcliente.FlatStyle = FlatStyle.Flat;
            buscarcliente.ForeColor = Color.Transparent;
            buscarcliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            buscarcliente.IconColor = Color.Black;
            buscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buscarcliente.IconSize = 18;
            buscarcliente.Location = new Point(205, 51);
            buscarcliente.Name = "buscarcliente";
            buscarcliente.Size = new Size(44, 23);
            buscarcliente.TabIndex = 26;
            buscarcliente.UseVisualStyleBackColor = false;
            buscarcliente.Click += buscarcliente_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtnombrecliente);
            groupBox2.Controls.Add(txtidproveedor);
            groupBox2.Controls.Add(buscarcliente);
            groupBox2.Controls.Add(txtdocumentocliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(548, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(515, 88);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Cliente";
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(271, 51);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.Size = new Size(228, 23);
            txtnombrecliente.TabIndex = 28;
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(461, 25);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(38, 23);
            txtidproveedor.TabIndex = 27;
            txtidproveedor.Visible = false;
            // 
            // txtdocumentocliente
            // 
            txtdocumentocliente.Location = new Point(6, 51);
            txtdocumentocliente.Name = "txtdocumentocliente";
            txtdocumentocliente.Size = new Size(193, 23);
            txtdocumentocliente.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(271, 29);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 1;
            label4.Text = "Nombre Completo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(6, 29);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 0;
            label5.Text = "Numero Documento:";
            // 
            // cbotipodocumento
            // 
            cbotipodocumento.FormattingEnabled = true;
            cbotipodocumento.Location = new Point(220, 52);
            cbotipodocumento.Name = "cbotipodocumento";
            cbotipodocumento.Size = new Size(235, 23);
            cbotipodocumento.TabIndex = 3;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(15, 51);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(182, 23);
            txtfecha.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(220, 28);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 1;
            label3.Text = "Tipo Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(15, 28);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Fecha:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(70, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 88);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Venta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(70, 56);
            label1.Name = "label1";
            label1.Size = new Size(195, 37);
            label1.TabIndex = 32;
            label1.Text = "Registrar Venta";
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, btneliminar });
            dgvdata.Location = new Point(70, 299);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(851, 270);
            dgvdata.TabIndex = 36;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 180;
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
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.Name = "btneliminar";
            btneliminar.ReadOnly = true;
            btneliminar.Width = 30;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(43, 35);
            label10.Name = "label10";
            label10.Padding = new Padding(2, 0, 0, 0);
            label10.Size = new Size(1050, 556);
            label10.TabIndex = 31;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 11F);
            label13.Location = new Point(937, 411);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 41;
            label13.Text = "Paga con:";
            // 
            // txtpagacon
            // 
            txtpagacon.Location = new Point(937, 434);
            txtpagacon.Name = "txtpagacon";
            txtpagacon.Size = new Size(136, 23);
            txtpagacon.TabIndex = 42;
            txtpagacon.KeyDown += txtpagacon_KeyDown;
            txtpagacon.KeyPress += txtpagacon_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 11F);
            label14.Location = new Point(937, 464);
            label14.Name = "label14";
            label14.Size = new Size(64, 20);
            label14.TabIndex = 43;
            label14.Text = "Cambio:";
            // 
            // txtcambio
            // 
            txtcambio.Location = new Point(937, 487);
            txtcambio.Name = "txtcambio";
            txtcambio.Size = new Size(136, 23);
            txtcambio.TabIndex = 44;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 622);
            Controls.Add(label14);
            Controls.Add(txtcambio);
            Controls.Add(label13);
            Controls.Add(txtpagacon);
            Controls.Add(btnregistrar);
            Controls.Add(label12);
            Controls.Add(btnagregar);
            Controls.Add(txttotalapagar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dgvdata);
            Controls.Add(label10);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)txtcantidadproducto).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnregistrar;
        private Label label12;
        private FontAwesome.Sharp.IconButton btnagregar;
        private TextBox txtproducto;
        private TextBox txttotalapagar;
        private NumericUpDown txtcantidadproducto;
        private GroupBox groupBox3;
        private Label label11;
        private Label label9;
        private TextBox txtstockproducto;
        private Label label8;
        private TextBox txtprecioproducto;
        private TextBox txtidproducto;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private TextBox txtcodproducto;
        private Label label6;
        private Label label7;
        private FontAwesome.Sharp.IconButton buscarcliente;
        private GroupBox groupBox2;
        private TextBox txtnombrecliente;
        private TextBox txtidproveedor;
        private TextBox txtdocumentocliente;
        private Label label4;
        private Label label5;
        private ComboBox cbotipodocumento;
        private TextBox txtfecha;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dgvdata;
        private Label label10;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btneliminar;
        private Label label13;
        private TextBox txtpagacon;
        private Label label14;
        private TextBox txtcambio;
    }
}