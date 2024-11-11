using System;
using modificadores;

namespace programacaoOO {
    public class Program {
        public static int Soma(int x, int y) {
            return x + y;
        }

        public static string ImprimeNome(string nome)
        {
            return $"Olá, {nome}!";
        }

        public static string ImprimeSaldo(double saldoTotal, double saldoRetirado)
        {
            double saldoAtual = saldoTotal - saldoRetirado;
            string mensagem = "Seu saldo atual é de " + saldoAtual;
            return mensagem;
        }

        public static int SomaVetor(int[] vetor) {
            int soma = 0;
            foreach (int num in vetor) {
                soma += num;
            }
            return soma;

        }

        public static int MedeVetor(int[] vetor) {
            return vetor.Length;
        }
 
        public static int SomaMatriz(int[,] matriz) {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    soma += matriz[i, j];
                }
            }
            return soma;
        }

        public static void Main(string[] args) {
            //Testando SomaMatriz
            // int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // Console.WriteLine($"Soma dos elementos da matriz: {SomaMatriz(matriz)}");

            Modificadores m = new Modificadores();
            Console.WriteLine(m.num);

        }
    }
}