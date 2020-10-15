using System;

namespace Modelo
{
    public class ModeloCategoria : EntidadeBase
    {
        private int cat_cod;
        public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }
      
        private String cat_nome;
        public String CatNome
        {
            get { return this.cat_nome; }
            set { this.cat_nome = value; }
        }
    }
}
