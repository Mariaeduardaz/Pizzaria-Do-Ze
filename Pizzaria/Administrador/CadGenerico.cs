using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Administrador
{
    /// <summary>
    /// Tela para os cadastros em geral
    /// </summary>
    public partial class CadGenerico : UserControl
    {
        public CadGenerico()
        {
            InitializeComponent();
            nameTextBot.Focus();
            KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);


            nameTextBot.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nameTextBot.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            EmailTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            EmailTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            TelefoneMaskTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            TelefoneMaskTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            CPFMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            CPFMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            CEPMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            CEPMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            enderecoTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            enderecoTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            complementoTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            complementoTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);

        }



        private void CPFMaskedTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CEPMaskedTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelEndereco_Click(object sender, EventArgs e)
        {

        }

        private void labelCEP_Click(object sender, EventArgs e)
        {

        }

        private void labelCPF_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelTelefone_Click(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void complementoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelefoneMaskTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nameTextBot_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
