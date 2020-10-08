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
    public partial class FormCadastroOrçamento : Form
    {
        public FormCadastroOrçamento()
        {
            InitializeComponent();
        }

        private void btnCancelarOrcamento_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
