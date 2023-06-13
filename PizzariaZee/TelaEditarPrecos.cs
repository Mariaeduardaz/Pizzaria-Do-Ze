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
    /// Tela para editar os preços
    /// </summary>
    public partial class TelaEditarPrecos : Form
    {
        ValorDAO valorDAO;
        VisualizarPreco visualizarPreco = new VisualizarPreco();
        public TelaEditarPrecos()
        {
            InitializeComponent();

            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);


            TextBoxValor.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            TextBoxValor.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            TextBoxValorAdicional.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            TextBoxValorAdicional.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnCancelar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnCancelar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnSalvar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnSalvar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            valorDAO = new ValorDAO(provider, strConnection);

            CarregaEnumListBox();
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTamanho.Items.Clear();
            listBoxTamanho.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = 0,
                Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanho.Text),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                ValorPizza = decimal.Parse(TextBoxValor.Text),
                ValorBorda = decimal.Parse(TextBoxValorAdicional.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                valorDAO.Inserir(valor);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelValores_Click(object sender, EventArgs e)
        {
        }

        private void valorGiganteTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            visualizarPreco.AtualizarTela();
            visualizarPreco.ShowDialog();
        }
    }
}
