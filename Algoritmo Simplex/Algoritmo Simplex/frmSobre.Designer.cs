namespace Algoritmo_Simplex
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.pcbPuc = new System.Windows.Forms.PictureBox();
            this.pcbCopyright = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.txtDesenvolvedores = new System.Windows.Forms.TextBox();
            this.txtPuc = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCopyright)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPuc
            // 
            this.pcbPuc.BackColor = System.Drawing.Color.White;
            this.pcbPuc.Enabled = false;
            this.pcbPuc.Image = ((System.Drawing.Image)(resources.GetObject("pcbPuc.Image")));
            this.pcbPuc.Location = new System.Drawing.Point(118, 12);
            this.pcbPuc.Name = "pcbPuc";
            this.pcbPuc.Size = new System.Drawing.Size(96, 74);
            this.pcbPuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPuc.TabIndex = 9;
            this.pcbPuc.TabStop = false;
            // 
            // pcbCopyright
            // 
            this.pcbCopyright.Enabled = false;
            this.pcbCopyright.Image = ((System.Drawing.Image)(resources.GetObject("pcbCopyright.Image")));
            this.pcbCopyright.Location = new System.Drawing.Point(84, 234);
            this.pcbCopyright.Name = "pcbCopyright";
            this.pcbCopyright.Size = new System.Drawing.Size(21, 16);
            this.pcbCopyright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCopyright.TabIndex = 17;
            this.pcbCopyright.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Enabled = false;
            this.lblCopyright.Location = new System.Drawing.Point(105, 237);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(142, 13);
            this.lblCopyright.TabIndex = 16;
            this.lblCopyright.Text = "Todos os direitos reservados";
            // 
            // txtDesenvolvedores
            // 
            this.txtDesenvolvedores.BackColor = System.Drawing.Color.White;
            this.txtDesenvolvedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesenvolvedores.Enabled = false;
            this.txtDesenvolvedores.Location = new System.Drawing.Point(12, 150);
            this.txtDesenvolvedores.Multiline = true;
            this.txtDesenvolvedores.Name = "txtDesenvolvedores";
            this.txtDesenvolvedores.Size = new System.Drawing.Size(308, 83);
            this.txtDesenvolvedores.TabIndex = 15;
            this.txtDesenvolvedores.Text = "Versão 1.0.0\r\n\r\nDesenvolvedores:\r\nAmaury A. Costa\r\nShayane O. Santos";
            this.txtDesenvolvedores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPuc
            // 
            this.txtPuc.BackColor = System.Drawing.Color.White;
            this.txtPuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuc.Enabled = false;
            this.txtPuc.Location = new System.Drawing.Point(12, 92);
            this.txtPuc.Multiline = true;
            this.txtPuc.Name = "txtPuc";
            this.txtPuc.Size = new System.Drawing.Size(308, 54);
            this.txtPuc.TabIndex = 14;
            this.txtPuc.Text = "PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS \r\nUNIDADE BETIM\r\nCURSO DE SISTEM" +
    "AS DE INFORMAÇÃO\r\n7º PERÍODO - NOITE";
            this.txtPuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(128, 263);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 33);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 312);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pcbCopyright);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.txtDesenvolvedores);
            this.Controls.Add(this.txtPuc);
            this.Controls.Add(this.pcbPuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCopyright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPuc;
        private System.Windows.Forms.PictureBox pcbCopyright;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.TextBox txtDesenvolvedores;
        private System.Windows.Forms.TextBox txtPuc;
        private System.Windows.Forms.Button btnOK;
    }
}