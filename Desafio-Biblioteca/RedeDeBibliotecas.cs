namespace Desafio_Biblioteca
{
    public class RedeDeBibliotecas
    {
        public List<Biblioteca> Bibliotecas { get; set; }
        public List<Funcionario> Funcionarios { get; set; }

        public List<Usuario> Usuarios { get; set; }

        public void CadastrarUsuario(Usuario usuario)
        {
            if (!Usuarios.Contains(usuario))
            {
                Usuarios.Add(usuario);
                Console.WriteLine($"Usuário {usuario.Nome} foi cadastrado.");
            }
            else
            {
                Console.WriteLine($"Usuário {usuario.Nome} já está cadastrado.");
            }
        }

        // Método para verificar se o usuário está cadastrado
        public bool VerificarCadastro(string cpf)
        {
            return Usuarios.Any(u => u.Cpf == cpf);
        }

        public RedeDeBibliotecas()
        {
            Bibliotecas = new List<Biblioteca>();
            Funcionarios = new List<Funcionario>();
            Usuarios = new List<Usuario>();
        }

        // Método para adicionar uma nova biblioteca à rede
        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            if (!Bibliotecas.Contains(biblioteca))
            {
                Bibliotecas.Add(biblioteca);
                Console.WriteLine($"Biblioteca {biblioteca.Nome} foi adicionada à rede.");
            }
            else
            {
                Console.WriteLine($"Biblioteca {biblioteca.Nome} já está na rede.");
            }
        }

        // Método para remover uma biblioteca da rede
        public void RemoverBiblioteca(Biblioteca biblioteca)
        {
            if (Bibliotecas.Contains(biblioteca))
            {
                Bibliotecas.Remove(biblioteca);
                Console.WriteLine($"Biblioteca {biblioteca.Nome} foi removida da rede.");
            }
            else
            {
                Console.WriteLine($"Biblioteca {biblioteca.Nome} não encontrada na rede.");
            }
        }

        // Método para adicionar um funcionário à rede de bibliotecas
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if (!Funcionarios.Contains(funcionario))
            {
                Funcionarios.Add(funcionario);
                Console.WriteLine($"Funcionário {funcionario.Nome} foi adicionado à rede.");
            }
            else
            {
                Console.WriteLine($"Funcionário {funcionario.Nome} já está na rede.");
            }
        }

        // Método para remover um funcionário da rede
        public void RemoverFuncionario(Funcionario funcionario)
        {
            if (Funcionarios.Contains(funcionario))
            {
                Funcionarios.Remove(funcionario);
                Console.WriteLine($"Funcionário {funcionario.Nome} foi removido da rede.");
            }
            else
            {
                Console.WriteLine($"Funcionário {funcionario.Nome} não encontrado na rede.");
            }
        }
    }
}
