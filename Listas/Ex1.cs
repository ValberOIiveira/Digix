using System;

class Ex1 {
    static void Main() {
        int[] vetor = new int[10];

        // Leitura do vetor
        for (int i = 0; i < 10; i++) {
            Console.Write("Digite um número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Exibindo em ordem direta
        Console.WriteLine("Ordem direta:");
        foreach (int num in vetor) {
            Console.Write(num + " ");
        }

        // Exibindo em ordem inversa
        Console.WriteLine("\nOrdem inversa:");
        for (int i = 9; i >= 0; i--) {
            Console.Write(vetor[i] + " ");
        }
    }
}