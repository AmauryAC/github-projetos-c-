namespace Jogo_da_Memoria_1._0._0
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
            this.btn_Jogar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx_Fundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Jogar
            // 
            this.btn_Jogar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Jogar.BackColor = System.Drawing.Color.White;
            this.btn_Jogar.Font = new System.Drawing.Font("Showcard Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Jogar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Jogar.Location = new System.Drawing.Point(404, 305);
            this.btn_Jogar.Name = "btn_Jogar";
            this.btn_Jogar.Size = new System.Drawing.Size(228, 82);
            this.btn_Jogar.TabIndex = 4;
            this.btn_Jogar.Text = "Jogar!!!";
            this.btn_Jogar.UseVisualStyleBackColor = false;
            this.btn_Jogar.Click += new System.EventHandler(this.btn_Jogar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(44, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 119);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jogo da Memória";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbx_Fundo
            // 
            this.pbx_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_Fundo.Image = global::Jogo_da_Memoria_1._0._0.Properties.Resources.fundo_tela;
            this.pbx_Fundo.Location = new System.Drawing.Point(0, 0);
            this.pbx_Fundo.Name = "pbx_Fundo";
            this.pbx_Fundo.Size = new System.Drawing.Size(984, 511);
            this.pbx_Fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Fundo.TabIndex = 1;
            this.pbx_Fundo.TabStop = false;
            // 
            // frm_Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.btn_Jogar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbx_Fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Fundo;
        private System.Windows.Forms.Button btn_Jogar;
        private System.Windows.Forms.Label label1;
    }
}

