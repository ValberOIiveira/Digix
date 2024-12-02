// using System;

// public class No
// {
//     public int Valor;  
//     public No Proximo; 
//     public No Anterior; 

//     public No(int valor)
//     {
//         Valor = valor;
//         Proximo = null;
//         Anterior = null;
//     }
// }

// public class ListaDuplamenteEncadeada
// {
//     private No cabeca; 

//     public ListaDuplamenteEncadeada()
//     {
//         cabeca = null;
//     }

//     // Adicionar um nó no final da lista
//     public void AdicionarNoFinal(int valor)
//     {
//         No novoNo = new No(valor);
//         if (cabeca == null)  // Se a lista estiver vazia
//         {
//             cabeca = novoNo;
//             return;
//         }

//         No temp = cabeca;
//         while (temp.Proximo != null)  // Vai até o final da lista
//         {
//             temp = temp.Proximo;
//         }

//         temp.Proximo = novoNo;  
//         novoNo.Anterior = temp;  
//     }

//     // Exibir a lista do início para o final
//     public void ExibirDoInicioParaOFim()
//     {
//         No temp = cabeca;
//         while (temp != null)
//         {
//             Console.Write(temp.Valor + " ");
//             temp = temp.Proximo;
//         }
//         Console.WriteLine();
//     }

//     // Exibir a lista do final para o início
//     public void ExibirDoFimParaOInicio()
//     {
//         if (cabeca == null) return;

//         No temp = cabeca;
//         while (temp.Proximo != null)  
//         {
//             temp = temp.Proximo;
//         }

//         while (temp != null)   
//         {
//             Console.Write(temp.Valor + " ");
//             temp = temp.Anterior;
//         }
//         Console.WriteLine();
//     }

//     // Remover um nó com um valor específico
//     public void Remover(int valor)
//     {
//         if (cabeca == null) return;

//         No temp = cabeca;
//         while (temp != null && temp.Valor != valor)
//         {
//             temp = temp.Proximo;
//         }

//         if (temp == null) return;  // Nó não encontrado

//         if (temp.Anterior != null)
//             temp.Anterior.Proximo = temp.Proximo;

//         if (temp.Proximo != null)
// #pragma warning disable CS8601 // Possível atribuição de referência nula.
//             temp.Proximo.Anterior = temp.Anterior;
// #pragma warning restore CS8601 // Possível atribuição de referência nula.

//         if (temp == cabeca)  // Se o nó a ser removido for a cabeça
//             cabeca = temp.Proximo;

//         temp = null;  // Libera o nó
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         ListaDuplamenteEncadeada lista = new ListaDuplamenteEncadeada();

//         // Adicionando alguns elementos na lista
//         lista.AdicionarNoFinal(10);
//         lista.AdicionarNoFinal(20);
//         lista.AdicionarNoFinal(30);
//         lista.AdicionarNoFinal(40);

//         // Exibindo a lista do início para o final
//         Console.WriteLine("Lista (do início para o final):");
//         lista.ExibirDoInicioParaOFim();

//         // Exibindo a lista do final para o início
//         Console.WriteLine("Lista (do final para o início):");
//         lista.ExibirDoFimParaOInicio();

//         // Remover um nó
//         lista.Remover(20);

//         // Exibindo novamente a lista
//         Console.WriteLine("Lista após remover o 20:");
//         lista.ExibirDoInicioParaOFim();
//     }
// }
