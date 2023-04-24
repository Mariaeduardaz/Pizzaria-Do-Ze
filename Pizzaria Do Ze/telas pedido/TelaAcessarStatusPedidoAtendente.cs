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
    ///Tela para o atendente verificar o status dos pedidos
    /// </summary>


    public partial class TelaAcessarStatusPedidoAtendente : Form
    {
        TelaStatusPedidoAtendente statusPedido = new TelaStatusPedidoAtendente();
        public TelaAcessarStatusPedidoAtendente()
        {
            InitializeComponent();
            textBoxnome.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acessarBtn_Click(object sender, EventArgs e)
        {
            statusPedido.ShowDialog();
        }
    }
}
