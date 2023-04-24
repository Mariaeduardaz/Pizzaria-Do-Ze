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
    /// Tela para editar os sabores
    /// </summary>
    public partial class TelaEditSabores : Form
    {
        public TelaEditSabores()
        {
            InitializeComponent();
            nomePizzaTextBox.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
