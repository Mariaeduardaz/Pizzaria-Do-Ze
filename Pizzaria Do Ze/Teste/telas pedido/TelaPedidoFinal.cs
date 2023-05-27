using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_Pedido
{
    /// <summary>
    /// Tela para a visualização do pedido final
    /// </summary>
   
    public partial class TelaPedidoFinal : Form
    {
        public TelaPedidoFinal()
        {
            InitializeComponent();
            retiradaRadioBtn.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            retiradaRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            retiradaRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            entregaRadiobtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            entregaRadiobtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pixRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pixRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            dinheiroRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            dinheiroRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cartaoRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cartaoRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            checkBoxCartaoCredito.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            checkBoxCartaoCredito.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            checkBoxCartaoDebito.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            checkBoxCartaoDebito.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            trocoTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            trocoTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            totalPedidoFinalLabel.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            totalPedidoFinalLabel.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            finalizarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            finalizarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
           
        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
