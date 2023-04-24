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
    /// Tela para a visualização dos pedidos que foram entregues no dia 
    /// </summary>
    public partial class TelaPedidosEntregues : Form
    {
        TelaPedidoSelecionado pedidoSelecionado = new TelaPedidoSelecionado();
        public TelaPedidosEntregues()
        {
            InitializeComponent();
            pedidosEntregues.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void abrirPedidoBtn_Click(object sender, EventArgs e)
        {
            pedidoSelecionado.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
