using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloMateria
    {
        public ModeloMateria()
        {
            this.MateriaCod = 0;
            this.MateriaNome = "";
            this.MateriaDescricao = "";
            this.MateriaValorPago = 0;
            this.MateriaQtde = 0;
            this.UmedCod = 0;
            this.ProdutoId = 0;
        }

        public ModeloMateria(int materia_cod, String materia_nome, String materia_descricao, String materia_foto, Double materia_valorpago, Double materia_qtde, int umed_cod, int produto_id )
        {
            this.MateriaCod = materia_cod;
            this.MateriaNome = materia_nome;
            this.MateriaDescricao = materia_descricao;
            this.CarregaImagem(materia_foto);
            this.MateriaValorPago = materia_valorpago;
            this.MateriaQtde = materia_qtde;
            this.UmedCod = umed_cod;
            this.ProdutoId = produto_id;
        }

        public ModeloMateria(int materia_cod, String materia_nome, String materia_descricao, Byte[] materia_foto, Double materia_valorpago, Double materia_qtde, int umed_cod, int produto_id)
        {
            this.MateriaCod = materia_cod;
            this.MateriaNome = materia_nome;
            this.MateriaDescricao = materia_descricao;
            this.MateriaFoto = materia_foto;
            this.MateriaValorPago = materia_valorpago;
            this.MateriaQtde = materia_qtde;
            this.UmedCod = umed_cod;
            this.ProdutoId = produto_id;
        }

        private int _materia_cod;
        public int MateriaCod
        {
            get
            {
                return this._materia_cod;
            }
            set 
            {
                this._materia_cod = value;
            }
        }

        private String _materia_nome;
        public String MateriaNome
        {
            get
            {
                return this._materia_nome;
            }
            set
            {
                this._materia_nome = value;
            }
        }

        private String _materia_descricao;
        public String MateriaDescricao
        {
            get
            {
                return this._materia_descricao;
            }
            set
            {
                this._materia_descricao = value;

            }
        }

        private byte[] _materia_foto;
        public byte[] MateriaFoto
        {
            get
            {
                return this._materia_foto;
            }
            set
            {
                this._materia_foto = value;
            }
        }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedadese métodos de instância para criar, copiar,
                //excluir, mover, e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.MateriaFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.MateriaFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private Double _materia_valorpago;
        public Double MateriaValorPago
        {
            get
            {
                return this._materia_valorpago;
            }
            set
            {
                this._materia_valorpago = value;
            }
        }

        private Double _materia_qtde;
        public Double MateriaQtde
        {
            get
            {
                return this._materia_qtde;
            }
            set
            {
                this._materia_qtde = value;
            }
        }

        private int _umed_cod;
        public int UmedCod
        {
            get
            {
                return this._umed_cod;
            }
            set
            {
                this._umed_cod = value;
            }
        }
        private int _produto_id;
        public int ProdutoId
        {
            get
            {
                return this._produto_id;
            }
            set
            {
                this._produto_id = value;
            }
        }

    }
}
