using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaZee
{
    public partial class telaOpcaoCliente : Form
    {

        TelaCadastroCliente telacadastrocliente = new TelaCadastroCliente();
        telaVisualizarCliente telavisualizarcliente = new telaVisualizarCliente();

        public telaOpcaoCliente()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            telacadastrocliente.ShowDialog();

        }

        private void btnVisualizarCliente_Click(object sender, EventArgs e)
        {
            telavisualizarcliente.ShowDialog();
        }
    }
}
