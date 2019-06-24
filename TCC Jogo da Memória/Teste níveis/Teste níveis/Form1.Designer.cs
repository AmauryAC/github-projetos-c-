namespace Teste_níveis
{
    partial class Form1
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
            this.btn_Medio = new System.Windows.Forms.Button();
            this.btn_Dificil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Facil
            // 
            this.btn_Facil.Location = new System.Drawing.Point(89, 22);
            this.btn_Facil.Name = "btn_Facil";
            this.btn_Facil.Size = new System.Drawing.Size(108, 41);
            this.btn_Facil.TabIndex = 0;
            this.btn_Facil.Text = "Fácil";
            this.btn_Facil.UseVisualStyleBackColor = true;
            this.btn_Facil.Click += new System.EventHandler(this.btn_Facil_Click);
            // 
            // btn_Medio
            // 
            this.btn_Medio.Location = new System.Drawing.Point(89, 104);
            this.btn_Medio.Name = "btn_Medio";
            this.btn_Medio.Size = new System.Drawing.Size(108, 41);
            this.btn_Medio.TabIndex = 1;
            this.btn_Medio.Text = "Medio";
            this.btn_Medio.UseVisualStyleBackColor = true;
            // 
            // btn_Dificil
            // 
            this.btn_Dificil.Location = new System.Drawing.Point(89, 186);
            this.btn_Dificil.Name = "btn_Dificil";
            this.btn_Dificil.Size = new System.Drawing.Size(108, 41);
            this.btn_Dificil.TabIndex = 2;
            this.btn_Dificil.Text = "Difícil";
            this.btn_Dificil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 263);
            this.Controls.Add(this.btn_Dificil);
            this.Controls.Add(this.btn_Medio);
            this.Controls.Add(this.btn_Facil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Facil;
        private System.Windows.Forms.Button btn_Medio;
        private System.Windows.Forms.Button btn_Dificil;
    }
}

