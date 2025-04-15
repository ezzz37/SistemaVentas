namespace CapaPresentacion
{
    partial class frmNegocio
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
            label9 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtguardar = new FontAwesome.Sharp.IconButton();
            txtdireccion = new TextBox();
            txtruc = new TextBox();
            txtnombrenegocio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnsubir = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            piclogo = new FontAwesome.Sharp.IconPictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(209, 37);
            label9.TabIndex = 20;
            label9.Text = "Detalle Negocio";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(687, 392);
            label1.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtguardar);
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(txtruc);
            groupBox1.Controls.Add(txtnombrenegocio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnsubir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(piclogo);
            groupBox1.Location = new Point(29, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 285);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // txtguardar
            // 
            txtguardar.Font = new Font("Segoe UI", 10F);
            txtguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            txtguardar.IconColor = Color.Black;
            txtguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            txtguardar.IconSize = 25;
            txtguardar.Location = new Point(269, 196);
            txtguardar.Name = "txtguardar";
            txtguardar.Size = new Size(314, 28);
            txtguardar.TabIndex = 13;
            txtguardar.Text = "Guardar";
            txtguardar.TextAlign = ContentAlignment.MiddleRight;
            txtguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            txtguardar.UseVisualStyleBackColor = true;
            txtguardar.Click += txtguardar_Click;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(267, 152);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(316, 23);
            txtdireccion.TabIndex = 12;
            // 
            // txtruc
            // 
            txtruc.Location = new Point(267, 104);
            txtruc.Name = "txtruc";
            txtruc.Size = new Size(316, 23);
            txtruc.TabIndex = 11;
            // 
            // txtnombrenegocio
            // 
            txtnombrenegocio.Location = new Point(267, 56);
            txtnombrenegocio.Name = "txtnombrenegocio";
            txtnombrenegocio.Size = new Size(316, 23);
            txtnombrenegocio.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(267, 130);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 9;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(267, 82);
            label3.Name = "label3";
            label3.Size = new Size(45, 19);
            label3.TabIndex = 8;
            label3.Text = "R.U.C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(267, 34);
            label5.Name = "label5";
            label5.Size = new Size(116, 19);
            label5.TabIndex = 7;
            label5.Text = "Nombre Negocio:";
            // 
            // btnsubir
            // 
            btnsubir.Font = new Font("Segoe UI", 10F);
            btnsubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnsubir.IconColor = Color.Black;
            btnsubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsubir.IconSize = 25;
            btnsubir.Location = new Point(26, 212);
            btnsubir.Name = "btnsubir";
            btnsubir.Size = new Size(192, 28);
            btnsubir.TabIndex = 2;
            btnsubir.Text = "Subir";
            btnsubir.TextAlign = ContentAlignment.MiddleRight;
            btnsubir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsubir.UseVisualStyleBackColor = true;
            btnsubir.Click += btnsubir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(26, 29);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Logo";
            // 
            // piclogo
            // 
            piclogo.BackColor = Color.White;
            piclogo.BorderStyle = BorderStyle.FixedSingle;
            piclogo.ForeColor = SystemColors.ControlText;
            piclogo.IconChar = FontAwesome.Sharp.IconChar.None;
            piclogo.IconColor = SystemColors.ControlText;
            piclogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            piclogo.IconSize = 138;
            piclogo.Location = new Point(26, 56);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(192, 138);
            piclogo.SizeMode = PictureBoxSizeMode.StretchImage;
            piclogo.TabIndex = 0;
            piclogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 392);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "frmNegocio";
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnsubir;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox piclogo;
        private FontAwesome.Sharp.IconButton txtguardar;
        private TextBox txtdireccion;
        private TextBox txtruc;
        private TextBox txtnombrenegocio;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}