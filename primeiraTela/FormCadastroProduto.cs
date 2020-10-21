using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Modelo;
using System.IO;
using System.Runtime.InteropServices;

namespace primeiraTela
{
    
    public partial class FormCadastroProduto : Form
    {
        int catCodigo;
        int scatCodigo;
        int umedCodigo;

        //public string foto = "";


        //public FormCadastroProduto()
        //{

        //    InitializeComponent();
        //}

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show();
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosdaConexao.StringDeConexao);
            
            BLLCategoria bll = new BLLCategoria(cx);
            lkUpEditCategoriaCadastroProduto.Properties.DataSource = bll.Localizar("");
            lkUpEditCategoriaCadastroProduto.Properties.DisplayMember = "cat_nome";
            lkUpEditCategoriaCadastroProduto.Properties.ValueMember = "cat_cod";

            BLLSubCategoria bllSubCategoria = new BLLSubCategoria(cx);
            lkUpEditSubCategoriaCadastroProduto.Properties.DataSource = bllSubCategoria.LocalizarPorCategoria(catCodigo);
            lkUpEditSubCategoriaCadastroProduto.Properties.DisplayMember = "scat_nome";
            lkUpEditSubCategoriaCadastroProduto.Properties.ValueMember = "scat_cod";
            lkUpEditSubCategoriaCadastroProduto.CascadingOwner = lkUpEditCategoriaCadastroProduto;

            BLLUnidadeDeMedida bllUnidadeDeMedida = new BLLUnidadeDeMedida(cx);
            lkUpEditUndMedidaCadastroProduto.Properties.DataSource = bllUnidadeDeMedida.Localizar("");
            lkUpEditUndMedidaCadastroProduto.Properties.DisplayMember = "umed_nome";
            lkUpEditUndMedidaCadastroProduto.Properties.DisplayMember = "umed_cod";


        }

        private void inputCustoCadastroProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!inputCustoCadastroProduto.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void inputMargemCadastroProduto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void inputVendaCadastroProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!inputVendaCadastroProduto.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void inputCustoCadastroProduto_Leave(object sender, EventArgs e)
        {
            if (inputCustoCadastroProduto.Text.Contains(",") == false)
            {
                inputCustoCadastroProduto.Text += ",00";
            }
            else
            {
                if (inputCustoCadastroProduto.Text.IndexOf(",") == inputCustoCadastroProduto.Text.Length - 1)
                {
                    inputCustoCadastroProduto.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(inputCustoCadastroProduto.Text);
            }
            catch
            {
                inputCustoCadastroProduto.Text = "0,00";
            }
        }

        private void inputDescricaoCadastroProduto_Click(object sender, EventArgs e)
        {
            

                //if (inputDescricaoCadastroProduto.Text.Trim() != "" || inputDescricaoCadastroProduto.Text != null)

                //{

                //inputDescricaoCadastroProduto.Text = "";

                //}

            
        }

        private void inputDescricaoCadastroProduto_Leave(object sender, EventArgs e)
        {
        //    if (inputDescricaoCadastroProduto.Text.Trim() == "" || inputDescricaoCadastroProduto.Text == null)

        //    {

        //        inputDescricaoCadastroProduto.Text = "Descrição do Produto";

        //    }
        }

        private void inputCustoCadastroProduto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void inputVendaCadastroProduto_Leave(object sender, EventArgs e)
        {
            if (inputVendaCadastroProduto.Text.Contains(",") == false)
            {
                inputVendaCadastroProduto.Text += ",00";
            }
            else
            {
                if (inputVendaCadastroProduto.Text.IndexOf(",") == inputVendaCadastroProduto.Text.Length - 1)
                {
                    inputVendaCadastroProduto.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(inputVendaCadastroProduto.Text);
            }
            catch
            {
                inputVendaCadastroProduto.Text = "0,00";
            }
        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProdutos f = new FormProdutos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void inputQtdeCadastroProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!inputQtdeCadastroProduto.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void inputQtdeCadastroProduto_Leave(object sender, EventArgs e)
        {
            if (inputQtdeCadastroProduto.Text.Contains(",") == false)
            {
                inputQtdeCadastroProduto.Text += ",00";
            }
            else
            {
                if (inputQtdeCadastroProduto.Text.IndexOf(",") == inputQtdeCadastroProduto.Text.Length - 1)
                {
                    inputQtdeCadastroProduto.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(inputQtdeCadastroProduto.Text);
            }
            catch
            {
                inputQtdeCadastroProduto.Text = "0,00";
            }
        }

        private void cbMateriaCadastroProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void FormCadastroProduto_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void inputNomeCadastroProduto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void inputMargemCadastroProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputMargemCadastroProduto.Text.Contains(",") == false)
            {
                inputMargemCadastroProduto.Text += ",00";
            }
            else
            {
                if (inputMargemCadastroProduto.Text.IndexOf(",") == inputMargemCadastroProduto.Text.Length - 1)
                {
                    inputMargemCadastroProduto.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(inputMargemCadastroProduto.Text);
            }
            catch
            {
                inputMargemCadastroProduto.Text = "0,00";
            }
        }

        private void inputVendaCadastroProduto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void inputMargemCadastroProduto_Leave(object sender, EventArgs e)
        {
            if (inputMargemCadastroProduto.Text.Contains(",") == false)
            {
                inputMargemCadastroProduto.Text += ",00";
            }
            else
            {
                if (inputMargemCadastroProduto.Text.IndexOf(",") == inputMargemCadastroProduto.Text.Length - 1)
                {
                    inputMargemCadastroProduto.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(inputMargemCadastroProduto.Text);
            }
            catch
            {
                inputMargemCadastroProduto.Text = "0,00";
            }
        }

        private void inputQtdeCadastroProduto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCategoria f = new FormCategoria();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSubCategoria f = new FormSubCategoria();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUndMedida f = new FormUndMedida();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void lkUpEditCategoriaCadastroProduto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lkUpEditCategoriaCadastroProduto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            catCodigo = Convert.ToInt32(lkUpEditCategoriaCadastroProduto.GetColumnValue("cat_cod"));
        }

        private void lkUpEditSubCategoriaCadastroProduto_DoubleClick(object sender, EventArgs e)
        {

        }

        private void lkUpEditSubCategoriaCadastroProduto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            scatCodigo = Convert.ToInt32(lkUpEditCategoriaCadastroProduto.GetColumnValue("cat_cod"));

        }

        private void lkUpEditUndMedidaCadastroProduto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lkUpEditUndMedidaCadastroProduto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            umedCodigo = Convert.ToInt32(lkUpEditCategoriaCadastroProduto.GetColumnValue("cat_cod"));

        }
    }
}
