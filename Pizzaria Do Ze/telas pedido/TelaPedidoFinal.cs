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
    /// Tela para a visualização do pedido final
    /// </summary>
   
    public partial class TelaPedidoFinal : Form
    {
        public TelaPedidoFinal()
        {
            InitializeComponent();
            retiradaRadioBtn.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
