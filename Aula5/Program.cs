using biblioteca;
using usuario;


namespace Cap6
{
    class Program
    {

        static void Main(string[] args)
        {

            // Biblioteca b = new Biblioteca();
            // Usuario u = new Usuario{ nome = "Valber Oliveira", email = "valberoliveira@gmail.com"};



            // Livro livro1 = new Livro { titulo = "1984", autor = "George Orwell", isbn = 123456789 };
            // Livro livro2 = new Livro { titulo = "O Senhor dos Anéis", autor = "J.R.R. Tolkien", isbn = 987654321 };


            // b.AdicionarLivro(livro1);
            // b.AdicionarLivro(livro2);

            // b.RegistrarUsuario(u);
            // b.ListarLivrosDisponiveis();

            // u.PegarEmprestado(livro1);
            // b.ListarLivrosDisponiveis();





            // Console.WriteLine(livro1);
            // Console.WriteLine(livro2);

            // Console.Write("Digite um número: ");
            // int num = Convert.ToInt32(Console.ReadLine());
            // for (int i = 0; i <= 10; i++)
            // {
            //     Console.WriteLine($"{num} x {i} = {num * i}");
            // }



            Console.WriteLine("Digite o valor a ser investido: ");
            double valorInvestido = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o tipo de investimento (1 - Poupança, 2 - Renda Fixa, 3 - Ações): ");
            byte tipoInvestimento = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite o tempo de investimento em anos: ");
            byte tempoInvestimento = Convert.ToByte(Console.ReadLine());

            if (tipoInvestimento == 1)
            {
                // Poupança: 3% ao ano
                Console.WriteLine("Rendimento ano a ano para Poupança:");
                for (int i = 1; i <= tempoInvestimento; i++)
                {
                    valorInvestido *= 1.03; // Aplica o rendimento de 3%
                    Console.WriteLine($"Ano {i}: {valorInvestido:F2}"); // Mostra o valor formatado com 2 casas decimais
                }
            }
            else if (tipoInvestimento == 2)
            {
                // Renda Fixa: 5% ao ano
                Console.WriteLine("Rendimento ano a ano para Renda Fixa:");
                for (int i = 1; i <= tempoInvestimento; i++)
                {
                    valorInvestido *= 1.05; // Aplica o rendimento de 5%
                    Console.WriteLine($"Ano {i}: {valorInvestido:F2}"); 
                }
            }
            else if (tipoInvestimento == 3)
            {
                // Ações: 10% de ganho ou 5% de perda
                Console.WriteLine("Rendimento ano a ano para Ações:");
                Random rand = new Random();
                for (int i = 1; i <= tempoInvestimento; i++)
                {
                    if (rand.NextDouble() < 0.5) 
                    {
                        valorInvestido *= 0.95; 
                    }
                    else
                    {
                        valorInvestido *= 1.10; 
                    }
                    Console.WriteLine($"Ano {i}: {valorInvestido:F2}"); // Mostra o valor formatado com 2 casas decimais

                }

            }

        }

    }

}
