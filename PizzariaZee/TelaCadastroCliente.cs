using PizzariaDoZe.Dao;
using PizzariaZee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaZee
{
    /// <summary>
    /// Tela onde o atendente irá cadastrar o cliente
    /// </summary>

    public partial class TelaCadastroCliente : Form
    {
        TelaPedidoCliente pedido = new TelaPedidoCliente();
        TelaTamanhoPizza tamanhopizza = new TelaTamanhoPizza();
        EnderecoDAO enderecodao;
        ClienteDAO clientedao;
        telaVisualizarCliente visualizar = new telaVisualizarCliente();
        public TelaCadastroCliente()
        {
            InitializeComponent();
            nomeTextBot.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            nomeTextBot.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomeTextBot.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            emailTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            emailTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            numeroTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            numeroTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            CPFMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            CPFMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            maskedTexBoxCEP.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            maskedTexBoxCEP.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            enderecoTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            enderecoTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            complementoTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            complementoTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);

            cadastrarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cadastrarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            voltarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            voltarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecodao = new EnderecoDAO(provider, strConnection);

            clientedao = new ClienteDAO(provider, strConnection);
        }


        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = 0,
                Nome = nomeTextBot.Text,
                Cpf = CPFMaskedTB.Text,
                Telefone = numeroTextBox.Text,
                Email = emailTextBox.Text,
                EnderecoId = int.Parse(idTextBox.Text),
                Numero = numeroTextBox.Text,
                Complemento = complementoTextBox.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdClienteGerado = clientedao.Inserir(cliente);
                MessageBox.Show("Dados inseridos com sucesso! ClienteID: " + IdClienteGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TelaCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void cadGenerico1_Load(object sender, EventArgs e)
        {

        }

        private void enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTexBoxCEP_Leave(object sender, EventArgs e)
        {
            if (maskedTexBoxCEP.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = maskedTexBoxCEP.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecodao.Buscar(endereco);
                // seta os dados na tela
                idTextBox.Text = "";
                //userControlEndereco.maskedTextBoxCep.Text = "";
                textBoxLogradouro.Text = "";
                textBoxBairro.Text = "";
                textBoxCidade.Text = "";
                comboBoxUF.Text = "";
                textBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    idTextBox.Text = row["id"].ToString(); ;
                    maskedTexBoxCEP.Text = row["cep"].ToString(); ;
                    textBoxLogradouro.Text = row["logradouro"].ToString(); ;
                    textBoxBairro.Text = row["bairro"].ToString(); ;
                    textBoxCidade.Text = row["cidade"].ToString(); ;
                    comboBoxUF.Text = row["uf"].ToString(); ;
                    textBoxPais.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaCadastroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            visualizar.AtualizarTela();
            visualizar.ShowDialog();
            
        }
    }
}
