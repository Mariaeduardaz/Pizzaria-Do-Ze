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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaZee
{
    /// <summary>
    /// Tela para  o cadastro de bebidas
    /// </summary>
    public partial class CadBebidas : Form
    {
        ProdutosDAO produtosDAO;
        VisualizarPedido visualizarPedido = new VisualizarPedido();
        public CadBebidas()
        {
            InitializeComponent();

            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            CarregaEnumListBox();
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            produtosDAO = new ProdutosDAO(provider, strConnection);
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }


        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastrarBebidas_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                Id = 0,
                Descricao = textBoxNome.Text,
                Valor = decimal.Parse(textBoxValor.Text),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipo.Text),
                ML = listBoxML.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                produtosDAO.Inserir(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonVisualizarCadastro_Click(object sender, EventArgs e)
        {
            visualizarPedido.AtualizarTela();
            visualizarPedido.ShowDialog();
        }
    }
}
