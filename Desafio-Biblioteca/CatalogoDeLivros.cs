namespace Desafio_Biblioteca
{
    public class CatalogoDeLivros
    {
        private List<Livro> Livros {get; set;}

        public CatalogoDeLivros()
        {
            Livros = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void RemoverLivro(Livro livro)
        {
            Livros.Remove(livro);
        }

        public List<Livro> ListarLivros()
        {
            return new List<Livro>(Livros);
        }
        
    }
}