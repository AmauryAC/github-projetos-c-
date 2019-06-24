namespace Jogo_da_Memória_com_Níveis
{
    partial class frm_Menu
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
            this.btn_Facil = new System.Windows.Forms.Button();
            this.frm_Medio = new System.Windows.Forms.Button();
            this.btn_Dificil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Facil
            // 
            this.btn_Facil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facil.Location = new System.Drawing.Point(77, 28);
            this.btn_Facil.Name = "btn_Facil";
            this.btn_Facil.Size = new System.Drawing.Size(203, 73);
            this.btn_Facil.TabIndex = 0;
            this.btn_Facil.Text = "Fácil";
            this.btn_Facil.UseVisualStyleBackColor = true;
            this.btn_Facil.Click += new System.EventHandler(this.btn_Facil_Click);
            // 
            // frm_Medio
            // 
            this.frm_Medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm_Medio.Location = new System.Drawing.Point(76, 115);
            this.frm_Medio.Name = "frm_Medio";
            this.frm_Medio.Size = new System.Drawing.Size(203, 73);
            this.frm_Medio.TabIndex = 1;
            this.frm_Medio.Text = "Médio";
            this.frm_Medio.UseVisualStyleBackColor = true;
            this.frm_Medio.Click += new System.EventHandler(this.frm_Medio_Click);
            // 
            // btn_Dificil
            // 
            this.btn_Dificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dificil.Location = new System.Drawing.Point(77, 207);
            this.btn_Dificil.Name = "btn_Dificil";
            this.btn_Dificil.Size = new System.Drawing.Size(203, 73);
            this.btn_Dificil.TabIndex = 2;
            this.btn_Dificil.Text = "Difícil";
            this.btn_Dificil.UseVisualStyleBackColor = true;
            this.btn_Dificil.Click += new System.EventHandler(this.btn_Dificil_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 309);
            this.Controls.Add(this.btn_Dificil);
            this.Controls.Add(this.frm_Medio);
            this.Controls.Add(this.btn_Facil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Nível";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Facil;
        private System.Windows.Forms.Button frm_Medio;
        private System.Windows.Forms.Button btn_Dificil;
    }
}

