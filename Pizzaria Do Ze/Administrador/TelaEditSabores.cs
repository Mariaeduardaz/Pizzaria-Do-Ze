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
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            nomePizzaTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomePizzaTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            especialCheckBoxespecialCheckBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            especialCheckBoxespecialCheckBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            ingredientesComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            ingredientesComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnAdiconar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnAdiconar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnExcluir.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnExcluir.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnCancelar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnCancelar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            BtnCadastrar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnCadastrar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
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
