namespace PRJ_Distancia_entre_Cidades
{
    partial class frm_Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sobre));
            this.pnl_Sobre = new System.Windows.Forms.Panel();
            this.tbx_Desenvolvedores = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tbx_Puc = new System.Windows.Forms.TextBox();
            this.pbx_Puc = new System.Windows.Forms.PictureBox();
            this.pnl_Sobre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Puc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Sobre
            // 
            this.pnl_Sobre.BackColor = System.Drawing.Color.White;
            this.pnl_Sobre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Sobre.Controls.Add(this.tbx_Desenvolvedores);
            this.pnl_Sobre.Controls.Add(this.btn_OK);
            this.pnl_Sobre.Controls.Add(this.tbx_Puc);
            this.pnl_Sobre.Controls.Add(this.pbx_Puc);
            this.pnl_Sobre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Sobre.Location = new System.Drawing.Point(0, 0);
            this.pnl_Sobre.Name = "pnl_Sobre";
            this.pnl_Sobre.Size = new System.Drawing.Size(314, 292);
            this.pnl_Sobre.TabIndex = 0;
            // 
            // tbx_Desenvolvedores
            // 
            this.tbx_Desenvolvedores.BackColor = System.Drawing.Color.White;
            this.tbx_Desenvolvedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Desenvolvedores.Enabled = false;
            this.tbx_Desenvolvedores.Location = new System.Drawing.Point(3, 143);
            this.tbx_Desenvolvedores.Multiline = true;
            this.tbx_Desenvolvedores.Name = "tbx_Desenvolvedores";
            this.tbx_Desenvolvedores.Size = new System.Drawing.Size(308, 106);
            this.tbx_Desenvolvedores.TabIndex = 11;
            this.tbx_Desenvolvedores.Text = "Versão 1.0.0\r\n\r\nDesenvolvedores:\r\nAmaury Alexandrino da Costa - 499960\r\nFelipe He" +
    "nrique Rocha - 495779\r\nJoão Fernando - 499972\r\n\r\nObrigado por usar esse Software" +
    "!!!";
            this.tbx_Desenvolvedores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(123, 252);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 33);
            this.btn_OK.TabIndex = 10;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tbx_Puc
            // 
            this.tbx_Puc.BackColor = System.Drawing.Color.White;
            this.tbx_Puc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Puc.Enabled = false;
            this.tbx_Puc.Location = new System.Drawing.Point(3, 83);
            this.tbx_Puc.Multiline = true;
            this.tbx_Puc.Name = "tbx_Puc";
            this.tbx_Puc.Size = new System.Drawing.Size(308, 54);
            this.tbx_Puc.TabIndex = 9;
            this.tbx_Puc.Text = "PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS \r\nUNIDADE BETIM\r\nCURSO DE SISTEM" +
    "AS DE INFORMAÇÃO\r\n4º PERÍODO - NOITE";
            this.tbx_Puc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbx_Puc
            // 
            this.pbx_Puc.BackColor = System.Drawing.Color.White;
            this.pbx_Puc.Enabled = false;
            this.pbx_Puc.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Puc.Image")));
            this.pbx_Puc.Location = new System.Drawing.Point(106, 4);
            this.pbx_Puc.Name = "pbx_Puc";
            this.pbx_Puc.Size = new System.Drawing.Size(96, 74);
            this.pbx_Puc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Puc.TabIndex = 8;
            this.pbx_Puc.TabStop = false;
            // 
            // frm_Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 292);
            this.Controls.Add(this.pnl_Sobre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.pnl_Sobre.ResumeLayout(false);
            this.pnl_Sobre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Puc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Sobre;
        private System.Windows.Forms.PictureBox pbx_Puc;
        private System.Windows.Forms.TextBox tbx_Desenvolvedores;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox tbx_Puc;
    }
}