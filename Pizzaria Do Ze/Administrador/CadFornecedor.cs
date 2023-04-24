using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Pizzaria_Do_Ze.Administrador;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Administrador
{
    /// <summary>
    /// Tela para o cadastro do fornecedor 
    /// </summary>
    public partial class CadFornecedor : Form
    {
        public CadFornecedor()
        {
            InitializeComponent();
            nameTextBot.Focus();
            Funcoes.AjustaResourcesControl(this);
        }

        private void CadFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void cadGenerico1_Load(object sender, EventArgs e)
        {

        }
    }
}
