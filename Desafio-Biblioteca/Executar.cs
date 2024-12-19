using System;

namespace Desafio_Biblioteca
{
    class Executar
    {
        static void Main(string[] args)
        {
            // Criação da rede de bibliotecas
            RedeDeBibliotecas redeDeBibliotecas = new RedeDeBibliotecas();

            // Criação das bibliotecas
            Biblioteca bibliotecaCentral = new Biblioteca("Biblioteca Central", redeDeBibliotecas);
            Biblioteca bibliotecaBairro = new Biblioteca("Biblioteca do Bairro", redeDeBibliotecas);

            // Criação do catálogo de livros
            CatalogoDeLivros catalogoCentral = new CatalogoDeLivros();
            CatalogoDeLivros catalogoBairro = new CatalogoDeLivros();

            // Adicionando os livros aos catálogos
            Livro livro1 = new Livro("C# para Iniciantes", "José da Silva", 2020, 3);
            Livro livro2 = new Livro("Programação Orientada a Objetos", "Maria Souza", 2019, 2);

            // Associando livros aos catálogos das bibliotecas
            catalogoCentral.AdicionarLivro(livro1);
            catalogoBairro.AdicionarLivro(livro2);

            // Criação dos funcionários e vinculação com a biblioteca correta
            Funcionario funcionarioCarlos = new Funcionario("Carlos Silva", "12345678901", "Gerente", catalogoCentral, bibliotecaCentral, redeDeBibliotecas);
            Funcionario funcionarioMariana = new Funcionario("Mariana Costa", "98765432100", "Assistente", catalogoBairro, bibliotecaBairro, redeDeBibliotecas);

            // Adicionando funcionários às bibliotecas
            bibliotecaCentral.AdicionarFuncionario(funcionarioCarlos);
            bibliotecaBairro.AdicionarFuncionario(funcionarioMariana);

            // Criação dos leitores
            Leitor leitorJoao = new Leitor("João Pereira", "11122233344", true);
            Leitor leitorAna = new Leitor("Ana Souza", "55566677788", true);

            // Cadastrando os leitores na rede
            redeDeBibliotecas.CadastrarUsuario(leitorJoao);
            redeDeBibliotecas.CadastrarUsuario(leitorAna);

            // Exibindo os livros disponíveis na biblioteca Central
            Console.WriteLine("Livros disponíveis na Biblioteca Central:");
            foreach (var livro in bibliotecaCentral.Livros)
            {
                Console.WriteLine($"- {livro.Titulo} ({livro.Autor})");
            }

            // Tentando emprestar livros para os leitores
            Console.WriteLine("\nTentando emprestar livro para João Pereira (Leitor cadastrado):");
            funcionarioCarlos.EmprestarLivro(livro1, leitorJoao);

            Console.WriteLine("\nTentando emprestar livro para Ana Souza (Leitor cadastrado):");
            funcionarioMariana.EmprestarLivro(livro2, leitorAna);

            // Exibindo os livros emprestados
            leitorJoao.ExibirLivrosEmprestados();

            // João devolvendo o livro
            Console.WriteLine("\nJoão Pereira devolvendo o livro:");
            funcionarioCarlos.DevolverLivro(livro1, leitorJoao);

            // Exibindo livros emprestados após devolução
            leitorJoao.ExibirLivrosEmprestados();

            // Exibindo o número de exemplares após a devolução
            Console.WriteLine($"\nNúmero de exemplares de '{livro1.Titulo}' após devolução: {livro1.NumeroDeExemplares}");
        }
    }
}
