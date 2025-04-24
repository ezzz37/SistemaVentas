namespace CapaPresentacion
{
    partial class frmDetalleDeVenta
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
            txtguardar = new FontAwesome.Sharp.IconButton();
            txtmontototal = new TextBox();
            label5 = new Label();
            dgvdata = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtlable = new TextBox();
            txtnombrecliente = new TextBox();
            txtdoccliente = new TextBox();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtusuario = new TextBox();
            txttipodocumento = new TextBox();
            txtfecha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtnumerodocumento = new TextBox();
            txtbuscarpor = new Label();
            label1 = new Label();
            label10 = new Label();
            txtmontopago = new TextBox();
            label8 = new Label();
            txtmontocambio = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtguardar
            // 
            txtguardar.Font = new Font("Segoe UI", 10F);
            txtguardar.IconChar = FontAwesome.Sharp.IconChar.Download;
            txtguardar.IconColor = Color.Black;
            txtguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            txtguardar.IconSize = 25;
            txtguardar.Location = new Point(802, 589);
            txtguardar.Name = "txtguardar";
            txtguardar.Size = new Size(154, 31);
            txtguardar.TabIndex = 77;
            txtguardar.Text = "Descargar PDF";
            txtguardar.TextAlign = ContentAlignment.MiddleRight;
            txtguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            txtguardar.UseVisualStyleBackColor = true;
            txtguardar.Click += txtguardar_Click;
            // 
            // txtmontototal
            // 
            txtmontototal.Location = new Point(394, 593);
            txtmontototal.Name = "txtmontototal";
            txtmontototal.Size = new Size(56, 23);
            txtmontototal.TabIndex = 76;
            txtmontototal.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(295, 593);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 75;
            label5.Text = "Monto Total:";
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, SubTotal });
            dgvdata.Location = new Point(295, 303);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(661, 270);
            dgvdata.TabIndex = 74;
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtlable);
            groupBox2.Controls.Add(txtnombrecliente);
            groupBox2.Controls.Add(txtdoccliente);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(295, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(661, 88);
            groupBox2.TabIndex = 73;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Cliente";
            // 
            // txtlable
            // 
            txtlable.Location = new Point(582, 51);
            txtlable.Name = "txtlable";
            txtlable.Size = new Size(62, 23);
            txtlable.TabIndex = 4;
            txtlable.Visible = false;
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(220, 51);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.Size = new Size(201, 23);
            txtnombrecliente.TabIndex = 3;
            // 
            // txtdoccliente
            // 
            txtdoccliente.Location = new Point(15, 51);
            txtdoccliente.Name = "txtdoccliente";
            txtdoccliente.Size = new Size(182, 23);
            txtdoccliente.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(220, 28);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 1;
            label6.Text = "Nombre Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(15, 28);
            label7.Name = "label7";
            label7.Size = new Size(140, 20);
            label7.TabIndex = 0;
            label7.Text = "Documento Cliente:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(txttipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(295, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(661, 88);
            groupBox1.TabIndex = 72;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(437, 28);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 5;
            label4.Text = "Usuario:";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(437, 51);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(207, 23);
            txtusuario.TabIndex = 4;
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(220, 51);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.Size = new Size(201, 23);
            txttipodocumento.TabIndex = 3;
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
            btnbuscar.Location = new Point(862, 62);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(45, 23);
            btnbuscar.TabIndex = 70;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
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
            btnlimpiarbuscador.Location = new Point(913, 62);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(43, 23);
            btnlimpiarbuscador.TabIndex = 71;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(676, 62);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(180, 23);
            txtnumerodocumento.TabIndex = 69;
            // 
            // txtbuscarpor
            // 
            txtbuscarpor.AutoSize = true;
            txtbuscarpor.BackColor = Color.White;
            txtbuscarpor.Font = new Font("Segoe UI", 10F);
            txtbuscarpor.Location = new Point(532, 62);
            txtbuscarpor.Name = "txtbuscarpor";
            txtbuscarpor.Size = new Size(138, 19);
            txtbuscarpor.TabIndex = 68;
            txtbuscarpor.Text = "Numero Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(295, 22);
            label1.Name = "label1";
            label1.Size = new Size(212, 37);
            label1.TabIndex = 67;
            label1.Text = "Detalle de Venta";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(277, 9);
            label10.Name = "label10";
            label10.Padding = new Padding(2, 0, 0, 0);
            label10.Size = new Size(709, 662);
            label10.TabIndex = 66;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtmontopago
            // 
            txtmontopago.Location = new Point(555, 594);
            txtmontopago.Name = "txtmontopago";
            txtmontopago.Size = new Size(56, 23);
            txtmontopago.TabIndex = 79;
            txtmontopago.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(456, 594);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 78;
            label8.Text = "Monto Pago:";
            // 
            // txtmontocambio
            // 
            txtmontocambio.Location = new Point(732, 594);
            txtmontocambio.Name = "txtmontocambio";
            txtmontocambio.Size = new Size(56, 23);
            txtmontocambio.TabIndex = 81;
            txtmontocambio.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(617, 594);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 80;
            label9.Text = "Monto Cambio:";
            // 
            // frmDetalleDeVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 703);
            Controls.Add(txtmontocambio);
            Controls.Add(label9);
            Controls.Add(txtmontopago);
            Controls.Add(label8);
            Controls.Add(txtguardar);
            Controls.Add(txtmontototal);
            Controls.Add(label5);
            Controls.Add(dgvdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtnumerodocumento);
            Controls.Add(txtbuscarpor);
            Controls.Add(label1);
            Controls.Add(label10);
            Name = "frmDetalleDeVenta";
            Text = "frmDetalleDeVenta";
            Load += frmDetalleDeVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton txtguardar;
        private TextBox txtmontototal;
        private Label label5;
        private DataGridView dgvdata;
        private GroupBox groupBox2;
        private TextBox txtlable;
        private TextBox txtnombrecliente;
        private TextBox txtdoccliente;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtusuario;
        private TextBox txttipodocumento;
        private TextBox txtfecha;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtnumerodocumento;
        private Label txtbuscarpor;
        private Label label1;
        private Label label10;
        private TextBox txtmontopago;
        private Label label8;
        private TextBox txtmontocambio;
        private Label label9;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}