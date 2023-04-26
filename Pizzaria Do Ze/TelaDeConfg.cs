using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze
{
    public partial class TelaDeConfg : Form
    {
        /// <summary>
        /// Tela para verificar as configurações de idioma 
        /// </summary>
        public TelaDeConfg()
        {
            InitializeComponent();
            comboBoxIdioma.Focus();
            //seleciona no comboBox o idioma/cultura atual
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);


            comboBoxIdioma.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comboBoxIdioma.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            checkBoxIdiomaReiniciar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            checkBoxIdiomaReiniciar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            BtnSalvar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            BtnSalvar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
          

            comboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso! Reinicie a aplicação para aplicar o novo Idioma/região!");
            if (checkBoxIdiomaReiniciar.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
