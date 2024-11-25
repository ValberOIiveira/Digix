// namespace DadosAbstratos
// {
//     public class Pilha
//     {
//         static int[] pilha = new int[10];  // Vetor para armazenar os elementos da pilha
//         static int topo = -1;               // Indica o topo da pilha, começa em -1 porque a pilha está vazia

//         // Método para adicionar um valor à pilha (Push)
//         static void Push(int valor)
//         {
//             if (topo == pilha.Length - 1)  // Verifica se a pilha está cheia
//             {
//                 Console.WriteLine("Pilha cheia. Não é possível adicionar mais elementos.");
//                 return;
//             }

//             // Aumenta o topo e insere o valor no topo da pilha
//             topo++;
//             pilha[topo] = valor;
//             Console.WriteLine($"Valor {valor} inserido na pilha.");
//         }

//         // Método para remover o valor do topo da pilha (Pop)
//         static int Pop()
//         {
//             if (topo == -1)  // Verifica se a pilha está vazia
//             {
//                 Console.WriteLine("Pilha vazia. Não há elementos para remover.");
//                 return -1; // Retorna um valor indicativo de erro     
//             }

//             // Retira o valor do topo da pilha e decrementa o topo
//             int valorRemovido = pilha[topo];
//             topo--;
//             Console.WriteLine($"Valor {valorRemovido} removido da pilha.");
//             return valorRemovido;
//         }

//         // Método para visualizar o valor do topo da pilha (Peek)
//         static int Peek()
//         {
//             if (topo == -1)  // Verifica se a pilha está vazia
//             {
//                 Console.WriteLine("Pilha vazia.");
//                 return -1; // Retorna um valor indicativo de erro
//             }

//             // Retorna o valor do topo sem removê-lo
//             return pilha[topo];
//         }

//         // Método para verificar se a pilha está vazia
//         static bool IsEmpty()
//         {
//             return topo == -1;  // Retorna true se a pilha estiver vazia
//         }

//         // Método para listar todos os elementos da pilha
//         static void ListarPilha()
//         {
//             if (topo == -1)  // Verifica se a pilha está vazia
//             {
//                 Console.WriteLine("Pilha vazia.");
//                 return;
//             }

//             Console.WriteLine("Elementos da pilha (do topo para a base):");
//             for (int i = topo; i >= 0; i--)
//             {
//                 Console.WriteLine(pilha[i]);
//             }
//         }

//         // Método principal
//         public static void Main()
//         {
//             // Demonstração de operações na pilha

//             // Adicionando elementos à pilha
//             Push(10);
//             Push(20);
//             Push(30);
//             Push(40);
//             Push(50);

//             Console.WriteLine("\nPilha após inserção dos elementos:");
//             ListarPilha();

//             // Verificando o topo da pilha
//             Console.WriteLine($"\nTopo da pilha: {Peek()}");

//             // Removendo elementos da pilha
//             Console.WriteLine($"\nRemovendo valor: {Pop()}");
//             Console.WriteLine($"\nRemovendo valor: {Pop()}");

//             Console.WriteLine("\nPilha após remoções:");
//             ListarPilha();

//             // Verificando se a pilha está vazia
//             Console.WriteLine($"\nA pilha está vazia? {IsEmpty()}");

//             // Continuando as operações
//             Push(60);
//             Push(70);

//             Console.WriteLine("\nPilha após novas inserções:");
//             ListarPilha();
//         }
//     }
// }
