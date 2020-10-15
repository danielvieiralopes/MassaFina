using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using BLL;
using DAL;

namespace primeiraTela
{
    public partial class FormUndMedida : Form
    {
        public FormUndMedida()
        {
            InitializeComponent();
        }

        private void btnCancelarUndMedida_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastroProduto f = new FormCadastroProduto();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnInserirCategoria_Click(object sender, EventArgs e)
        {
            ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
            modelo.UmedNome = inputInserirUndMedida.Text;
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
            bll.Incluir(modelo);
            inputInserirUndMedida.Text = String.Empty;

        }
    }
}
