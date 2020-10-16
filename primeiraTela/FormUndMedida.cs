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
        int codigo;
        int linha = 0;
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

      

        private void btnSairCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastroProduto f = new FormCadastroProduto();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnExcluirUndMedida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja remover esse item?", "Remover item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                bll.Excluir(Convert.ToInt32(codigo));

                MessageBox.Show("Item excluido com sucesso!");

                inputInserirUndMedida.Text = String.Empty;
                gridViewUndMedida.DataSource = bll.Localizar(inputInserirUndMedida.Text);

                btnSalvarUndMedida.Visible = false;
                btnExcluirUndMedida.Visible = false;
                btnInserirUndMedida.Visible = true;

            }
            else
            {
                MessageBox.Show("Item não removido", "Remover item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridViewUndMedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            inputInserirUndMedida.Text = gridViewUndMedida.Rows[linha].Cells[1].Value.ToString();
            codigo = Convert.ToInt32(gridViewUndMedida.Rows[linha].Cells[0].Value.ToString());

            btnSalvarUndMedida.Visible = true;
            btnInserirUndMedida.Visible = false;
            btnExcluirUndMedida.Visible = true;
        }

        private void FormUndMedida_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
            gridViewUndMedida.DataSource = bll.Localizar(inputInserirUndMedida.Text);

            gridViewUndMedida.Columns[0].HeaderText = "Código";
            gridViewUndMedida.Columns[0].Width = 50;
            gridViewUndMedida.Columns[1].HeaderText = "Unidade de medida";
            gridViewUndMedida.Columns[1].Width = 253;

            btnSalvarUndMedida.Visible = false;
            btnExcluirUndMedida.Visible = false;
        }

        private void gridViewUndMedida_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            linha = int.Parse(e.RowIndex.ToString());
        }

        private void btnInserirUndMedida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma inclusão do item?", "Incluir item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
                modelo.UmedNome = inputInserirUndMedida.Text;
                DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                bll.Incluir(modelo);
                inputInserirUndMedida.Text = String.Empty;
                gridViewUndMedida.DataSource = bll.Localizar(inputInserirUndMedida.Text);
                MessageBox.Show("Cadastro efetuado!");
            }
            else
            {
                MessageBox.Show("Item não incluido!", "Incluir item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvarUndMedida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja efetuar alteração?", "Alterar item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
                DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
                modelo.UmedCod = Convert.ToInt32(codigo);
                modelo.UmedNome = inputInserirUndMedida.Text;

                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                bll.Alterar(modelo);
                inputInserirUndMedida.Text = String.Empty;
                MessageBox.Show("Item alterado");
                btnInserirUndMedida.Visible = true;
                btnSalvarUndMedida.Visible = false;
                btnExcluirUndMedida.Visible = false;
                gridViewUndMedida.DataSource = bll.Localizar(inputInserirUndMedida.Text);
            }

            else
            {
                MessageBox.Show("Item não alterado!", "Alterar item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void inputInserirUndMedida_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisarUndMedida_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            gridViewUndMedida.DataSource = bll.Localizar(inputInserirUndMedida.Text);
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
