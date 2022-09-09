namespace Estoque.Dominio
{
    public class Subcategoria : BaseAncestral
    {
        private int codigoCategoria;

        public Subcategoria(int codigo, string descricao, bool situacao, int codigoCategoria) : base(codigo, descricao, situacao)
        {
            this.codigoCategoria = codigoCategoria;
        }

        public int CodigoCategoria
        {
            get => this.codigoCategoria;
            set => this.codigoCategoria = value;
        }
    }
}