using System;
using PizzariaDoZe.Dao;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PizzariaDoZe.Dao.IngredientesDAO;

namespace PizzariaZee
{
    public partial class CadastrarIngrediente : Form
    {
         IngredientesDAO dao;


        public CadastrarIngrediente()
        {
            InitializeComponent();

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            dao = new IngredientesDAO(provider, strConnection);

            NomeText.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            NomeText.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            NomeText.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnCadastrar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnCadastrar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            VoltarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            VoltarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            AtualizarTela();
        }

        private void nomeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarIngrediente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id = 0,
                Nome = NomeText.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                dao.Inserir(ingrediente);
                MessageBox.Show("Dados inseridos com sucesso!");
                AtualizarTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.Buscar(ingrediente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = linhas;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
