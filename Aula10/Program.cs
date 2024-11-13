using System.Linq.Expressions;

namespace listaRecursao
{
    class Program
    {
        static void somaNumeros(int n)
        {
            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                soma += i;
            }

            Console.WriteLine($"A soma dos números de 1 até {n} é: {soma}");
        }

        static void multiplicaNumeros(int n)
        {
            int produto = 1;

            for (int i = 1; i <= n; i++)
            {
                produto *= i;
            }

            Console.WriteLine($"O produto dos números de 1 até {n} é: {produto}");
        }

        static void calculaPotencia(int x, int y)
        {
            double resultado = Math.Pow(x, y);

            if (y <= 0)
            {
                System.Console.WriteLine("O expoente não pode ser negativo!");
                Console.WriteLine("Digite um novo número: ");
                y = int.Parse(Console.ReadLine());
                calculaPotencia(x, y);
            }
            else
            {
                Console.WriteLine($"{x} elevado a {y} é igual a {resultado}");
            }
        }

        static int calculaMDC(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return calculaMDC(b, a % b);
            }
        }

        static void somaElementos(int[] vetor)
        {

            if (vetor.Length > 0)
            {
                int resultado = vetor.Sum();
                Console.WriteLine($"A soma dos elementos do vetor é: {resultado}");
            }

            else
            {
                Console.WriteLine("O vetor não pode ser vazio");
                Console.WriteLine("Digite um vetor válido (separado por vírgulas): ");


                string input = Console.ReadLine();


                try
                {
                    int[] novoVetor = input.Split(',').Select(int.Parse).ToArray();


                    somaElementos(novoVetor);
                }
                catch (FormatException)
                {

                    Console.WriteLine("Entrada inválida. Certifique-se de digitar apenas números separados por vírgulas.");
                    somaElementos(new int[] { });
                }
            }

            static void mediaElementos(int[] vetor)
            {

                if (vetor.Length > 0)
                {
                    double resultado = vetor.Average();
                    Console.WriteLine($"A média dos elementos do vetor é: {resultado}");
                }

                else
                {
                    Console.WriteLine("O vetor não pode ser vazio");
                    Console.WriteLine("Digite um vetor válido (separado por vírgulas): ");


                    string input = Console.ReadLine();


                    try
                    {
                        int[] novoVetor = input.Split(',').Select(int.Parse).ToArray();


                        mediaElementos(novoVetor);
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Entrada inválida. Certifique-se de digitar apenas números separados por vírgulas.");
                        mediaElementos(new int[] { });
                    }
                }
            }

            static void Main(string[] args)
            {
                // Teste para somaNumeros
                Console.WriteLine("Teste somaNumeros");
                somaNumeros(5); // Esperado: 15 (1+2+3+4+5)

                // Teste para multiplicaNumeros
                Console.WriteLine("\nTeste multiplicaNumeros");
                multiplicaNumeros(5); // Esperado: 120 (1*2*3*4*5)

                // Teste para calculaPotencia
                Console.WriteLine("\nTeste calculaPotencia");
                calculaPotencia(2, 3); // Esperado: 8 (2^3)

                // Teste para calculaMDC
                Console.WriteLine("\nTeste calculaMDC");
                int mdc = calculaMDC(56, 98); // Esperado: 14
                Console.WriteLine($"MDC de 56 e 98 é: {mdc}");

                // Teste para somaElementos
                Console.WriteLine("\nTeste somaElementos");
                int[] vetor1 = { 1, 2, 3, 4, 5 };
                somaElementos(vetor1); // Esperado: 15 (1+2+3+4+5)

                // Teste para mediaElementos
                Console.WriteLine("\nTeste mediaElementos");
                int[] vetor2 = { 10, 20, 30, 40, 50 };
                mediaElementos(vetor2); // Esperado: 30 (média dos elementos)
            }
        }
    }
}
