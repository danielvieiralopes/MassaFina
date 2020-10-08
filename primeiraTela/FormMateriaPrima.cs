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
    public partial class FormMateriaPrima : Form
    {
        public FormMateriaPrima()
        {
            InitializeComponent();
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
