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
    }
}
