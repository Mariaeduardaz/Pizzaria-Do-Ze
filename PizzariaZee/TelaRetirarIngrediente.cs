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
    /// Tela para caso haja alguma retirada de ingrediente 
    /// </summary>
    public partial class TelaRetirarIngrediente : Form
    {
        public TelaRetirarIngrediente()
        {
            InitializeComponent();
            comboBoxIngrediente.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

            comboBoxIngrediente.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comboBoxIngrediente.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            retirarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            retirarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelbtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelbtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            ConcluirBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            ConcluirBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
        }
        private void ConcluirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
