namespace Estoque.Dominio
{
    public abstract class BaseAncestral
    {
        protected int codigo;
        protected string descricao = string.Empty;
        protected bool situacao;

        public int Codigo 
        {
            get => this.codigo;
            set => this.codigo = value;
        }

        public string Descricao
        {
            get => this.descricao;
            set => this.descricao = value;
        }

        public bool Situacao
        {
            get => this.situacao;
            set => this.situacao = value;
        }

        public BaseAncestral(int codigo, string descricao, bool situacao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.situacao = situacao;
        }
    }
}