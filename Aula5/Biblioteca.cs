using usuario;

namespace biblioteca
{
    public class Biblioteca
    {
        private List<Livro> ListaDeLivros {get; set; } = new List<Livro>();

        private List<Usuario> ListaDeUsuarios { get; set; } = new List<Usuario>();


        public void AdicionarLivro(Livro livro)
        {
            ListaDeLivros.Add(livro);
            Console.WriteLine($"Livro {livro.titulo} adicionado com sucesso!");
        }

        public void RegistrarUsuario(Usuario usuario)
        {
            ListaDeUsuarios.Add(usuario);
            Console.WriteLine($"Usuário {usuario.nome} registrado com sucesso!");
        }

        public void ListarLivrosDisponiveis()
        {
            Console.WriteLine("Livros disponíveis:");
            foreach (var livro in ListaDeLivros)
            {
                if (livro.disponivel)
                {
                    Console.WriteLine($"{livro.titulo} - {livro.autor}");
                }
            }
        }



    }
}