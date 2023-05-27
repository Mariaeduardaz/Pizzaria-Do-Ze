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
    public partial class telaOpcaoFuncionario : Form
    {
        cadFuncionario cadFuncionario = new cadFuncionario();
        telaVisualizarFuncionario telavisualizarfuncionario = new telaVisualizarFuncionario();
        public telaOpcaoFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrarfuncionario_Click(object sender, EventArgs e)
        {
            cadFuncionario.ShowDialog();
        }

        private void btnvvisualizarfuncionario_Click(object sender, EventArgs e)
        {
            telavisualizarfuncionario.ShowDialog();
        }
    }
}
