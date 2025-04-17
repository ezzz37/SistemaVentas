namespace CapaPresentacion
{
    partial class frmCompras
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
            groupBox1 = new GroupBox();
            cbotipodocumento = new ComboBox();
            txtfecha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtnombreproveedor = new ComboBox();
            txtdocproveedor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            txtidproveedor = new TextBox();
            btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            groupBox3 = new GroupBox();
            txtproducto = new TextBox();
            numcantidad = new NumericUpDown();
            label11 = new Label();
            label9 = new Label();
            txtprecioventa = new TextBox();
            label8 = new Label();
            txtpreciocompra = new TextBox();
            txtidproducto = new TextBox();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            txtcodproducto = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dgvdata = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            btnagregar = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            txttotalapagar = new TextBox();
            btnregistrar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numcantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(50, 27);
            label10.Name = "label10";
            label10.Padding = new Padding(2, 0, 0, 0);
            label10.Size = new Size(1041, 556);
            label10.TabIndex = 21;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(77, 48);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 22;
            label1.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(77, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 88);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Compra";
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
            // txtnombreproveedor
            // 
            txtnombreproveedor.FormattingEnabled = true;
            txtnombreproveedor.Location = new Point(271, 51);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.Size = new Size(228, 23);
            txtnombreproveedor.TabIndex = 3;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(6, 51);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.Size = new Size(193, 23);
            txtdocproveedor.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(271, 29);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 1;
            label4.Text = "Razon Social:";
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtidproveedor);
            groupBox2.Controls.Add(btnbuscarproveedor);
            groupBox2.Controls.Add(txtnombreproveedor);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(555, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(515, 88);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Proveedor";
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(461, 25);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(38, 23);
            txtidproveedor.TabIndex = 27;
            // 
            // btnbuscarproveedor
            // 
            btnbuscarproveedor.BackColor = Color.White;
            btnbuscarproveedor.Cursor = Cursors.Hand;
            btnbuscarproveedor.FlatAppearance.BorderColor = Color.Black;
            btnbuscarproveedor.FlatStyle = FlatStyle.Flat;
            btnbuscarproveedor.ForeColor = Color.Transparent;
            btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproveedor.IconColor = Color.Black;
            btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproveedor.IconSize = 18;
            btnbuscarproveedor.Location = new Point(205, 51);
            btnbuscarproveedor.Name = "btnbuscarproveedor";
            btnbuscarproveedor.Size = new Size(44, 23);
            btnbuscarproveedor.TabIndex = 26;
            btnbuscarproveedor.UseVisualStyleBackColor = false;
            btnbuscarproveedor.Click += btnbuscarproveedor_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(numcantidad);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtprecioventa);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtpreciocompra);
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(btnbuscarproducto);
            groupBox3.Controls.Add(txtcodproducto);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(77, 197);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(851, 88);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion Proveedor";
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(303, 51);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(203, 23);
            txtproducto.TabIndex = 34;
            // 
            // numcantidad
            // 
            numcantidad.Location = new Point(744, 50);
            numcantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numcantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numcantidad.Name = "numcantidad";
            numcantidad.Size = new Size(97, 23);
            numcantidad.TabIndex = 33;
            numcantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            label9.Size = new Size(94, 20);
            label9.TabIndex = 31;
            label9.Text = "Precio Venta:";
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(628, 50);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(110, 23);
            txtprecioventa.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(512, 28);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 29;
            label8.Text = "Precio Compra:";
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(512, 50);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(110, 23);
            txtpreciocompra.TabIndex = 28;
            txtpreciocompra.KeyPress += txtpreciocompra_KeyPress;
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(205, 25);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(41, 23);
            txtidproducto.TabIndex = 27;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, SubTotal, btneliminar });
            dgvdata.Location = new Point(77, 291);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(851, 270);
            dgvdata.TabIndex = 26;
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
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 180;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Visible = false;
            PrecioVenta.Width = 150;
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
            // btnagregar
            // 
            btnagregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnagregar.IconColor = Color.DarkGreen;
            btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregar.Location = new Point(934, 206);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(136, 79);
            btnagregar.TabIndex = 27;
            btnagregar.Text = "Agregar";
            btnagregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(934, 472);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 28;
            label12.Text = "Total a Pagar:";
            // 
            // txttotalapagar
            // 
            txttotalapagar.Location = new Point(934, 495);
            txttotalapagar.Name = "txttotalapagar";
            txttotalapagar.Size = new Size(136, 23);
            txttotalapagar.TabIndex = 29;
            txttotalapagar.Text = "0";
            // 
            // btnregistrar
            // 
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnregistrar.IconColor = Color.RoyalBlue;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.IconSize = 35;
            btnregistrar.Location = new Point(934, 524);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(136, 37);
            btnregistrar.TabIndex = 30;
            btnregistrar.Text = "Registrar";
            btnregistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregistrar.UseVisualStyleBackColor = true;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 649);
            Controls.Add(btnregistrar);
            Controls.Add(txttotalapagar);
            Controls.Add(label12);
            Controls.Add(btnagregar);
            Controls.Add(dgvdata);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label10);
            Name = "frmCompras";
            Text = " ";
            Load += frmCompras_Load;
            KeyPress += frmCompras_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numcantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbotipodocumento;
        private TextBox txtfecha;
        private Label label3;
        private Label label2;
        private ComboBox txtnombreproveedor;
        private TextBox txtdocproveedor;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private TextBox txtidproveedor;
        private GroupBox groupBox3;
        private TextBox txtidproducto;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private TextBox txtcodproducto;
        private Label label6;
        private Label label7;
        private NumericUpDown numcantidad;
        private Label label11;
        private Label label9;
        private TextBox txtprecioventa;
        private Label label8;
        private TextBox txtpreciocompra;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnagregar;
        private Label label12;
        private TextBox txttotalapagar;
        private FontAwesome.Sharp.IconButton btnregistrar;
        private TextBox txtproducto;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btneliminar;
    }
}