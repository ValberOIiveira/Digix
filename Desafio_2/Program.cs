using System;
using System.Globalization;

namespace Desafio_2
{
    public class Program
    {
        // Função de ordenação por notas (Insertion Sort)
        static void InsertionSort(object[,] alunos)
        {
            int n = alunos.GetLength(0); // número de alunos (linhas da matriz)

            // Insertion Sort para ordenação decrescente por notas
            for (int i = 1; i < n; i++)
            {
                // A chave é o elemento atual (aluno)
                object[] chave = new object[alunos.GetLength(1)];
                for (int j = 0; j < alunos.GetLength(1); j++)
                    chave[j] = alunos[i, j]; // Armazenando o aluno atual

                // Move os elementos da parte ordenada para a direita
                int jPos = i - 1;
                // Enquanto houver um aluno anterior com nota menor, move os alunos
                while (jPos >= 0 && Convert.ToDouble(alunos[jPos, 3]) < Convert.ToDouble(chave[3]))
                {
                    // Move o aluno para a posição à frente
                    for (int k = 0; k < alunos.GetLength(1); k++)
                        alunos[jPos + 1, k] = alunos[jPos, k];

                    jPos--; // Move para o próximo aluno anterior
                }

                // Coloca a chave (aluno) na posição correta
                for (int k = 0; k < alunos.GetLength(1); k++)
                    alunos[jPos + 1, k] = chave[k];
            }
        }

        // Função de ordenação por nome (Insertion Sort)
        static void InsertionSortString(object[,] alunos)
        {
            int n = alunos.GetLength(0); // número de alunos (linhas da matriz)

            // Insertion Sort para ordenação por nome (ordem alfabética)
            for (int i = 1; i < n; i++)
            {
                // A chave é o elemento atual (aluno)
                object[] chave = new object[alunos.GetLength(1)];
                for (int j = 0; j < alunos.GetLength(1); j++)
                    chave[j] = alunos[i, j]; // Armazenando o aluno atual

                // Move os elementos da parte ordenada para a direita
                int jPos = i - 1;
                // Enquanto o nome for maior (ordem alfabética) ou a nota for a mesma
                while (
                    jPos >= 0
                    && Convert.ToDouble(alunos[jPos, 3]) == Convert.ToDouble(chave[3]) // Se as notas forem iguais
                    && string.Compare(
                        alunos[jPos, 0].ToString(), // Compara os nomes dos alunos
                        chave[0].ToString(),
                        StringComparison.Ordinal // Compara considerando a ordem alfabética
                    ) > 0
                )
                {
                    // Move o aluno para a posição à frente
                    for (int k = 0; k < alunos.GetLength(1); k++)
                        alunos[jPos + 1, k] = alunos[jPos, k];

                    jPos--; // Move para o próximo aluno anterior
                }

                // Coloca a chave (aluno) na posição correta
                for (int k = 0; k < alunos.GetLength(1); k++)
                    alunos[jPos + 1, k] = chave[k];
            }
        }

        // Função para exibir os melhores alunos
        static void Melhores(object[,] alunos)
        {
            System.Console.WriteLine("TOP 5 MELHORES de 2024: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(
                    $"{i + 1} - Nome: {alunos[i, 0]}, Idade: {alunos[i, 1]}, Matrícula: {alunos[i, 2]}, Nota Final: {alunos[i, 3]}, Faltas: {alunos[i, 4]}"
                );
            }
        }

