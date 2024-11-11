using System;

class Ex2 {
    static void Main() {
        int[] vetor = new int[10];

        // Leitura do vetor
        for (int i = 0; i < 10; i++) {
            Console.Write("Digite um número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int maior = vetor[0];
        int menor = vetor[0];

        // Encontrar maior e menor
        foreach (int num in vetor) {
            if (num > maior) maior = num;
            if (num < menor) menor = num;
        }

        Console.WriteLine("Maior elemento: " + maior);
        Console.WriteLine("Menor elemento: " + menor);
    }
}