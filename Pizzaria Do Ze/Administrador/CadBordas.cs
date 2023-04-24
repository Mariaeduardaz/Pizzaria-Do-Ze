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
    /// Tela para adicionar borda
    /// </summary>
    public partial class TelaAdicionarBorda : Form
    {
        public TelaAdicionarBorda()
        {
            InitializeComponent();
            nomeTextBox.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
