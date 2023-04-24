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
        }

        private void fecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
