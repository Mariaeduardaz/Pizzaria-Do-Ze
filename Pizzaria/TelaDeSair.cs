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
    public partial class TelaDeSair : Form
    {
        public TelaDeSair()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);


            labelsairaplicacao.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            labelsairaplicacao.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnJogarBandeja.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnJogarBandeja.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnSair.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnSair.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
           
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
