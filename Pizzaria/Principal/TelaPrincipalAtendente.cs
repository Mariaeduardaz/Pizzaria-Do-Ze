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

namespace Pizzaria.Principal
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
            KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            clienteBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            clienteBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnEditarCliente.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnEditarCliente.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            BtnVisPedido.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnVisPedido.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            BtnEditarStatusPedid.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnEditarStatusPedid.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnVoltar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnVoltar.Leave += new EventHandler(Funcoes.CampoEventoLeave);

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
            Close();
        }

    }
}
