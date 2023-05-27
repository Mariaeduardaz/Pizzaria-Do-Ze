using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Administrador
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
            KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            nomeTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomeTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnCancelar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnCancelar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnConcluido.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnConcluido.Leave += new EventHandler(Funcoes.CampoEventoLeave);

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
