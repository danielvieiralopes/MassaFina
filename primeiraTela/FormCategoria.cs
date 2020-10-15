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
using DevExpress.XtraPrinting;

namespace primeiraTela
{
    public partial class FormCategoria : Form
    {
        public int codigo = 0;

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
            gridViewCategoria.Columns[1].Width = 700;
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastroProduto f = new FormCadastroProduto();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {

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


        }

        private void gridControlCategoria_Click(object sender, EventArgs e)
        {
            
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            gridViewCategoria.DataSource = bll.Localizar(inputInserirCategoria.Text);
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {

            
           
                DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);
                ModeloCategoria modelo = bll.CarregaModeloCategoria(gridViewCategoria.SelectedRows.);
                inputInserirCategoria.Text = modelo.CatNome;

            }
        }

      
}
