using Pizzaria_Do_Ze.Telas_Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_cadastros
{
    /// <summary>
    /// Tela onde o atendente irá cadastrar o cliente
    /// </summary>

    public partial class TelaCadastroCliente : Form
    {
        TelaPedidoCliente pedido = new TelaPedidoCliente();
        TelaTamanhoPizza tamanhopizza = new TelaTamanhoPizza();
        public TelaCadastroCliente()
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
            clienteCadastradoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            clienteCadastradoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cadastrarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cadastrarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            voltarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            voltarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
           
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            
            tamanhopizza.ShowDialog();
        }

        private void TelaCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void cadGenerico1_Load(object sender, EventArgs e)
        {

        }

        private void enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
