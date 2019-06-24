namespace Jogo_da_Memória_TCC
{
    partial class frm_Niveis
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Medio = new System.Windows.Forms.Button();
            this.btn_Dificil = new System.Windows.Forms.Button();
            this.btn_Facil = new System.Windows.Forms.Button();
            this.pbx_Fundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(443, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "???";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(45, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 119);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jogo da Memória";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Medio
            // 
            this.btn_Medio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Medio.BackColor = System.Drawing.Color.White;
            this.btn_Medio.Font = new System.Drawing.Font("Showcard Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Medio.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Medio.Location = new System.Drawing.Point(386, 446);
            this.btn_Medio.Name = "btn_Medio";
            this.btn_Medio.Size = new System.Drawing.Size(228, 82);
            this.btn_Medio.TabIndex = 8;
            this.btn_Medio.UseVisualStyleBackColor = false;
            this.btn_Medio.Click += new System.EventHandler(this.btn_Medio_Click);
            // 
            // btn_Dificil
            // 
            this.btn_Dificil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Dificil.BackColor = System.Drawing.Color.White;
            this.btn_Dificil.Font = new System.Drawing.Font("Showcard Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dificil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Dificil.Location = new System.Drawing.Point(386, 534);
            this.btn_Dificil.Name = "btn_Dificil";
            this.btn_Dificil.Size = new System.Drawing.Size(228, 82);
            this.btn_Dificil.TabIndex = 9;
            this.btn_Dificil.UseVisualStyleBackColor = false;
            this.btn_Dificil.Click += new System.EventHandler(this.btn_Dificil_Click);
            // 
            // btn_Facil
            // 
            this.btn_Facil.BackColor = System.Drawing.Color.White;
            this.btn_Facil.Font = new System.Drawing.Font("Showcard Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Facil.Location = new System.Drawing.Point(386, 358);
            this.btn_Facil.Name = "btn_Facil";
            this.btn_Facil.Size = new System.Drawing.Size(228, 82);
            this.btn_Facil.TabIndex = 7;
            this.btn_Facil.UseVisualStyleBackColor = false;
            this.btn_Facil.Click += new System.EventHandler(this.btn_Facil_Click);
            // 
            // pbx_Fundo
            // 
            this.pbx_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_Fundo.Location = new System.Drawing.Point(0, 0);
            this.pbx_Fundo.Name = "pbx_Fundo";
            this.pbx_Fundo.Size = new System.Drawing.Size(984, 711);
            this.pbx_Fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Fundo.TabIndex = 2;
            this.pbx_Fundo.TabStop = false;
            // 
            // frm_Niveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.btn_Dificil);
            this.Controls.Add(this.btn_Medio);
            this.Controls.Add(this.btn_Facil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbx_Fundo);
            this.Name = "frm_Niveis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jogo da Memória";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Dificil;
        private System.Windows.Forms.Button btn_Medio;
        private System.Windows.Forms.Button btn_Facil;
        private System.Windows.Forms.PictureBox pbx_Fundo;
    }
}