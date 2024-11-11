using biblioteca;

namespace usuario
{
    public class Usuario
    {
        public string ?nome { get; set; }
        public string ?email { get; set; }
        public List<Livro> listaDeLivrosEmprestados { get; set; } = new List<Livro>();

        public void PegarEmprestado(Livro livro)
        {
            if (livro.disponivel)
            {
                listaDeLivrosEmprestados.Add(livro);
            }
            else
            {
                Console.WriteLine("Livro não disponível");
            }
        }

        public void DevolverLivro(Livro livro)
        {
            if (listaDeLivrosEmprestados.Contains(livro))
            {
                listaDeLivrosEmprestados.Remove(livro);
                livro.disponivel = true;
                Console.WriteLine("Livro devolvido com sucesso");
            }
        }
    }
}
