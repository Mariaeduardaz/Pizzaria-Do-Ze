using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using PizzariaZee;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaZee
{
    /// <summary>
    /// Tela para o cadastro do fornecedor 
    /// </summary>
    public partial class CadFornecedor : Form
    {
        public CadFornecedor()
        {
            InitializeComponent();
            nameTextBot.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

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
            BtnCadastrar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnCadastrar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
        }

        private void CadFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void cadGenerico1_Load(object sender, EventArgs e)
        {

        }
    }
}
