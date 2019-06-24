namespace PRJ_Distancia_entre_Cidades
{
    partial class frm_ExibirC
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
            this.lbx_Exibir = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbx_Exibir
            // 
            this.lbx_Exibir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_Exibir.FormattingEnabled = true;
            this.lbx_Exibir.Location = new System.Drawing.Point(0, 0);
            this.lbx_Exibir.Name = "lbx_Exibir";
            this.lbx_Exibir.Size = new System.Drawing.Size(302, 277);
            this.lbx_Exibir.TabIndex = 9;
            // 
            // frm_ExibirC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 277);
            this.Controls.Add(this.lbx_Exibir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ExibirC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exibir Coloração";
            this.Load += new System.EventHandler(this.frm_ExibirC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Exibir;
    }
}