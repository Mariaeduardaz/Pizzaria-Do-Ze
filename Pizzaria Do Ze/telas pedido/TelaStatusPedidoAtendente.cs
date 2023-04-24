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
    /// Tela para a visualização do atendende sobre o pedido
    /// </summary>
    public partial class TelaStatusPedidoAtendente : Form
    {
        public TelaStatusPedidoAtendente()
        {
            InitializeComponent();
            pagoRadioBtn.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
