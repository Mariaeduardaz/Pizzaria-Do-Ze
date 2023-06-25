using PizzariaDoZe.Dao;
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


namespace PizzariaZee
{
    /// <summary>
    /// Tela para a visualização do pedido final
    /// </summary>

    public partial class TelaPedidoFinal : Form
    {
        ProdutosDAO bebidaDAO;
        SaborDAO saborDAO;
        ClienteDAO clienteDAO;

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
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            bebidaDAO = new ProdutosDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);
            CarregarCliente();
            CarregarBebidas();
            CarregarSabores();
        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CarregarBebidas()
        {
            //Instância e Preenche o objeto com os dados da view
            var bebida = new Produto();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = bebidaDAO.Buscar(bebida);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxBebida.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
              //      checkedListBoxBebida.Items.Add(new Produto(int.Parse(row["ID"].ToString()), row["Descricao"].ToString())).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CarregarSabores()
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = saborDAO.Buscar(sabor);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxSabores.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                  //  checkedListBoxSabores.Items.Add(new Sabor(int.Parse(row["ID"].ToString()), row["Descricao"].ToString())).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CarregarCliente()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // carrega os dados, como objeto, no checkedListBox
                comboBoxCliente.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxSabores.Items.Add(new Cliente(int.Parse(row["ID"].ToString()), row["Nome"].ToString())).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
