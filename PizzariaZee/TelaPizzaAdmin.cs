
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
    /// <summary>
    /// Tela para a configuração da pizza admin
    /// </summary>
    public partial class TelaPizzaAdmin : Form
    {
        TelaSabores sabores = new TelaSabores();
        TelaEditarPrecos precos = new TelaEditarPrecos();
        CadBordas borda = new CadBordas();
        CadastrarIngrediente ingrediente = new CadastrarIngrediente();
        
        public TelaPizzaAdmin()
        {
            InitializeComponent();
            valoresBtn.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            valoresBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            valoresBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            saboresBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            saboresBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnIngrendiente.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnIngrendiente.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnVoltar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnVoltar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
          
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
