using System;
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
    public partial class FormMenu : System.Windows.Forms.Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormProdutos f = new FormProdutos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPedidos f = new FormPedidos();
            f.Closed += (s, args) => this.Close();
            f.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.Closed += (s, args) => this.Close();
            f.Show();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClientes f = new FormClientes();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {

        }

        private void btnOrçamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrcamento f = new FormOrcamento();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
