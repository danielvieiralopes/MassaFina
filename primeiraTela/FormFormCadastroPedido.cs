﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiraTela
{
    public partial class FormFormCadastroPedido : Form
    {
        public FormFormCadastroPedido()
        {
            InitializeComponent();
        }

        private void FormFormCadastroPedido_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarCadastroPedido_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
