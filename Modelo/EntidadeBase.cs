namespace Modelo
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }

        public void AlterarStatus(bool status)
        {
            Ativo = status;
        }
    }
}
