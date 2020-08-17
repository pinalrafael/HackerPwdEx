using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerPwdEx
{
    public partial class Form1 : Form
    {
        private HackerPwd.Passwords Passwords { get; set; }

        public Form1()
        {
            InitializeComponent();

            this.Passwords = new HackerPwd.Passwords();

            Passwords.ReceiveIndividually += Passwords_ReceiveIndividually;

            chbFiltro.Items.Add("NUMBER");
            chbFiltro.Items.Add("CHAR");
            chbFiltro.Items.Add("CHAR_ACENTO");
            chbFiltro.Items.Add("ESPECIAL");
            chbFiltro.Items.Add("NUMBEReCHAR");
            chbFiltro.Items.Add("NUMBEReCHAR_ACENTO");
            chbFiltro.Items.Add("NUMBEReESPECIAL");
            chbFiltro.Items.Add("CHAReCHAR_ACENTO");
            chbFiltro.Items.Add("CHAReESPECIAL");
            chbFiltro.Items.Add("CHAR_ACENTOeESPECIAL");
            chbFiltro.Items.Add("NUMBEReCHAReCHAR_ACENTO");
            chbFiltro.Items.Add("NUMBEReCHAReESPECIAL");
            chbFiltro.Items.Add("NUMBEReCHAR_ACENTOeESPECIAL");
            chbFiltro.Items.Add("CHAReCHAR_ACENTOeESPECIAL");
            chbFiltro.Items.Add("ALL");

            chbFiltro.SelectedIndex = 0;
        }

        private void Passwords_ReceiveIndividually(object sender, EventArgs e)
        {
            lblSenha.Text = sender.ToString();
            lblSenha.Refresh();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Passwords.MinimumChar = Convert.ToInt32(txtMinimo.Value);
            Passwords.MaximumChar = Convert.ToInt32(txtMaximo.Value);

            switch (chbFiltro.SelectedIndex)
            {
                case 0:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBER;
                    break;
                case 1:
                    Passwords.Types = HackerPwd.Enums.Types.CHAR;
                    break;
                case 2:
                    Passwords.Types = HackerPwd.Enums.Types.CHAR_ACENTO;
                    break;
                case 3:
                    Passwords.Types = HackerPwd.Enums.Types.ESPECIAL;
                    break;
                case 4:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReCHAR_ACENTO;
                    break;
                case 5:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReESPECIAL;
                    break;
                case 6:
                    Passwords.Types = HackerPwd.Enums.Types.CHAReCHAR_ACENTO;
                    break;
                case 7:
                    Passwords.Types = HackerPwd.Enums.Types.CHAReESPECIAL;
                    break;
                case 8:
                    Passwords.Types = HackerPwd.Enums.Types.CHAR_ACENTOeESPECIAL;
                    break;
                case 9:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReCHAReCHAR_ACENTO;
                    break;
                case 10:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReCHAReESPECIAL;
                    break;
                case 11:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReCHAR_ACENTOeESPECIAL;
                    break;
                case 12:
                    Passwords.Types = HackerPwd.Enums.Types.CHAReCHAR_ACENTOeESPECIAL;
                    break;
                case 13:
                    Passwords.Types = HackerPwd.Enums.Types.ALL;
                    break;
                default:
                    Passwords.Types = HackerPwd.Enums.Types.NUMBEReCHAR;
                    break;
            }

            if (!Passwords.Start())
            {
                MessageBox.Show(Passwords.ErrorMsg);
            }
            else
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (btnPausar.Text == "Reiniciar")
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = true;
                btnCancelar.Enabled = true;
                btnPausar.Text = "Pausar";

                Passwords.Commands = HackerPwd.Enums.Commands.START;
            }
            else
            {
                btnIniciar.Enabled = false;
                btnPausar.Enabled = true;
                btnCancelar.Enabled = false;
                btnPausar.Text = "Reiniciar";

                Passwords.Commands = HackerPwd.Enums.Commands.BREAK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = true;
            btnPausar.Enabled = false;
            btnCancelar.Enabled = false;

            Passwords.Commands = HackerPwd.Enums.Commands.CANCEL;

            lblSenha.Text = "";
        }
    }
}
