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
    public class BLLMateria
    {
        #region[Objetos/Variaveis]
        private DALConexao conexao;
        public BLLMateria(DALConexao cx)
        {
            this.conexao = cx;
        }
        #endregion
        #region[Incluir Materia]
        public void Incluir(ModeloMateria obj)
        {
            if (obj.MateriaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da materia é obrigatório");
            }

            if (obj.MateriaDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do materia é obrigatória");
            }

            if (obj.MateriaValorPago <= 0)
            {
                throw new Exception("O valor do custo da materia é obrigatório");
            }

            if (obj.MateriaQtde < 0)
            {
                throw new Exception("A quantidade do materia deve ser maior ou igual a zero");
            }

            if (obj.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }

            if (obj.ProdutoId <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALMateria DALobj = new DALMateria(conexao);
            DALobj.Incluir(obj);
        }
        #endregion
        #region[Excluir Materia]
        public void Excluir(int codigo)
        {
            DALMateria DALobj = new DALMateria(conexao);
            DALobj.Excluir(codigo);
        }
        #endregion
        #region[Alterar Materia]
        public void Alterar(ModeloMateria obj)
        {
            if (obj.MateriaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da materia é obrigatório");
            }

            if (obj.MateriaDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do materia é obrigatória");
            }

            if (obj.MateriaValorPago <= 0)
            {
                throw new Exception("O valor do custo da materia é obrigatório");
            }

            if (obj.MateriaQtde < 0)
            {
                throw new Exception("A quantidade do materia deve ser maior ou igual a zero");
            }

            if (obj.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }

            if (obj.ProdutoId <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            DALMateria DALobj = new DALMateria(conexao);
            DALobj.Alterar(obj);
        }
        #endregion
        #region[Localizar Materia]
        public DataTable Localizar(String valor)
        {
            DALMateria DALobj = new DALMateria(conexao);
            return DALobj.Localizar(valor);
        }
        #endregion
        #region[Buscar Materia pelo id]
        public ModeloMateria CarregaModeloMateria(int codigo)
        {
            DALMateria DALobj = new DALMateria(conexao);
            return DALobj.CarregaModeloMateria(codigo);
        }
        #endregion
    }
}
