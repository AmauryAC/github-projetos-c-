namespace PRJ_Distancia_entre_Cidades
{
    partial class frm_Entrada
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Entrada));
            this.pnl_Entrada = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.pbx_img = new System.Windows.Forms.PictureBox();
            this.tbx_Info = new System.Windows.Forms.TextBox();
            this.pbx_Puc = new System.Windows.Forms.PictureBox();
            this.tbx_Puc = new System.Windows.Forms.TextBox();
            this.pgb_Entrada = new System.Windows.Forms.ProgressBar();
            this.tmr_Entrada = new System.Windows.Forms.Timer(this.components);
            this.pnl_Entrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Puc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Entrada
            // 
            this.pnl_Entrada.BackColor = System.Drawing.Color.White;
            this.pnl_Entrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Entrada.Controls.Add(this.btn_Fechar);
            this.pnl_Entrada.Controls.Add(this.pbx_img);
            this.pnl_Entrada.Controls.Add(this.tbx_Info);
            this.pnl_Entrada.Controls.Add(this.pbx_Puc);
            this.pnl_Entrada.Controls.Add(this.tbx_Puc);
            this.pnl_Entrada.Controls.Add(this.pgb_Entrada);
            this.pnl_Entrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Entrada.Location = new System.Drawing.Point(0, 0);
            this.pnl_Entrada.Name = "pnl_Entrada";
            this.pnl_Entrada.Size = new System.Drawing.Size(547, 279);
            this.pnl_Entrada.TabIndex = 0;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.White;
            this.btn_Fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.Image")));
            this.btn_Fechar.Location = new System.Drawing.Point(526, 0);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(21, 22);
            this.btn_Fechar.TabIndex = 10;
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // pbx_img
            // 
            this.pbx_img.BackColor = System.Drawing.Color.White;
            this.pbx_img.Enabled = false;
            this.pbx_img.Image = ((System.Drawing.Image)(resources.GetObject("pbx_img.Image")));
            this.pbx_img.Location = new System.Drawing.Point(116, 80);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(302, 151);
            this.pbx_img.TabIndex = 9;
            this.pbx_img.TabStop = false;
            // 
            // tbx_Info
            // 
            this.tbx_Info.BackColor = System.Drawing.Color.White;
            this.tbx_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Info.Enabled = false;
            this.tbx_Info.Location = new System.Drawing.Point(412, 245);
            this.tbx_Info.Multiline = true;
            this.tbx_Info.Name = "tbx_Info";
            this.tbx_Info.Size = new System.Drawing.Size(123, 27);
            this.tbx_Info.TabIndex = 8;
            this.tbx_Info.Text = "                  Versão 1.0.0\r\nPowered by: PUC Minas";
            // 
            // pbx_Puc
            // 
            this.pbx_Puc.BackColor = System.Drawing.Color.White;
            this.pbx_Puc.Enabled = false;
            this.pbx_Puc.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Puc.Image")));
            this.pbx_Puc.Location = new System.Drawing.Point(10, 7);
            this.pbx_Puc.Name = "pbx_Puc";
            this.pbx_Puc.Size = new System.Drawing.Size(96, 74);
            this.pbx_Puc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Puc.TabIndex = 7;
            this.pbx_Puc.TabStop = false;
            // 
            // tbx_Puc
            // 
            this.tbx_Puc.BackColor = System.Drawing.Color.White;
            this.tbx_Puc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Puc.Enabled = false;
            this.tbx_Puc.Location = new System.Drawing.Point(129, 8);
            this.tbx_Puc.Multiline = true;
            this.tbx_Puc.Name = "tbx_Puc";
            this.tbx_Puc.Size = new System.Drawing.Size(308, 74);
            this.tbx_Puc.TabIndex = 6;
            this.tbx_Puc.Text = "\r\nPONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS \r\nUNIDADE BETIM\r\nCURSO DE SIST" +
    "EMAS DE INFORMAÇÃO\r\n4º PERÍODO - NOITE";
            this.tbx_Puc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pgb_Entrada
            // 
            this.pgb_Entrada.Location = new System.Drawing.Point(12, 239);
            this.pgb_Entrada.Name = "pgb_Entrada";
            this.pgb_Entrada.Size = new System.Drawing.Size(394, 35);
            this.pgb_Entrada.TabIndex = 0;
            // 
            // tmr_Entrada
            // 
            this.tmr_Entrada.Enabled = true;
            this.tmr_Entrada.Tick += new System.EventHandler(this.tmr_Entrada_Tick);
            // 
            // frm_Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 279);
            this.Controls.Add(this.pnl_Entrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Entrada.ResumeLayout(false);
            this.pnl_Entrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Puc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Entrada;
        private System.Windows.Forms.ProgressBar pgb_Entrada;
        private System.Windows.Forms.Timer tmr_Entrada;
        private System.Windows.Forms.PictureBox pbx_Puc;
        private System.Windows.Forms.TextBox tbx_Info;
        private System.Windows.Forms.TextBox tbx_Puc;
        private System.Windows.Forms.PictureBox pbx_img;
        private System.Windows.Forms.Button btn_Fechar;
    }
}

