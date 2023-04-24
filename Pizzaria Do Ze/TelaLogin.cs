using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze
{
    public partial class TelaLogin : Form
    {
        TelaPrincipalAdmin admin = new TelaPrincipalAdmin();
        TelaPrincipalAtendente atendente = new TelaPrincipalAtendente();
        TelaPrincipalEntregador entregador = new TelaPrincipalEntregador();
        TelaDeConfg teladeConfig = new TelaDeConfg();
        public TelaLogin()
        {
            InitializeComponent();
            UserTextBox.Focus();
            Funcoes.AjustaResourcesControl(this);

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text == "admin")
            {
                admin.Show();
            }

            if (UserTextBox.Text == "atendente")
            {
                atendente.Show();
            }

            if (UserTextBox.Text == "entregador")
            {
                entregador.Show();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIdioma_Click(object sender, EventArgs e)
        {
            teladeConfig.Show();
        }
    }
}
