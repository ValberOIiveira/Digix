namespace Desafio_Biblioteca
{
    public class Leitor : Usuario
    {

        public bool Cadastrado;
        public List<Livro> LivrosEmprestados { get; set; }

        public Leitor(string nome, string cpf, bool cadastrado) : base(nome, cpf)
        {
            Cadastrado = cadastrado;
            LivrosEmprestados = new List<Livro>();
        }


        public bool EstaCadastrado(RedeDeBibliotecas rede)
        {
            return rede.VerificarCadastro(Cpf);
        }

        public void AdicionarLivroEmprestado(Livro livro)
        {
            LivrosEmprestados.Add(livro);
        }

        // Método para remover um livro da lista do leitor (quando o livro é devolvido)
        public void RemoverLivroEmprestado(Livro livro)
        {
            LivrosEmprestados.Remove(livro);
        }

        // Método para exibir os livros emprestados
        public void ExibirLivrosEmprestados()
        {
            if (LivrosEmprestados.Count == 0)
            {
                Console.WriteLine($"{Nome} não tem livros emprestados no momento.");
            }
            else
            {
                Console.WriteLine($"{Nome} tem os seguintes livros emprestados:");
                foreach (var livro in LivrosEmprestados)
                {
                    Console.WriteLine($"- {livro.Titulo} ({livro.Autor})");
                }
            }
        }
    }
}