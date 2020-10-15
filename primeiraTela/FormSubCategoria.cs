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
using DAL;
using BLL;

namespace primeiraTela
{
    public partial class FormSubCategoria : Form
    {
        public FormSubCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelarSubCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastroProduto f = new FormCadastroProduto();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void FormSubCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'massaFinaDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.massaFinaDataSet.categoria);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriaTableAdapter.FillBy(this.massaFinaDataSet.categoria);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnInserirCategoria_Click(object sender, EventArgs e)
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();
            modelo.ScatNome = inputInserirSubCategoria.Text;
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            BLLSubCategoria bll = new BLLSubCategoria(cx);
            bll.Incluir(modelo);
            inputInserirSubCategoria.Text = String.Empty;
        }

        private void gridViewSubCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
