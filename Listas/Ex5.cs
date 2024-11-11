using System;

class Ex5 {
    static void Main() {
        int[,] matriz1 = new int[4, 4];
        int[,] matriz2 = new int[4, 4];
        int[,] matrizSoma = new int[4, 4];

        // Leitura da primeira matriz
        Console.WriteLine("Digite os elementos da matriz 1:");
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write($"Posição [{i}][{j}]: ");
                matriz1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Leitura da segunda matriz
        Console.WriteLine("Digite os elementos da matriz 2:");
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write($"Posição [{i}][{j}]: ");
                matriz2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Soma das matrizes
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        // Exibindo a matriz resultante da soma
        Console.WriteLine("Matriz resultante da soma:");
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write(matrizSoma[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}