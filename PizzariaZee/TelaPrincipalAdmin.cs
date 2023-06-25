
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
    /// Tela para o admistrador escolher se vai querer editar ou verificar as integrações
    /// </summary>

    public partial class TelaPrincipalAdmin : Form
    {
        TelaPrincipalEntregador entregas = new TelaPrincipalEntregador();
        telaOpcaoFuncionario funcionarios = new telaOpcaoFuncionario();
        TelaPedidoFinal pedido = new TelaPedidoFinal();
        TelaPizzaAdmin pizza = new TelaPizzaAdmin();
        TelaAcessarStatusPedidoAtendente editStatus = new TelaAcessarStatusPedidoAtendente();
        CadFornecedor fornecedor = new CadFornecedor();
        CadBebidas cadastrobebidas = new CadBebidas();
        telaOpcaoCliente telaopcaocliente = new telaOpcaoCliente();
        enderecoListar endereco = new enderecoListar();
        public TelaPrincipalAdmin()
        {
            InitializeComponent();
            BtnCadastroPizza.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            BtnCadastroPizza.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnCadastroPizza.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            BtnCadastroFuncionario.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnCadastroFuncionario.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            BtnCadastroFornecedor.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnCadastroFornecedor.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            BtnCadastroPedido.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnCadastroPedido.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            BtnCadastroBebida.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnCadastroBebida.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnVoltar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnVoltar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pizzaToolStripMenuItem.Click += new EventHandler(pizzaBtn_Click);
            bebidaToolStripMenuItem.Click += new EventHandler(bntBebida_Click);
            fornecedorToolStripMenuItem.Click += new EventHandler(BtnFornecedor_Click);
            funcionarioToolStripMenuItem.Click += new EventHandler(cadastroFuncionarioBtn_Click);
            pedidoToolStripMenuItem.Click += new EventHandler(pedidoBtn_Click);
            sairToolStripMenuItem.Click += new EventHandler(voltarBtn_Click);

        }



        private void pizzaBtn_Click(object sender, EventArgs e)
        {
            pizza.ShowDialog();
        }

        private void pedidoBtn_Click(object sender, EventArgs e)
        {
            telaopcaocliente.ShowDialog();
        }
        private void visualizarPedidosBtn_Click(object sender, EventArgs e)
        {
            entregas.ShowDialog();
        }

        private void cadastroFuncionarioBtn_Click(object sender, EventArgs e)
        {
            funcionarios.ShowDialog();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarStatusBtn_Click(object sender, EventArgs e)
        {
            editStatus.ShowDialog();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            fornecedor.ShowDialog();
        }

        private void bntBebida_Click(object sender, EventArgs e)
        {
            cadastrobebidas.ShowDialog();
        }

        private void buttonEndereco_Click(object sender, EventArgs e)
        {
            endereco.ShowDialog();
        }

        private void buttonPedido_Click(object sender, EventArgs e)
        {
            pedido.ShowDialog();
        }
    }
}
