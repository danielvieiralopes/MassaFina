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
    public partial class FormOrcamento : Form
    {
        public FormOrcamento()
        {
            InitializeComponent();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridOrcamento_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormOrcamento_Load(object sender, EventArgs e)
        {
           btnPesquisarOrcamento_Click(sender, e);
        }

        private void btnPesquisarOrcamento_Click(object sender, EventArgs e)
        {
              
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu f = new FormMenu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
