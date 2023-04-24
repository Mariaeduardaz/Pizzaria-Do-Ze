using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Administrador
{
    /// <summary>
    /// Tela para o cadastro de funccionario 
    /// </summary>
    public partial class cadFuncionario : Form
    {
        public cadFuncionario()
        {
            InitializeComponent();
            nomeTB.Focus();
            Funcoes.AjustaResourcesControl(this);
        }
    }
}
