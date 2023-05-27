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
    /// <summary>editar as bordas disponiveis 
    /// </summary>
    public partial class CadBordas : Form
    {
        TelaAdicionarBorda addborda = new TelaAdicionarBorda();
        public CadBordas()
        {
            InitializeComponent();
            BtnAddBorda.Focus();
            Funcoes.AjustaResourcesControl(this);
            KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            BtnAddBorda.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnAddBorda.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            BtnExcluir.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnExcluir.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnCancelar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnCancelar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
        }

        private void addBordaBtn_Click(object sender, EventArgs e)
        {
            addborda.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
