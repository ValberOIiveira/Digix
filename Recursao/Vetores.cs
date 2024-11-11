namespace recursao{
    public class Vetores {

        //Funcao recursiva de achar pares num vetor de inteiros
        public static int[] Pares(int[] vet, int i = 0, int count = 0) {

            // Caso base: Se o indice i for igual ao tamanho do vetor, retorna um vetor com count pares
            if (i == vet.Length)
                return new int[count];

            // Verifica se o numero na posicao i do vetor e par
            if (vet[i] % 2 == 0) {
                // Se for par, adiciona-o ao novo vetor e incrementa o count
                return Pares(vet, i + 1, count + 1).Append(vet[i]).ToArray();
            }
            // Se nao for par, continua a procurar no proximo numero
            return Pares(vet, i + 1, count);
        }
        public static void Main() {
            int[] vet = { 1, 2, 3, 4, 5};
            int[] pares = Pares(vet);
            System.Console.WriteLine("Pares do vetor:");
            foreach (var num in pares)
                System.Console.Write($"{num} "); // Saída: 2 4
            
            
            
        }
    }
}