using PizzariaDoZe.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaZee
{
    /// <summary>
    /// Tela para o cadastro de funccionario 
    /// </summary>
    public partial class cadFuncionario : Form
    {
        EnderecoDAO enderecoDAO;
        FuncionarioDAO funcionarioDAO;
        Funcoes funcoes = new Funcoes();
        telaVisualizarFuncionario visualizar = new telaVisualizarFuncionario();
        public cadFuncionario()
        {
            InitializeComponent();
            nomeTB.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

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
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (idEnderecoTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = 0,
                Nome = nomeTB.Text,
                Cpf = cpfMaskedTB.Text,
                Matricula = matriculaTB.Text,
                Senha = funcoes.Sha256Hash(senhaMaskedTB.Text),
                Grupo = (adminRadioBtn.Checked) ? '1' : (AtendenteRadioBtn.Checked) ? '2' : '3',
                Motorista = cnhMaskedTB.Text,
                Validade = dateTimePickerValidade.Value,
                Observacao = textBoxObs.Text,
                Telefone = telefonemaskedTB.Text,
                Email = textBoxEmail.Text,
                EnderecoId = int.Parse(idEnderecoTextBox.Text),
                Numero = textBoxNumero.Text,
                Complemento = textBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do funcionario
                int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                MessageBox.Show("Dados inseridos com sucesso! ID Funcionario: " + IdFuncionarioGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maskedTextBoxCEP_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxCEP.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = maskedTextBoxCEP.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                idEnderecoTextBox.Text = "";
                //userControlEndereco.maskedTextBoxCep.Text = "";
                textBoxLogradouro.Text = "";
                textBoxBairro.Text = "";
                textBoxCidade.Text = "";
                comboBoxUF.Text = "";
                textBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    idEnderecoTextBox.Text = row["id"].ToString(); ;
                    maskedTextBoxCEP.Text = row["cep"].ToString(); ;
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

        private void cadFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            visualizar.AtualizarTela();
            visualizar.ShowDialog();
        }
    }
}
