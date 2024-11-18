//using System;

//namespace Ordenacao
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // // criar um vetor[15] desordenado
//            // int[] vetor = new int[15];
//            // Random random = new Random();   
//            // for (int i = 0; i < vetor.Length; i++)
//            // {
//            //     vetor[i] = random.Next(1, 100);
//            // }

//            int[] vetor = new int[] { 55, 35, 12, 25, 1, 87, 7, 27, 24, 70, 83, 90, 100, 8, 79, 72, 98, 47, 16, 64, 75, 52, 99, 3, 77, 92, 11, 36, 61, 53, 86, 39, 44, 62, 50, 63, 58, 9, 78, 76, 95, 32, 34, 29, 82, 89, 85, 41, 6, 22 };

//            // exibir o vetor original
//            Console.WriteLine("Vetor original:");
//            ExibirVetor(vetor);

//            // escolher o algoritmo de ordenação
//            Console.WriteLine("\nEscolha o algoritmo de ordenação:");
//            Console.WriteLine("1. Bubble Sort");
//            Console.WriteLine("2. Selection Sort");
//            Console.WriteLine("3. Insertion Sort");
//            Console.WriteLine("4. Quick Sort");
//            Console.WriteLine("5. Merge Sort");
//            int escolha = int.Parse(Console.ReadLine());

//            // ordenar com base na escolha do usuário
//            switch (escolha)
//            {
//                case 1:
//                    BubbleSort(vetor);
//                    break;
//                case 2:
//                    SelectionSort(vetor);
//                    break;
//                case 3:
//                    InsertionSort(vetor);
//                    break;
//                case 4:
//                    QuickSort(vetor, 0, vetor.Length - 1);
//                    break;
//                case 5:
//                    MergeSort(vetor, 0, vetor.Length - 1);
//                    break;
//                default:
//                    Console.WriteLine("Opção inválida.");
//                    return;
//            }

//            // exibir o vetor ordenado
//            Console.WriteLine("\nVetor ordenado:");
//            ExibirVetor(vetor);
//        }

//        // função para imprimir o vetor
//        static void ExibirVetor(int[] vetor)
//        {
//            foreach (int item in vetor)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();
//        }

//        // função para ordenar o vetor usando o algoritmo Bubble Sort
//        static void BubbleSort(int[] vetor)
//        {
//            int n = vetor.Length;
//            for (int i = 0; i < n - 1; i++)
//            {
//                for (int j = 0; j < n - i - 1; j++)
//                {
//                    if (vetor[j] > vetor[j + 1])
//                    {
//                        int aux = vetor[j];
//                        vetor[j] = vetor[j + 1];
//                        vetor[j + 1] = aux;
//                    }
//                }
//            }
//        }

//        // função para ordenar o vetor usando o algoritmo Selection Sort
//        static void SelectionSort(int[] vetor)
//        {
//            int n = vetor.Length;
//            for (int i = 0; i < n - 1; i++)
//            {
//                int min = i;
//                for (int j = i + 1; j < n; j++)
//                {
//                    if (vetor[j] < vetor[min])
//                    {
//                        min = j;
//                    }
//                }
//                int aux = vetor[i];
//                vetor[i] = vetor[min];
//                vetor[min] = aux;
//            }
//        }

//        // função para ordenar o vetor usando o algoritmo Insertion Sort
//        static void InsertionSort(int[] vetor)
//        {
//            int n = vetor.Length;
//            for (int i = 1; i < n; i++)
//            {
//                int key = vetor[i];
//                int j = i - 1;
//                while (j >= 0 && vetor[j] > key)
//                {
//                    vetor[j + 1] = vetor[j];
//                    j = j - 1;
//                }
//                vetor[j + 1] = key;
//            }
//        }

//        // função para ordenar o vetor usando o algoritmo Quick Sort
//        static void QuickSort(int[] vetor, int inicio, int fim)
//        {
//            if (inicio < fim)
//            {
//                int pivo = Dividir(vetor, inicio, fim);
//                QuickSort(vetor, inicio, pivo - 1); // ordenar a parte esquerda
//                QuickSort(vetor, pivo + 1, fim);   // ordenar a parte direita
//            }
//        }

//        // função de particionamento para o Quick Sort
//        static int Dividir(int[] vetor, int inicio, int fim)
//        {
//            int pivo = vetor[fim];
//            int i = inicio - 1;

//            for (int j = inicio; j < fim; j++)
//            {
//                if (vetor[j] >= pivo)
//                {
//                    i++;
//                    int temp = vetor[i];
//                    vetor[i] = vetor[j];
//                    vetor[j] = temp;
//                }
//            }

//            int temp1 = vetor[i + 1];
//            vetor[i + 1] = vetor[fim];
//            vetor[fim] = temp1;

//            return i + 1; // retorna o índice do pivo
//        }

//        // função para ordenar o vetor usando o algoritmo Merge Sort
//        static void MergeSort(int[] vetor, int inicio, int fim)
//        {
//            if (inicio < fim)
//            {
//                int meio = (inicio + fim) / 2;

//                // dividir o vetor em duas metades e ordenar
//                MergeSort(vetor, inicio, meio);
//                MergeSort(vetor, meio + 1, fim);

//                // combinar as duas metades
//                int n1 = meio - inicio + 1;
//                int n2 = fim - meio;

//                // vetores temporários para armazenar as duas metades
//                int[] esquerda = new int[n1];
//                int[] direita = new int[n2];

//                // copiar os dados para os vetores temporários
//                Array.Copy(vetor, inicio, esquerda, 0, n1);
//                Array.Copy(vetor, meio + 1, direita, 0, n2);

//                // combinar as duas metades
//                int i = 0, j = 0, k = inicio;
//                while (i < n1 && j < n2)
//                {
//                    if (esquerda[i] <= direita[j])
//                    {
//                        vetor[k] = esquerda[i];
//                        i++;
//                    }
//                    else
//                    {
//                        vetor[k] = direita[j];
//                        j++;
//                    }
//                    k++;
//                }

//                // copiar os elementos restantes da esquerda (se houver)
//                while (i < n1)
//                {
//                    vetor[k] = esquerda[i];
//                    i++;
//                    k++;
//                }

//                // copiar os elementos restantes da direita (se houver)
//                while (j < n2)
//                {
//                    vetor[k] = direita[j];
//                    j++;
//                    k++;
//                }
//            }
//        }
//    }
//}
