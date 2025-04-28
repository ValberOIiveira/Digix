namespace Desafio_1701
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // Gerar matriz de números inteiros aleatórios de tamanho NxM onde N e M são definidos pelo usuário
                int[,] matriz = GerarMatriz();

                // Chamar o método para preencher a matriz com números aleatórios
                PreencherMatrizComAleatorios(matriz, 100);

                // Mostrar o menu para o usuário interagir com a matriz
                Menu(matriz);
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Erro: Você deve inserir um número inteiro válido.");
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }

        // Método para preencher a matriz com números aleatórios
        public static void PreencherMatrizComAleatorios(int[,] matriz, int max)
        {
            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(max); // Gera valores de 0 até max-1
                }
            }
        }

        // Método do menu de interação com o usuário
        public static void Menu(int[,] matriz)
        {
            while (true)
            {
                System.Console.WriteLine("\nEscolha uma opção:");
                System.Console.WriteLine("1 - Exibir Matriz");
                System.Console.WriteLine("2 - Somar Linhas da Matriz");
                System.Console.WriteLine("3 - Somar Colunas da Matriz");
                System.Console.WriteLine("4 - Transpor Matriz");
                System.Console.WriteLine("5 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        ExibirMatriz(matriz);
                        break;
                    case "2":
                        SomaLinha(matriz);
                        SalvarEmCSV("soma_linhas.csv", matriz, true);
                        break;
                    case "3":
                        SomaColuna(matriz);
                        SalvarEmCSV("soma_colunas.csv", matriz, false);
                        break;
                    case "4":
                        int[,] matrizTransposta = TransporMatriz(matriz); // Transpor a matriz
                        ExibirMatriz(matrizTransposta); // Exibir a matriz transposta
                        SalvarEmCSV("matriz_transposta.csv", matrizTransposta, false, true); // Salvar a matriz transposta
                        break;
                    case "5":
                        System.Console.WriteLine("Saindo...");
                        return; // Encerra o programa
                    default:
                        System.Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        // Método para somar as linhas da matriz
        public static void SomaLinha(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int soma = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
                System.Console.WriteLine($"Soma da linha {i + 1}: {soma}");
            }
        }

        // Método para transpor a matriz
        public static int[,] TransporMatriz(int[,] matriz)
        {
            // Cria a matriz transposta com as dimensões invertidas
            int[,] transposta = new int[matriz.GetLength(1), matriz.GetLength(0)];

            for (int i = 0; i < matriz.GetLength(0); i++) // Percorre as linhas da matriz original
            {
                for (int j = 0; j < matriz.GetLength(1); j++) // Percorre as colunas da matriz original
                {
                    transposta[j, i] = matriz[i, j]; // A transposição ocorre aqui
                }
            }

            return transposta; // Retorna a matriz transposta
        }

        // Método para somar as colunas da matriz
        public static void SomaColuna(int[,] matriz)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int soma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    soma += matriz[i, j];
                }
                System.Console.WriteLine($"Soma da coluna {j + 1}: {soma}");
            }
        }

        // Método para gerar a matriz (com tamanho definido pelo usuário)
        public static int[,] GerarMatriz()
        {
            System.Console.WriteLine("Informe o número de linhas: ");
            int linhas = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o número de colunas: ");
            int colunas = int.Parse(Console.ReadLine());

            return new int[linhas, colunas];
        }

        // Método para exibir a matriz no console
        public static void ExibirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.Write(matriz[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }

        // Método para salvar a matriz ou as somas no CSV
        public static void SalvarEmCSV(string nomeArquivo, int[,] matriz, bool somaLinha, bool transposta = false)
        {
            using (var writer = new StreamWriter(nomeArquivo))
            {
                if (transposta) // Caso seja a matriz transposta, apenas escreva os valores
                {
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            writer.Write(matriz[i, j] + " ");
                        }
                        writer.WriteLine();
                    }
                }
                else // Para somas de linhas ou colunas
                {
                    for (int i = 0; i < (somaLinha ? matriz.GetLength(0) : matriz.GetLength(1)); i++)
                    {
                        int soma = 0;
                        for (int j = 0; j < (somaLinha ? matriz.GetLength(1) : matriz.GetLength(0)); j++)
                            soma += somaLinha ? matriz[i, j] : matriz[j, i];

                        writer.WriteLine($"{(somaLinha ? "Linha" : "Coluna")} {i + 1}, {soma}");
                    }
                }
            }
            System.Console.WriteLine($"Resultado salvo em {nomeArquivo}");
        }
    }
}
