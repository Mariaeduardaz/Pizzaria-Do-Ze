using Pizzaria_Do_Ze.Telas_Admin;
using Pizzaria_Do_Ze.Telas_Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_Cadastrais
{
    /// <summary>
    /// Tela para a configuração da pizza admin
    /// </summary>
    public partial class TelaPizzaAdmin : Form
    {
        TelaSabores sabores = new TelaSabores();
        TelaEditarPrecos precos = new TelaEditarPrecos();
        CadBordas borda = new CadBordas();
        TelaRetirarIngrediente ingrediente = new TelaRetirarIngrediente();
        public TelaPizzaAdmin()
        {
            InitializeComponent();
            valoresBtn.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void saboresBtn_Click(object sender, EventArgs e)
        {
            sabores.ShowDialog();
        }

        private void valoresBtn_Click(object sender, EventArgs e)
        {
            precos.ShowDialog();
        }

        private void bordaBtn_Click(object sender, EventArgs e)
        {
            borda.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingrediente.ShowDialog();
        }
    }
}
