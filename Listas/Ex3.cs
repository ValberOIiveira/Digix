using System;

class Program {
    static void Main() {
        int[,] matriz = new int[4, 4];

        // Leitura da matriz
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write($"Digite o número para posição [{i}][{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int maior = matriz[0, 0];
        int menor = matriz[0, 0];

        // Encontrar maior e menor
        foreach (int num in matriz) {
            if (num > maior) maior = num;
            if (num < menor) menor = num;
        }

        int soma = maior + menor;
        Console.WriteLine("Soma do maior e menor elemento: " + soma);
    }
}