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
{   /// <summary>
    /// Tela para a visualização do atendende sobre o pedido
    /// </summary>
    public partial class TelaStatusPedidoAtendente : Form
    {
        public TelaStatusPedidoAtendente()
        {
            InitializeComponent();
            pagoRadioBtn.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            idPedidoLabelStatusAtendente.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            idPedidoLabelStatusAtendente.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pagoRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pagoRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pendenteRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pendenteRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            preparoRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            preparoRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            RetiradaRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            RetiradaRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            SaiuRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            SaiuRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            comboBoxentregador.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comboBoxentregador.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnFechar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnFechar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
