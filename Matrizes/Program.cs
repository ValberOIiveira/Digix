namespace main
{
    public class Lista
    {
        public static void Main()
        {
            //Escreva um programa que peça ao usuário para inserir 10 números em um vetor e calcule a média desses valores.
            // int[] numeros = new int[10];
            // double media;

            // Console.WriteLine("Digite 10 números:");
            // for (int i = 0; i < 10; i++) {
            //     numeros[i] = Convert.ToInt32(Console.ReadLine());
            // }

            // media = numeros.Average();

            // Console.WriteLine($"A média dos valores inseridos é: {media}");
 

            //Dada uma matriz 4x4 preenchida com valores, some os elementos de cada linha e exiba o resultado
            // int[,] matriz = {
            //     {1, 2, 3, 4},
            //     {5, 6, 7, 8},
            //     {9, 10, 11, 12},
            //     {13, 14, 15, 16}
            // };

            // int[] somaLinhas = new int[4];

            // for (int i = 0; i < 4; i++) {
            //     somaLinhas[i] = 0;
            //     for (int j = 0; j < 4; j++) {
            //         somaLinhas[i] += matriz[i, j];
            //     }
            // }

            // Console.WriteLine("Soma dos elementos de cada linha:");
            // for (int i = 0; i < 4; i++) {
            //     Console.WriteLine($"Linha {i+1}: {somaLinhas[i]}");
            // }

            // Dado um vetor de inteiros, verifique se ele é um palíndromo (ou seja, se é igual quando lido de trás para frente).
            // int[] vetor = {1, 2, 3, 2, 1};

            // bool ehPalindromo = true;
 
            // for (int i = 0; i < vetor.Length / 2; i++) {
            //     if (vetor[i]!= vetor[vetor.Length - 1 - i]) {
            //         ehPalindromo = false;
            //         break;
            //     }
            // }

            // Console.WriteLine($"O vetor {string.Join(", ", vetor)} é um palíndromo? {ehPalindromo}");


            //Dada uma matriz quadrada n x n, exiba a soma dos elementos da diagonal principal e da diagonal secundária.
            // int[,] matriz = {
            //     {1, 2, 3},
            //     {4, 5, 6},
            //     {7, 8, 9}
            // };

            // int somaDiagonalPrincipal = 0;
            // int somaDiagonalSecundaria = 0;

            // for (int i = 0; i < matriz.GetLength(0); i++) {
            //     somaDiagonalPrincipal += matriz[i, i];
            //     somaDiagonalSecundaria += matriz[i, matriz.GetLength(0) - 1 - i];
            // }

            // Console.WriteLine($"Soma dos elementos da diagonal principal: {somaDiagonalPrincipal}");
            // Console.WriteLine($"Soma dos elementos da diagonal secundária: {somaDiagonalSecundaria}");


            //Crie um programa para rotacionar uma matriz n x n 90 graus no sentido horário.
            // int[,] matriz = {
            //     {1, 2, 3},
            //     {4, 5, 6},
            //     {7, 8, 9}
            // };

            // for (int i = 0; i < matriz.GetLength(0) / 2; i++) {
            //     for (int j = i; j < matriz.GetLength(1) - i - 1; j++) {
            //         int temp = matriz[i, j];
            //         matriz[i, j] = matriz[matriz.GetLength(0) - 1 - j, i];
            //         matriz[matriz.GetLength(0) - 1 - j, i] = matriz[matriz.GetLength(0) - 1 - i, matriz.GetLength(1) - 1 - j];
            //         matriz[matriz.GetLength(0) - 1 - i, matriz.GetLength(1) - 1 - j] = matriz[j, matriz.GetLength(1) - 1 - i];
            //         matriz[j, matriz.GetLength(1) - 1 - i] = temp;
            //     }
            // }

            // Console.WriteLine("Matriz rotacionada 90 graus no sentido horário:");
            // for (int i = 0; i < matriz.GetLength(0); i++) {
            //     for (int j = 0; j < matriz.GetLength(1); j++) {
            //         Console.Write($"{matriz[i, j]} ");
            //     }
            //     Console.WriteLine();
            // }
        }
    }
}
