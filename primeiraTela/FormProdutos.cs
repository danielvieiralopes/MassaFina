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
    public partial class FormProdutos : System.Windows.Forms.Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu f = new FormMenu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastroProduto f = new FormCadastroProduto();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
