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
    /// Tela para o cadastro de funccionario 
    /// </summary>
    public partial class cadFuncionario : Form
    {
        public cadFuncionario()
        {
            InitializeComponent();
            nomeTB.Focus();
            Funcoes.AjustaResourcesControl(this);
            KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            nomeTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomeTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cpfMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cpfMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            telefonemaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            telefonemaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            matriculaTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            matriculaTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            senhaMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            senhaMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            adminRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            adminRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            AtendenteRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            AtendenteRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            entregadorRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            entregadorRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cnhMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cnhMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnCancelar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnCancelar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnCadastrar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnCadastrar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
        }
    }
}
