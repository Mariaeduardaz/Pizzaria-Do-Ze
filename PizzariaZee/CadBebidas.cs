using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaZee
{
    /// <summary>
    /// Tela para  o cadastro de bebidas
    /// </summary>
    public partial class CadBebidas : Form
    {
        public CadBebidas()
        {
            InitializeComponent();
            nomeTB.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            nomeTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomeTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            tipoTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            tipoTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            tamanhoTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            tamanhoTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            valorTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            valorTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnExcluir.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnExcluir.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnCancelar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnCancelar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnCadastrar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnCadastrar.Leave += new EventHandler(Funcoes.CampoEventoLeave);

        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastrarBebidas_Load(object sender, EventArgs e)
        {

        }
    }
}
