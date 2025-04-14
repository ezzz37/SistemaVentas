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
            txtdireccion = new TextBox();
            btnguardarcambios = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            txtruc = new TextBox();
            label5 = new Label();
            txtnombrenegocio = new TextBox();
            label3 = new Label();
            btnsubir = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            piclogo = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(23, 23);
            label9.Name = "label9";
            label9.Size = new Size(168, 30);
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
            label1.Size = new Size(640, 407);
            label1.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(btnguardarcambios);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtruc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtnombrenegocio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnsubir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(piclogo);
            groupBox1.Location = new Point(23, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 296);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(274, 177);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(255, 23);
            txtdireccion.TabIndex = 24;
            // 
            // btnguardarcambios
            // 
            btnguardarcambios.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardarcambios.IconColor = Color.Black;
            btnguardarcambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarcambios.IconSize = 25;
            btnguardarcambios.ImageAlign = ContentAlignment.MiddleLeft;
            btnguardarcambios.Location = new Point(274, 206);
            btnguardarcambios.Name = "btnguardarcambios";
            btnguardarcambios.Size = new Size(255, 30);
            btnguardarcambios.TabIndex = 23;
            btnguardarcambios.Text = "Guardar Cambios";
            btnguardarcambios.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(274, 150);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 22;
            label4.Text = "Direccion:";
            // 
            // txtruc
            // 
            txtruc.Location = new Point(274, 124);
            txtruc.Name = "txtruc";
            txtruc.Size = new Size(255, 23);
            txtruc.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(274, 100);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 5;
            label5.Text = "RUC:";
            // 
            // txtnombrenegocio
            // 
            txtnombrenegocio.Location = new Point(274, 74);
            txtnombrenegocio.Name = "txtnombrenegocio";
            txtnombrenegocio.Size = new Size(255, 23);
            txtnombrenegocio.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(274, 50);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 3;
            label3.Text = "Nombre Negocio:";
            // 
            // btnsubir
            // 
            btnsubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnsubir.IconColor = Color.Black;
            btnsubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsubir.IconSize = 25;
            btnsubir.ImageAlign = ContentAlignment.MiddleLeft;
            btnsubir.Location = new Point(20, 206);
            btnsubir.Name = "btnsubir";
            btnsubir.Size = new Size(188, 30);
            btnsubir.TabIndex = 2;
            btnsubir.Text = "Subir";
            btnsubir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(20, 19);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 1;
            label2.Text = "Logo:";
            // 
            // piclogo
            // 
            piclogo.BorderStyle = BorderStyle.FixedSingle;
            piclogo.Location = new Point(20, 50);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(188, 150);
            piclogo.TabIndex = 0;
            piclogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 407);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "frmNegocio";
            Text = "frmNegocio";
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
        private Label label2;
        private PictureBox piclogo;
        private FontAwesome.Sharp.IconButton btnsubir;
        private TextBox txtnombrenegocio;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnguardarcambios;
        private Label label4;
        private TextBox txtruc;
        private Label label5;
        private TextBox txtdireccion;
    }
}