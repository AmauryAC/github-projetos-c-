using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace Enviar_EMail
{
    public partial class frm_TelaEnvio : Form
    {
        private MailMessage Email;
        private SmtpClient Cliente;

        public frm_TelaEnvio()
        {
            InitializeComponent();

            Email = new MailMessage();
        }

        private void frm_TelaEnvio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair da aplicação?", "Sair da Aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbx_De_TextChanged(object sender, EventArgs e)
        {
            lbl_EmailDe.Text = tbx_De.Text;
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_Status.Visible = true;
                lbl_Status.Enabled = true;
                lbl_Status.Text = "Enviando Email para o destinatário...";

                pgb_EnviandoEmail.Visible = true;
                pgb_EnviandoEmail.Enabled = true;
                pgb_EnviandoEmail.Value = 0;

                for (int i = 0; i < 5; i++)
                    pgb_EnviandoEmail.Value = i;

                Email.From = new MailAddress(tbx_De.Text);
                Email.To.Add(new MailAddress(tbx_Para.Text));

                if (tbx_Cc.Text != "")
                    Email.CC.Add(new MailAddress(tbx_Cc.Text));
                if (tbx_Cco.Text != "")
                    Email.Bcc.Add(new MailAddress(tbx_Cco.Text));

                if (tbx_Assunto.Text != "")
                    Email.Subject = tbx_Assunto.Text;
                else
                    Email.Subject = "(Sem assunto)";

                Email.Body = tbx_Mensagem.Text;

                for (int i = 5; i < 15; i++)
                    pgb_EnviandoEmail.Value = i;
                Cliente = new SmtpClient("smtp.live.com", 587);

                for (int i = 15; i < 30; i++)
                    pgb_EnviandoEmail.Value = i;

                using (Cliente)
                {
                    Cliente.Credentials = new System.Net.NetworkCredential(tbx_De.Text, tbx_Senha.Text);
                    Cliente.EnableSsl = true;

                    for (int i = 30; i < 45; i++)
                        pgb_EnviandoEmail.Value = i;

                    Cliente.Send(Email);

                    for (int i = 45; i < 99; i++)
                        pgb_EnviandoEmail.Value = i;
                }

                pgb_EnviandoEmail.Value = 100;
                lbl_Status.Text = "Enviado.";

                MessageBox.Show("Email enviado com sucesso!!!", "Email enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pgb_EnviandoEmail.Visible = false;
                pgb_EnviandoEmail.Enabled = false;

                lbl_Status.Visible = false;
                lbl_Status.Enabled = false;

                LimpaCampos();
            }
            catch (Exception ex)
            {
                pgb_EnviandoEmail.Visible = false;
                pgb_EnviandoEmail.Enabled = false;

                MessageBox.Show(ex.Message);
            }
        }

        private void LimpaCampos()
        {
            tbx_De.Text = "";
            tbx_Para.Text = "";
            tbx_Cc.Text = "";
            tbx_Cco.Text = "";
            tbx_Assunto.Text = "";
            tbx_Mensagem.Text = "";
            tbx_Senha.Text = "";
            tbx_Anexos.Text = "";
        }

        private void btn_Anexar_Click(object sender, EventArgs e)
        {
            string arquivo;

            try
            {
                OpenFileDialog LocalizarAnexo = new OpenFileDialog();

                LocalizarAnexo.Title = "Localizar Arquivos";
                LocalizarAnexo.Multiselect = true;

                if (LocalizarAnexo.ShowDialog() == DialogResult.OK)
                {
                    arquivo = LocalizarAnexo.FileName;

                    MemoryStream MS = new MemoryStream();
                    Attachment anexo = new Attachment(MS, arquivo);

                    Email.Attachments.Add(anexo);

                    MessageBox.Show("Arquivo anexado com sucesso!!!", "Arquivo anexado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbx_Anexos.Text += arquivo + "   ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
