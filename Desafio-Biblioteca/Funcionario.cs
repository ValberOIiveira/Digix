namespace Desafio_Biblioteca
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; set; }
        public CatalogoDeLivros CatalogoDeLivros { get; set; }
        public Biblioteca Biblioteca { get; set; } // Referência à biblioteca onde o funcionário trabalha
        public RedeDeBibliotecas Rede { get; set; } // Referência à rede de bibliotecas

        public Funcionario(string nome, string cpf, string cargo, CatalogoDeLivros catalogoDeLivros, Biblioteca biblioteca, RedeDeBibliotecas rede) 
            : base(nome, cpf)
        {
            Nome = nome;
            Cpf = cpf;
            Cargo = cargo;
            CatalogoDeLivros = catalogoDeLivros;
            Biblioteca = biblioteca;
            Rede = rede; // Inicializa a referência à rede de bibliotecas
        }

        public void AdicionarLivro(Livro livro)
        {
            CatalogoDeLivros.AdicionarLivro(livro);
        }

        public void RemoverLivro(Livro livro)
        {
            CatalogoDeLivros.RemoverLivro(livro);
        }

        public void EmprestarLivro(Livro livro, Leitor leitor)
        {
            // Verifica se o leitor está cadastrado na rede de bibliotecas
            if (!leitor.EstaCadastrado(Rede))
            {
                Console.WriteLine($"O leitor {leitor.Nome} não está cadastrado na biblioteca.");
                return;  // Não permite o empréstimo se não estiver cadastrado
            }

            if (livro.Disponivel())
            {
                // Decrementa o número de exemplares ao emprestar
                livro.Emprestar();
                // Registra o empréstimo no Leitor
                leitor.AdicionarLivroEmprestado(livro);
                Console.WriteLine($"Livro '{livro.Titulo}' emprestado ao leitor {leitor.Nome}. Exemplares restantes: {livro.NumeroDeExemplares}");
            }
            else
            {
                Console.WriteLine($"O livro '{livro.Titulo}' não está disponível para empréstimo.");
            }
        }

        // Método de devolução de livro
        public void DevolverLivro(Livro livro, Leitor leitor)
        {
            if (leitor.LivrosEmprestados.Contains(livro))
            {
                // Incrementa o número de exemplares ao devolver
                livro.Devolver();
                // Remove o livro da lista de livros emprestados do Leitor
                leitor.RemoverLivroEmprestado(livro);
                Console.WriteLine($"Livro '{livro.Titulo}' devolvido pelo leitor {leitor.Nome}. Exemplares disponíveis: {livro.NumeroDeExemplares}");
            }
            else
            {
                Console.WriteLine($"O leitor {leitor.Nome} não tem o livro '{livro.Titulo}'.");
            }
        }
    }
}
