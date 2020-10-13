using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{

    public class DALMateria
    {
        private DALConexao conexao;
        public DALMateria(DALConexao cx)
        {
            this.conexao = cx;
        }
        #region [INCLUIR MATERIA]
        public void Incluir(ModeloMateria obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Materia (materia_nome,materia_descricao,materia_foto,materia_valorpago,materia_qtde, umed_cod, produto_id)" +
            "values (@nome,@descricao,@foto,@valorpago,@qtde,umedcod,@produtoid); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", obj.MateriaNome);
            cmd.Parameters.AddWithValue("@descricao", obj.MateriaDescricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (obj.MateriaFoto == null)
            {
                //cmd.Parameters.AddWithValue("@materia_foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@materia_foto", obj.materia_foto);
                cmd.Parameters["@foto"].Value = obj.MateriaFoto;
            }
            cmd.Parameters.AddWithValue("@valorpago", obj.MateriaValorPago);
            cmd.Parameters.AddWithValue("@qtde", obj.MateriaQtde);
            cmd.Parameters.AddWithValue("@undmedcod", obj.UmedCod);
            cmd.Parameters.AddWithValue("@scatcod", obj.ProdutoId);
            conexao.Conectar();
            obj.MateriaCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }
        #endregion
        #region [EXCLUIR MATERIA]
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Materia where (materia_cod) = (@codigo))";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        #endregion
        #region [ALTERAR MATERIA]
        public void Alterar(ModeloMateria obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Materia SET materia_nome = (@nome), materia_descricao = (@descricao), " +
                "materia_foto = (@foto), materia_valorpago = (@valorpago), " +
                "materia_qtde = (@qtde), umed_cod = (@undmedcod), produto_id = (@produtoid), " +
                " WHERE materia_cod = (@codigo) ";
            cmd.Parameters.AddWithValue("@nome", obj.MateriaNome);
            cmd.Parameters.AddWithValue("@descricao", obj.MateriaDescricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (obj.MateriaFoto == null)
            {
                //cmd.Parameters.AddWithValue("@foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@foto", obj.pro_foto);
                cmd.Parameters["@foto"].Value = obj.MateriaFoto;
            }
            cmd.Parameters.AddWithValue("@valorpago", obj.MateriaValorPago);
            cmd.Parameters.AddWithValue("@qtde", obj.MateriaQtde);
            cmd.Parameters.AddWithValue("@undmedcod", obj.UmedCod);
            cmd.Parameters.AddWithValue("@codigo", obj.ProdutoId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        #endregion
        #region [LOCALIZAR MATERIA]
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select m.materia_cod, m.materia_nome, m.materia_descricao, m.materia_foto, m.materia_valorpago, " +
            " m.materia_qtde, m.umed_cod, m.produto_id " +
            "from Materia m inner join undmedida u on m.umed_cod = u.umed_cod inner join produto p on p.pro_cod = m.produto_id " +
             "where m.materia_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        #endregion
        #region [LOCALIZAR MATERIA BY ID]
        public ModeloMateria CarregaModeloMateria(int codigo)
        {
            ModeloMateria modelo = new ModeloMateria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Materia where materia_cod =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.MateriaCod = Convert.ToInt32(registro["materia_cod"]);
                modelo.MateriaNome = Convert.ToString(registro["materia_nome"]);
                modelo.MateriaDescricao = Convert.ToString(registro["materia_descricao"]);
                try
                {
                    modelo.MateriaFoto = (byte[])registro["materia_foto"];

                }
                catch { }
                modelo.MateriaValorPago = Convert.ToDouble(registro["materia_valorpago"]);
                modelo.MateriaQtde = Convert.ToInt32(registro["materia_qtde"]);
                modelo.UmedCod = Convert.ToInt32(registro["umed_cod"]);
                modelo.ProdutoId = Convert.ToInt32(registro["produto_id"]);
            }
            conexao.Desconectar();
            return modelo;
        }
#endregion

    }
}

