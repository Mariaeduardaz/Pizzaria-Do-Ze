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
    /// Tela para editar os preços
    /// </summary>
    public partial class TelaEditarPrecos : Form
    {
        public TelaEditarPrecos()
        {
            InitializeComponent();
            valorGrandeTB.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            valorGrandeTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            valorGrandeTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            valorGiganteTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            valorGiganteTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            valorExtraGiganteTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            valorExtraGiganteTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            valorEspeciaisTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            valorEspeciaisTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            valorBrotoTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            valorBrotoTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnCancelar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnCancelar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnAtualizar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnAtualizar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
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
