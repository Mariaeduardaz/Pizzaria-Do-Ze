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
    /// Tela para caso haja alguma retirada de ingrediente 
    /// </summary>
    public partial class TelaRetirarIngrediente : Form
    {
        public TelaRetirarIngrediente()
        {
            InitializeComponent();
            comboBoxIngrediente.Focus();
            Funcoes.AjustaResourcesControl(this);
        }
        private void ConcluirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
