
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
    ///Tela para escolher se vai ser entregador, admin, funcioanrio, atendente
    /// </summary>

    public partial class Telaprincipal : Form
    {
        TelaPrincipalAdmin admin = new TelaPrincipalAdmin();
        TelaPrincipalAtendente atendente = new TelaPrincipalAtendente();
        TelaPrincipalEntregador entregador = new TelaPrincipalEntregador();
        TelaEditSabores pizza = new TelaEditSabores();

        public Telaprincipal()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            atendente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entregador.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pizza.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Telaprincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
