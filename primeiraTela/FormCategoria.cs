using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace primeiraTela
{
    public partial class FormCategoria : Form
    {
        int codigo;
        int linha = 0;

        public FormCategoria()
        {
            InitializeComponent();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            gridControlCategoria_Click(sender, e);

            gridViewCategoria.Columns[0].HeaderText = "Código";
            gridViewCategoria.Columns[0].Width = 50;
            gridViewCategoria.Columns[1].HeaderText = "Categoria";
            gridViewCategoria.Columns[1].Width = 290;

            btnSalvarCategoria.Visible = false;
            btnExcluirCategoria.Visible = false;
        }
        private void gridControlCategoria_Click(object sender, EventArgs e)
        {
            
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            gridViewCategoria.DataSource = bll.Localizar(inputInserirCategoria.Text);
        }

        private void gridViewCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            inputInserirCategoria.Text = gridViewCategoria.Rows[linha].Cells[1].Value.ToString();
            codigo = Convert.ToInt32(gridViewCategoria.Rows[linha].Cells[0].Value.ToString());

            btnSalvarCategoria.Visible = true;
            btnInserirCategoria.Visible = false;
            btnExcluirCategoria.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            gridViewCategoria.DataSource = bll.Localizar(inputInserirCategoria.Text);

        }

        private void gridViewCategoria_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            linha = int.Parse(e.RowIndex.ToString());
        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {
            ModeloCategoria modelo = new ModeloCategoria();
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            modelo.CatCod = Convert.ToInt32(codigo);
            modelo.CatNome = inputInserirCategoria.Text;

            BLLCategoria bll = new BLLCategoria(cx);
            bll.Alterar(modelo);
            inputInserirCategoria.Text = String.Empty;
            MessageBox.Show("Cadastro Alterado ");
            btnInserirCategoria.Visible = true;
            btnSalvarCategoria.Visible = false;
            gridViewCategoria.DataSource = bll.Localizar(inputInserirCategoria.Text);

        }

        private void btnInserirCategoria_Click(object sender, EventArgs e)
        {
            ModeloCategoria modelo = new ModeloCategoria();
            modelo.CatNome = inputInserirCategoria.Text;
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            bll.Incluir(modelo);
            inputInserirCategoria.Text = String.Empty;
            gridViewCategoria.DataSource = bll.Localizar(inputInserirCategoria.Text);
            MessageBox.Show("Cadastro efetuado: Código " + modelo.CatCod.ToString());
        }

        private void btnSairCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastroProduto f = new FormCadastroProduto();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            bll.Excluir(Convert.ToInt32(codigo));

            MessageBox.Show("Categoria excluida com sucesso");

            inputInserirCategoria.Text = String.Empty;
            gridViewCategoria.DataSource = bll.Localizar(inputInserirCategoria.Text);

            btnSalvarCategoria.Visible = false;
            btnExcluirCategoria.Visible = false;
            btnInserirCategoria.Visible = true;
        }

        private void gridViewCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }      
}
