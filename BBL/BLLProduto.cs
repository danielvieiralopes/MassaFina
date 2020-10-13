using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProduto
    {
        #region[Objetos/Variaveis]
        private DALConexao conexao;
        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }
        #endregion
        #region[Incluir Produto]
        public void Incluir(ModeloProduto obj)
        {
            if (obj.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (obj.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatória");
            }

            if (obj.ProValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório");
            }

            if (obj.ProQtde < 0)
            {
                throw new Exception("A quantidade do produto deve ser maior ou igual a zero");
            }

            if (obj.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório");
            }

            if (obj.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }

            if (obj.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Incluir(obj);
        }
        #endregion
        #region[Excluir Produto]
        public void Excluir(int codigo)
        {
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Excluir(codigo);
        }
        #endregion
        #region[Alterar Produto]
        public void Alterar(ModeloProduto obj)
        {
            if (obj.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (obj.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatória");
            }

            if (obj.ProValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório");
            }

            if (obj.ProQtde < 0)
            {
                throw new Exception("A quantidade do produto deve ser maior ou igual a zero");
            }

            if (obj.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório");
            }

            if (obj.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }

            if (obj.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }

            if (obj.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Alterar(obj);
        }
        #endregion
        #region[Localizar Produto]
        public DataTable Localizar(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.Localizar(valor);
        }
        #endregion
        #region[Buscar Produto pelo id]
        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.CarregaModeloProduto(codigo);
        }
        #endregion
    }
}
