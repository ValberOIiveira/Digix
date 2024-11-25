// namespace DadosAbstratos
// {
//     public class Fila
//     {
//         static int[] fila = new int[10]; // Vetor que representa a fila (capacidade de 10)
//         static int inicio = 0; // Indice do início da fila
//         static int fim = 0; // Indice do fim da fila
//         static int tamanho = 0; // Número de elementos na fila

//         // Método para adicionar um valor à fila
//         static void Enqueue(int valor)
//         {
//             if (tamanho == fila.Length) // Verifica se a fila está cheia
//             {
//                 Console.WriteLine("Fila cheia. Não é possível adicionar mais elementos.");
//                 return;
//             }

//             // Insere o valor no final da fila (na posição 'fim')
//             fila[fim] = valor;

//             // Atualiza o índice 'fim' de maneira circular
//             fim = (fim + 1) % fila.Length;

//             // Incrementa o tamanho da fila
//             tamanho++;
//         }

//         // Método para remover um valor da fila
//         static int Dequeue()
//         {
//             if (tamanho == 0) // Verifica se a fila está vazia
//             {
//                 Console.WriteLine("Fila vazia. Não há elementos para remover.");
//                 return -1; // Retorna um valor indicativo de erro (como -1)
//             }

//             // O valor a ser removido está na posição 'inicio'
//             int valorRemovido = fila[inicio];

//             // Atualiza o índice 'inicio' de maneira circular
//             inicio = (inicio + 1) % fila.Length;

//             // Decrementa o tamanho da fila
//             tamanho--;

//             return valorRemovido;
//         }

//         // Método para listar os elementos da fila
//         static void ListarFila()
//         {
//             if (tamanho == 0)
//             {
//                 Console.WriteLine("Fila vazia.");
//                 return;
//             }

//             Console.WriteLine("Elementos da fila:");
//             for (int i = 0; i < tamanho; i++)
//             {
//                 // A posição real de cada elemento é calculada de maneira circular
//                 int posicaoReal = (inicio + i) % fila.Length;
//                 Console.WriteLine(fila[posicaoReal]);
//             }
//         }

//         // Método de entrada principal
//         public static void Main()
//         {
//             // Inserindo elementos na fila
//             Enqueue(1);
//             Enqueue(2);
//             Enqueue(3);
//             Enqueue(4);
//             Enqueue(5);

//             Console.WriteLine("Após inserção de elementos:");
//             ListarFila();

//             // Removendo um elemento
//             Console.WriteLine("\nRemovendo um elemento: " + Dequeue());

//             Console.WriteLine("\nApós remoção de um elemento:");
//             ListarFila();

//             // Inserindo mais elementos
//             Enqueue(6);
//             Enqueue(7);

//             Console.WriteLine("\nApós inserção de mais elementos:");
//             ListarFila();
//         }
//     }
// }
