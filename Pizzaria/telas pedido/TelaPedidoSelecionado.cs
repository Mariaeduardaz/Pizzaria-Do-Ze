using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_Pedido
{
    /// <summary>
    /// Tela para a visualização de como ficou o pedido
    /// </summary>
    public partial class TelaPedidoSelecionado : Form
    {
        public TelaPedidoSelecionado()
        {
            InitializeComponent();
            fecharBtn.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);


            idPedidoLabelDetalhePedido.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            idPedidoLabelDetalhePedido.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            statusPedidoLabelDetalhePedido.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            statusPedidoLabelDetalhePedido.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            entregadorResponsavelLabel.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            entregadorResponsavelLabel.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pedidoLabelDetalhePedido.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pedidoLabelDetalhePedido.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pagamentoLabelDetalhePedido.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pagamentoLabelDetalhePedido.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            endereoLabelDetalhePedido.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            endereoLabelDetalhePedido.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            valorLabelDetalhePedido.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            valorLabelDetalhePedido.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            fecharBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            fecharBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            
        }

        private void fecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
