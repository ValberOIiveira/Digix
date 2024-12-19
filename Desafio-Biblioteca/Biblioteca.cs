namespace Desafio_Biblioteca
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        public RedeDeBibliotecas Rede { get; set; }  // A biblioteca está vinculada a uma rede
        public List<Livro> Livros { get; set; }
        public List<Funcionario> Funcionarios { get; set; }

        public Biblioteca(string nome, RedeDeBibliotecas rede)
        {
            Nome = nome;
            Rede = rede;
            Livros = new List<Livro>();
            Funcionarios = new List<Funcionario>();
        }

        // Método para adicionar um livro à biblioteca
        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
            Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca {Nome}.");
        }

        // Método para remover um livro da biblioteca
        public void RemoverLivro(Livro livro)
        {
            if (Livros.Contains(livro))
            {
                Livros.Remove(livro);
                Console.WriteLine($"Livro '{livro.Titulo}' removido da biblioteca {Nome}.");
            }
            else
            {
                Console.WriteLine($"Livro '{livro.Titulo}' não encontrado na biblioteca {Nome}.");
            }
        }

        // Método para adicionar um funcionário à biblioteca
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if (!Funcionarios.Contains(funcionario))
            {
                Funcionarios.Add(funcionario);
                Console.WriteLine($"Funcionário {funcionario.Nome} foi adicionado à biblioteca {Nome}.");
            }
            else
            {
                Console.WriteLine($"Funcionário {funcionario.Nome} já está na biblioteca {Nome}.");
            }
        }

        // Método para remover um funcionário da biblioteca
        public void RemoverFuncionario(Funcionario funcionario)
        {
            if (Funcionarios.Contains(funcionario))
            {
                Funcionarios.Remove(funcionario);
                Console.WriteLine($"Funcionário {funcionario.Nome} foi removido da biblioteca {Nome}.");
            }
            else
            {
                Console.WriteLine($"Funcionário {funcionario.Nome} não encontrado na biblioteca {Nome}.");
            }
        }
    }
}
