﻿using System;
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
    public partial class CadastrarIngrediente : Form
    {
        private readonly IngredienteDAO dao;
        public CadastrarIngrediente()
        {
            InitializeComponent();
        }
    }
}
