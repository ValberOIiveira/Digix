using System;

class Ex4 {
    static void Main() {
        int[,] matriz = new int[4, 4];

        // Leitura da matriz
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write($"Digite o número para posição [{i}][{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int somaDiagonal = 0;
        
        // Soma da diagonal principal
        for (int i = 0; i < 4; i++) {
            somaDiagonal += matriz[i, i];
        }

        Console.WriteLine("Soma da diagonal principal: " + somaDiagonal);
    }
}