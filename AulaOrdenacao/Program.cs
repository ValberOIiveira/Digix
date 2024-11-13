namespace metodosOrdenacao
{




    public class Program
    {
        public static void Main()
        {

            static void BubbleSort(int[] vetor)
            {
                int n = vetor.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (vetor[j] > vetor[j + 1])
                        {
                            // Troca os valores
                            int temp = vetor[j];
                            vetor[j] = vetor[j + 1];
                            vetor[j + 1] = temp;
                        }
                    }
                }

                // Imprimindo o vetor ordenado
                foreach (var num in vetor)
                {
                    Console.Write(num + " ");
                }
            }

            static void InsertionSort(int[] vetor)
            {
                int n = vetor.Length;

                for (int i = 1; i < n; i++)
                {
                    int key = vetor[i];
                    int j = i - 1;

                    // Mover os elementos do vetor[0..i-1] que são maiores que o key para uma posição à frente
                    while (j >= 0 && vetor[j] > key)
                    {
                        vetor[j + 1] = vetor[j];
                        j--;
                    }

                    // Colocando o key na posição correta
                    vetor[j + 1] = key;
                }

                // Imprimindo o vetor ordenado
                foreach (var num in vetor)
                {
                    Console.Write(num + " ");
                }
            }


        }

        static void SelectionSort(int[] vetor)
        {
            int n = vetor.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                // Encontrar o menor elemento no restante do vetor
                for (int j = i + 1; j < n; j++)
                {
                    if (vetor[j] < vetor[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Troca o menor valor com o valor atual
                if (minIndex != i)
                {
                    int temp = vetor[i];
                    vetor[i] = vetor[minIndex];
                    vetor[minIndex] = temp;
                }
            }

            // Imprimindo o vetor ordenado
            foreach (var num in vetor)
            {
                Console.Write(num + " ");
            }
        }
    }




}