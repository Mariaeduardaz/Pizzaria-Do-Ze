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
    /// Tela para a visualização dos sabores
    /// </summary>
    public partial class TelaSabores : Form
    {
        TelaEditSabores editSabores = new TelaEditSabores();
        public TelaSabores()
        {
            InitializeComponent();
            addBtn.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            addBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            editBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            editBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnVerificar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnVerificar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            excluirBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            excluirBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            voltarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            voltarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            editSabores.ShowDialog();
        }
    }
}
