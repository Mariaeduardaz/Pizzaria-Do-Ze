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
    ///  Tela do pedido, para melhor visualização
    /// </summary>
    
    public partial class TelaPedidoCliente : Form
    {
        TelaPedidoFinal pedidoFinal = new TelaPedidoFinal();
        TelaRetirarIngrediente retirarIngrediente = new TelaRetirarIngrediente();

        public TelaPedidoCliente()
        {
            InitializeComponent();
            comboBoxSabores.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            nomeClienteLabel.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomeClienteLabel.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            tamanhoPizzaLabel.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            tamanhoPizzaLabel.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            comboBoxSabores.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comboBoxSabores.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            addPizzaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addPizzaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            comboBoxBorda.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comboBoxBorda.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            addBordaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addBordaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            bebeidasComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            bebeidasComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            addBebidaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addBebidaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            totalPagarLabel.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            totalPagarLabel.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            retirarIngredienteBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            retirarIngredienteBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            AdicionarBebidaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            AdicionarBebidaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            excluirBebidaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            excluirBebidaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            seguinteBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            seguinteBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
        }

        private void seguinteBtn_Click(object sender, EventArgs e)
        {
            pedidoFinal.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void retirarIngredienteBtn_Click(object sender, EventArgs e)
        {
            retirarIngrediente.ShowDialog();
        }
    }
}
