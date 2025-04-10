namespace CapaPresentacion
{
    partial class frmProveedores
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

            SuspendLayout();
            // 

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
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
            label8 = new Label();
            txttelefono = new TextBox();
            label5 = new Label();
            txtcorreo = new TextBox();
            txtdocumento = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtnombrecompleto = new TextBox();
            txtrazonsocial = new TextBox();
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
            btnbuscar.Location = new Point(879, 49);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(45, 23);
            btnbuscar.TabIndex = 77;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Documento, RazonSocial, Correo, Telefono, EstadoValor, Estado });
            dgvdata.Location = new Point(243, 86);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(750, 427);
            dgvdata.TabIndex = 71;
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
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.Width = 180;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
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
            btnlimpiarbuscador.Location = new Point(930, 49);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(43, 23);
            btnlimpiarbuscador.TabIndex = 78;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(739, 49);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(135, 23);
            txtbusqueda.TabIndex = 76;
            // 
            // cbobusqueda
            // 
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(612, 49);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(121, 23);
            cbobusqueda.TabIndex = 75;
            // 
            // txtbuscarpor
            // 
            txtbuscarpor.AutoSize = true;
            txtbuscarpor.BackColor = Color.White;
            txtbuscarpor.Font = new Font("Segoe UI", 10F);
            txtbuscarpor.Location = new Point(539, 50);
            txtbuscarpor.Name = "txtbuscarpor";
            txtbuscarpor.Size = new Size(76, 19);
            txtbuscarpor.TabIndex = 74;
            txtbuscarpor.Text = "Buscar Por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(182, 60);
            txtid.Name = "txtid";
            txtid.Size = new Size(23, 23);
            txtid.TabIndex = 73;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(242, 25);
            label10.Name = "label10";
            label10.Padding = new Padding(6, 0, 0, 0);
            label10.Size = new Size(751, 58);
            label10.TabIndex = 72;
            label10.Text = "Lista de Proveedor:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            label10.Click += label10_Click;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(153, 60);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(23, 23);
            txtindice.TabIndex = 79;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(2, 16);
            label9.Name = "label9";
            label9.Size = new Size(219, 30);
            label9.TabIndex = 70;
            label9.Text = "Detalle de Proveedor";
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
            btneliminar.Location = new Point(11, 381);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(194, 23);
            btneliminar.TabIndex = 69;
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
            btnlimpiar.Location = new Point(11, 352);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(194, 23);
            btnlimpiar.TabIndex = 68;
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
            btnguardar.Location = new Point(11, 323);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(194, 23);
            btnguardar.TabIndex = 67;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(11, 278);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(194, 23);
            cboestado.TabIndex = 66;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(9, 256);
            label8.Name = "label8";
            label8.Size = new Size(53, 19);
            label8.TabIndex = 65;
            label8.Text = "Estado:";
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(11, 230);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(194, 23);
            txttelefono.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(11, 208);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 63;
            label5.Text = "Telefono:";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(11, 182);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(194, 23);
            txtcorreo.TabIndex = 62;
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(11, 86);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(194, 23);
            txtdocumento.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(11, 160);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 59;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(11, 112);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 58;
            label3.Text = "Razon Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 64);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 57;
            label2.Text = "Nro Documento:";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 557);
            label1.TabIndex = 56;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(11, 134);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(194, 23);
            txtnombrecompleto.TabIndex = 61;
            // 
            // txtrazonsocial
            // 
            txtrazonsocial.Location = new Point(12, 134);
            txtrazonsocial.Name = "txtrazonsocial";
            txtrazonsocial.Size = new Size(194, 23);
            txtrazonsocial.TabIndex = 80;
            // 

            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 461);
            ClientSize = new Size(1060, 557);
            Controls.Add(txtrazonsocial);
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
            Controls.Add(label8);
            Controls.Add(txttelefono);
            Controls.Add(label5);
            Controls.Add(txtcorreo);
            Controls.Add(txtdocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtnombrecompleto);
            Name = "frmProveedores";
            Text = "frmProveedores";
            Load += frmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
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
        private Label label8;
        private TextBox txttelefono;
        private Label label5;
        private TextBox txtcorreo;
        private TextBox txtdocumento;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtnombrecompleto;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private TextBox txtrazonsocial;
    }
}