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
    /// Tela para editar os preços
    /// </summary>
    public partial class TelaEditarPrecos : Form
    {
        public TelaEditarPrecos()
        {
            InitializeComponent();
            valorGrandeTB.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
