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
    public partial class FormClientes : System.Windows.Forms.Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroCliente f = new FormCadastroCliente();
            f.ShowDialog();
            f.Dispose();

             
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormCadastroCliente f = new FormCadastroCliente();
            new FormLogin().ShowDialog();
            f.Dispose();
        }
    }
}
