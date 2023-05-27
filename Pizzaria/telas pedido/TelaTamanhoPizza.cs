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
    /// Tela para verificar os tamanhos das pizzas 
    /// </summary>
    public partial class TelaTamanhoPizza : Form
    {
        TelaPedidoCliente pedido = new TelaPedidoCliente();
        public TelaTamanhoPizza()
        {
            InitializeComponent();
            comprarExtraGiganteBtn.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            comprarExtraGiganteBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comprarExtraGiganteBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            comprarGiganteBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comprarGiganteBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            comprarGrandeBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comprarGrandeBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            comprarBrotoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comprarBrotoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            
        }

        private void comprarExtraGiganteBtn_Click(object sender, EventArgs e)
        {
            pedido.Show();
          
        }

        private void comprarGiganteBtn_Click(object sender, EventArgs e)
        {
            pedido.Show();
           
        }

        private void comprarGrandeBtn_Click(object sender, EventArgs e)
        {
            pedido.Show();
          
        }

        private void comprarBrotoBtn_Click(object sender, EventArgs e)
        {
            pedido.Show();
           
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
