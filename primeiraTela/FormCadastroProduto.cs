using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Modelo;
using System.IO;

namespace primeiraTela
{
    public partial class FormCadastroProduto : Form
    {
        public string foto = "";


        public FormCadastroProduto()
        {

            InitializeComponent();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show();
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbMateriaCadastroProduto.DataSource = bll.Localizar("");
            cbMateriaCadastroProduto.DisplayMember = "materia_nome";
            cbMateriaCadastroProduto.ValueMember = "materia_cod";
            //cbCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            //cbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            try
            {
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
            //combo und medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbUnd.DataSource = ubll.Localizar("");
            cbUnd.DisplayMember = "umed_nome";
            cbUnd.ValueMember = "umed_cod";


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
            Close();
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
    }
}
