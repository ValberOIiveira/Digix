using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CursoC_Digix
{
    internal class ListaOrdenacao
    {

        static int BubbleSort(int[] vetor)
        {
            int n = vetor.Length;
            int modificacoes = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;


                        modificacoes++;
                    }
                }
            }

            return modificacoes;
        }

        static void InsertionSort(int[] vetor)
        {
            int n = vetor.Length;
            for (int i = 1; i < n; i++)
            {
                int key = vetor[i];
                int j = i - 1;
                while (j >= 0 && vetor[j] < key)
                {
                    vetor[j + 1] = vetor[j];
                    j = j - 1;
                }
                vetor[j + 1] = key;
            }
        }


        static void SelectionSort(int[] vetor)
        {
            int n = vetor.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vetor[j] < vetor[min])
                    {
                        min = j;
                    }
                }
                int aux = vetor[i];
                vetor[i] = vetor[min];
                vetor[min] = aux;
            }
        }

        static void SelectionSortStrings(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(arr[j], arr[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                string temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }





        static void Main(string[] args)
        {

            //Exercicio 1:

            //string input = Console.ReadLine();

            //int[] vetor = Array.ConvertAll(input.Split(), int.Parse);

            //BubbleSort(vetor);


            //Console.WriteLine("[" + string.Join(", ", vetor) + "]");


            //Exercicio 2:

            //string input = Console.ReadLine();

            //int[] vetor = Array.ConvertAll(input.Split(), int.Parse);

            //int modificacoes = BubbleSort(vetor);


            //Console.WriteLine("[" + string.Join(", ", vetor) + "]" + ", Iterações: " + modificacoes);

            //Exercicio 3:

            //string[] vetor = { "Carlos", "Ana", "Beatriz", "Daniel" };

            //SelectionSortStrings(vetor);

            //foreach (var item in vetor)
            //{
            //    Console.WriteLine(item);
            //}





            //Exercicio 4:


            //int[] vetor = { 12, 11, 13, 5, 6 };

            //InsertionSort(vetor);

            //Console.WriteLine("[" + string.Join(",", vetor) + "]");


            //Exercicio 5:

            //Random rand = new Random();
            //int[] array = new int[1000];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rand.Next(0, 101);
            //}


            //int[] bubbleArray = (int[])array.Clone(); // Clona o array para não sobrescrever
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //BubbleSort(bubbleArray);
            //stopwatch.Stop();
            //Console.WriteLine("BubbleSort elapsed time: {0} ms", stopwatch.ElapsedMilliseconds);

            //// Medir o tempo de execução do InsertionSort
            //int[] insertionArray = (int[])array.Clone(); // Clona o array para não sobrescrever
            //stopwatch.Restart();
            //InsertionSort(insertionArray);
            //stopwatch.Stop();
            //Console.WriteLine("InsertionSort elapsed time: {0} ms", stopwatch.ElapsedMilliseconds);

            //// Medir o tempo de execução do SelectionSort
            //int[] selectionArray = (int[])array.Clone(); // Clona o array para não sobrescrever
            //stopwatch.Restart();
            //SelectionSort(selectionArray);
            //stopwatch.Stop();
            //Console.WriteLine("SelectionSort elapsed time: {0} ms", stopwatch.ElapsedMilliseconds);




             










        }
    }
}