        // Função para imprimir a matriz de alunos
        static void ImprimirMatriz(object[,] matriz)
        {
            // Percorre a matriz e imprime as informações dos alunos
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine(
                    $"Nome: {matriz[i, 0]}; Idade: {matriz[i, 1]}; Matricula: {matriz[i, 2]}; Nota Final: {matriz[i, 3]:F1}; Faltas: {matriz[i, 4]}"
                );
            }
        }

        // Função para calcular a média de idade e de notas
        static void Media(object[,] mat)
        {
            double somaIdade = 0;
            double somaNota = 0;

            double mediaIdade;
            double mediaNota;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                somaIdade += Convert.ToDouble(mat[i, 1]);
                somaNota += Convert.ToDouble(mat[i, 3]);
            }

            mediaIdade = somaIdade / mat.GetLength(0);
            mediaNota = somaNota / mat.GetLength(0);

            System.Console.WriteLine($"Média de Idade: {mediaIdade:F2}");
            System.Console.WriteLine($"Média de Nota: {mediaNota:F2}");
        }

        static void AlunoComMaisFaltas(object[,] matriz)
        {
            double maiorFalta = Convert.ToDouble(matriz[0, 4]);
            int linha = 0;

            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                if ((Convert.ToDouble(matriz[i, 4])) > maiorFalta)
                {
                    maiorFalta = Convert.ToDouble(matriz[i, 4]);
                    linha = i;
                }
            }
            System.Console.WriteLine(
                $"Aluno com mais falta:\n Nome: {matriz[linha, 0]}, idade: {matriz[linha, 1]}, matricula {matriz[linha, 2]}, nota: {matriz[linha, 3]}, falta: {matriz[linha, 4]},"
            );
        }

        public static void Main()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            // Inicializando uma matriz 30x5 de alunos (nome, idade, matrícula, nota, faltas)
            var alunos = new dynamic[30, 5]
            {
                { "João", 20, 202301, 55.4, 2 },
                { "Maria", 22, 202302, 18.7, 1 },
                { "Carlos", 21, 202303, 72.9, 5 },
                { "Lucas", 23, 202304, 55.5, 0 },
                { "Ana", 20, 202305, 62.1, 4 },
                { "Beatriz", 22, 202306, 80.2, 2 },
                { "Ricardo", 21, 202307, 27.4, 1 },
                { "Patrícia", 23, 202308, 91.5, 0 },
                { "Fernanda", 20, 202309, 47.8, 3 },
                { "Tiago", 22, 202310, 62.7, 2 },
                { "Renata", 21, 202311, 68.4, 0 },
                { "Mariana", 23, 202312, 79.6, 1 },
                { "Rafael", 20, 202313, 34.2, 2 },
                { "Eduarda", 22, 202314, 59.3, 0 },
                { "Ricardo", 21, 202315, 84.5, 1 },
                { "Felipe", 23, 202316, 11.6, 3 },
                { "Larissa", 20, 202317, 54.3, 2 },
                { "Isabela", 22, 202318, 80.2, 0 },
                { "Gabriel", 21, 202319, 96.7, 4 },
                { "Sofia", 23, 202320, 50.1, 2 },
                { "Vinícius", 20, 202321, 67.5, 1 },
                { "Amanda", 22, 202322, 78.8, 3 },
                { "Eduardo", 21, 202323, 53.7, 0 },
                { "Camila", 23, 202324, 69.2, 2 },
                { "José", 20, 202325, 85.6, 1 },
                { "Carla", 22, 202326, 62.1, 0 },
                { "Lucas", 21, 202327, 90.1, 3 },
                { "Tatiane", 23, 202328, 56.9, 4 },
                { "Gustavo", 20, 202329, 31.8, 2 },
                { "Juliana", 22, 202330, 63.2, 1 },
            };

            // Ordenação por nota (decrescente)
            InsertionSort(alunos); // Primeiro ordena por nota

            // Ordenação por nome (alfabética) considerando notas iguais
            InsertionSortString(alunos); // Depois ordena por nome, mantendo a ordem de notas iguais

            // Exibir os melhores alunos
            Melhores(alunos); // Exibe os top 5 alunos

            // Imprimir a matriz ordenada
            ImprimirMatriz(alunos); // Exibe a lista ordenada de alunos

            // Calcular e exibir as médias
            Media(alunos); // Exibe as médias de idade e notas

            AlunoComMaisFaltas(alunos); //
        }
    }
}
