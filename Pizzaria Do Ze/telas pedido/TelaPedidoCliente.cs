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
    ///  Tela do pedido, para melhor visualização
    /// </summary>
    
    public partial class TelaPedidoCliente : Form
    {
        TelaPedidoFinal pedidoFinal = new TelaPedidoFinal();
        TelaRetirarIngrediente retirarIngrediente = new TelaRetirarIngrediente();

        public TelaPedidoCliente()
        {
            InitializeComponent();
            comboBoxSabores.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void seguinteBtn_Click(object sender, EventArgs e)
        {
            pedidoFinal.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void retirarIngredienteBtn_Click(object sender, EventArgs e)
        {
            retirarIngrediente.ShowDialog();
        }
    }
}
