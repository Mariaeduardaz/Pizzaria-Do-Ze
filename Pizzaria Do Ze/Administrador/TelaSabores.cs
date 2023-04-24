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
    /// Tela para a visualização dos sabores
    /// </summary>
    public partial class TelaSabores : Form
    {
        TelaEditSabores editSabores = new TelaEditSabores();
        public TelaSabores()
        {
            InitializeComponent();
            addBtn.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            editSabores.ShowDialog();
        }
    }
}
