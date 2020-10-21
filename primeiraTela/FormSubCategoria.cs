using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace primeiraTela
{
    public partial class FormSubCategoria : Form
    {
        int catCodigo;
        int codigo;
        int linha = 0;
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

            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            lkUpEditcbCategoriaCadastroSubCategoria.Properties.DataSource = bll.Localizar("");
            lkUpEditcbCategoriaCadastroSubCategoria.Properties.DisplayMember = "cat_nome";
            lkUpEditcbCategoriaCadastroSubCategoria.Properties.ValueMember = "cat_cod";

            //lkUpEditcbCategoriaCadastroSubCategoria.Properties.Columns[0].
            //lkUpEditcbCategoriaCadastroSubCategoria.Properties.Columns[0].Width = 50;
            //lkUpEditcbCategoriaCadastroSubCategoria.Properties.Columns[1].FieldName = "Categoria";
            //lkUpEditcbCategoriaCadastroSubCategoria.Properties.Columns[1].Width = 250;

            BLLSubCategoria bllScat = new BLLSubCategoria(cx);
            gridViewSubCategoria.DataSource = bllScat.Localizar(inputInserirSubCategoria.Text);

            gridViewSubCategoria.Columns[0].HeaderText = "Código";
            gridViewSubCategoria.Columns[0].Width = 50;
            gridViewSubCategoria.Columns[1].HeaderText = "Sub Categoria";
            gridViewSubCategoria.Columns[1].Width = 253;
            gridViewSubCategoria.Columns[2].HeaderText = "Código";
            gridViewSubCategoria.Columns[2].Width = 50;
            gridViewSubCategoria.Columns[3].HeaderText = "Categoria";
            gridViewSubCategoria.Columns[3].Width = 253;

            btnSalvarSubCategoria.Visible = false;
            btnExcluirSubCategoria.Visible = false;


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

 

        private void btnPesquisarSubCategoria_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            BLLSubCategoria bll = new BLLSubCategoria(cx);
            gridViewSubCategoria.DataSource = bll.Localizar(inputInserirSubCategoria.Text);
        }

        private void btnSairSubCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastroProduto f = new FormCadastroProduto();
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

        private void btnExcluirSubCategoria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja remover esse item?", "Remover item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                bll.Excluir(Convert.ToInt32(codigo));

                MessageBox.Show("Item excluido com sucesso!");

                inputInserirSubCategoria.Text = String.Empty;
                gridViewSubCategoria.DataSource = bll.Localizar(inputInserirSubCategoria.Text);

                btnSalvarSubCategoria.Visible = false;
                btnExcluirSubCategoria.Visible = false;
                btnInserirSubCategoria.Visible = true;

            }
            else
            {
                MessageBox.Show("Item não removido", "Remover item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInserirSubCategoria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma inclusão do item?", "Incluir item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.ScatNome = inputInserirSubCategoria.Text;
                modelo.CatCod = Convert.ToInt32(catCodigo);
                DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                bll.Incluir(modelo);
                inputInserirSubCategoria.Text = String.Empty;
                gridViewSubCategoria.DataSource = bll.Localizar(inputInserirSubCategoria.Text);
                MessageBox.Show("Cadastro efetuado!");
            }
            else
            {
                MessageBox.Show("Item não incluido!", "Incluir item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvarSubCategoria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja efetuar alteração?", "Alterar item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
                modelo.ScatCod = Convert.ToInt32(codigo);
                modelo.CatCod = Convert.ToInt32(catCodigo);
                modelo.ScatNome = inputInserirSubCategoria.Text;

                BLLSubCategoria bll = new BLLSubCategoria(cx);
                bll.Alterar(modelo);
                inputInserirSubCategoria.Text = String.Empty;
                MessageBox.Show("Item alterado");
                btnInserirSubCategoria.Visible = true;
                btnSalvarSubCategoria.Visible = false;
                btnExcluirSubCategoria.Visible = false;
                gridViewSubCategoria.DataSource = bll.Localizar(inputInserirSubCategoria.Text);
            }

            else
            {
                MessageBox.Show("Item não alterado!", "Alterar item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridViewSubCategoria_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            linha = int.Parse(e.RowIndex.ToString());
        }


        private void gridViewSubCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            inputInserirSubCategoria.Text = gridViewSubCategoria.Rows[linha].Cells[1].Value.ToString();
            codigo = Convert.ToInt32(gridViewSubCategoria.Rows[linha].Cells[0].Value.ToString());

            btnSalvarSubCategoria.Visible = true;
            btnInserirSubCategoria.Visible = false;
            btnExcluirSubCategoria.Visible = true;
        }

        private void lkUpEditcbCategoriaCadastroSubCategoria_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lkUpEditcbCategoriaCadastroSubCategoria_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            catCodigo = Convert.ToInt32(lkUpEditcbCategoriaCadastroSubCategoria.GetColumnValue("cat_cod"));

   
        }

        private void lkUpEditcbCategoriaCadastroSubCategoria_Enter(object sender, EventArgs e)
        {
            
        }

        private void lkUpEditcbCategoriaCadastroSubCategoria_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void gridViewSubCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inputInserirSubCategoria_Enter(object sender, EventArgs e)
        {
            lkUpEditcbCategoriaCadastroSubCategoria.Visible = true;
        }

        private void lkUpEditcbCategoriaCadastroSubCategoria_Click(object sender, EventArgs e)
        {
         


        }

        private void lkUpEditcbCategoriaCadastroSubCategoria_Popup(object sender, EventArgs e)
        {
        

        }

        private void lkUpEditcbCategoriaCadastroSubCategoria_QueryPopUp(object sender, CancelEventArgs e)
        {
        }
    }
}
