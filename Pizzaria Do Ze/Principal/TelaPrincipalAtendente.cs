using Pizzaria_Do_Ze.Telas_cadastros;
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

namespace Pizzaria_Do_Ze
{
    /// <summary>
    /// Tela para o atender visualizar o que vai mexer
    /// </summary>

    public partial class TelaPrincipalAtendente : Form
    {
        TelaCadastroCliente cliente = new TelaCadastroCliente();
        TelaAcessarStatusPedidoAtendente status = new TelaAcessarStatusPedidoAtendente();
        TelaPrincipalEntregador telaPedido = new TelaPrincipalEntregador();
        public TelaPrincipalAtendente()
        {
            InitializeComponent();
            clienteBtn.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        

        private void clienteBtn_Click(object sender, EventArgs e)
        {
            cliente.ShowDialog();
        }    

        private void visPedidoBtn_Click(object sender, EventArgs e)
        {
            telaPedido.ShowDialog();
        }

        private void editarStatusPedidoBtn_Click(object sender, EventArgs e)
        {
            status.ShowDialog();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
