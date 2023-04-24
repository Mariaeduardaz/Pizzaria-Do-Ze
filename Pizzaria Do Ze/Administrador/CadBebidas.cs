using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_Admin
{
    /// <summary>
    /// Tela para  o cadastro de bebidas
    /// </summary>
    public partial class CadBebidas : Form
    {
        public CadBebidas()
        {
            InitializeComponent();
            nomeTB.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastrarBebidas_Load(object sender, EventArgs e)
        {

        }
    }
}
