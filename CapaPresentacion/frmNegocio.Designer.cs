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
            piclogo = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            btnsubir = new FontAwesome.Sharp.IconButton();
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
            label1.Size = new Size(614, 531);
            label1.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnsubir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(piclogo);
            groupBox1.Location = new Point(29, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 427);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
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
            piclogo.TabIndex = 0;
            piclogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 29);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Logo";
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
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 531);
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
    }
}