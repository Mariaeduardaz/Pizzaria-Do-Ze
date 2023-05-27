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
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            textBoxnome.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            textBoxnome.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            idPedidosAbertoscomboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            idPedidosAbertoscomboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            acessarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            acessarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnFechar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnFechar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            
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
