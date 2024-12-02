using System;

namespace DadosAbstratos
{
    public class ListaEncadeada
    {
        // Define um Nodo da lista encadeada
        public class Nodo
        {
            public int Valor;
            public Nodo? Proximo;

            public Nodo(int valor)
            {
                Valor = valor;
                Proximo = null;
            }
        }

        // Define a classe da lista encadeada
        public class ListaEncadeadaComDelegate
        {
            private Nodo? cabeca;

            // Delegate para ações sobre os elementos
            public delegate void FuncaoComDelegate(int valor);

            // Método para inserir um valor na lista
            public void Inserir(int valor, int posicao)
            {
                // Ajusta a posição para ser interpretada como n - 1
                int posicaoAjustada = posicao - 1;

                Nodo novoNodo = new Nodo(valor);

                // Caso a posição ajustada seja inválida
                if (posicaoAjustada < 0)
                {
                    Console.WriteLine("Erro: Posição inválida.");
                    return;
                }

                // Inserção no início da lista (posição 0)
                if (posicaoAjustada == 0)
                {
                    novoNodo.Proximo = cabeca;
                    cabeca = novoNodo;
                    return;
                }

                // Navegando até a posição ajustada
                Nodo atual = cabeca;
                int indice = 0;

                // Encontrar o nó anterior à posição ajustada
                while (atual != null && indice < posicaoAjustada - 1)
                {
                    atual = atual.Proximo;
                    indice++;
                }

                // Verifica se chegamos a uma posição válida
                if (atual == null)
                {
                    Console.WriteLine("Erro: Posição maior que o tamanho da lista.");
                    return;
                }

                // Inserindo o novo nó na posição ajustada
                novoNodo.Proximo = atual.Proximo;
                atual.Proximo = novoNodo;
            }

            // Método para remover um valor da lista
            public void Remover(int valor)
            {
                if (cabeca == null)
                    return;

                if (cabeca.Valor == valor)
                {
                    cabeca = cabeca.Proximo;
                    return;
                }

                Nodo atual = cabeca;
                while (atual.Proximo != null && atual.Proximo.Valor != valor)
                {
                    atual = atual.Proximo;
                }

                if (atual.Proximo != null)
                {
                    atual.Proximo = atual.Proximo.Proximo;
                }
            }

            // Método para listar todos os valores da lista
            public void Listar(FuncaoComDelegate funcao)
            {
                Nodo atual = cabeca;
                while (atual != null)
                {
                    funcao(atual.Valor); // Aplica a função ao valor de cada nó
                    atual = atual.Proximo;
                }
            }

            // Método para verificar se a lista está vazia
            public bool EstaVazia()
            {
                return cabeca == null;
            }

            public bool ExisteNalista(int valor)
            {
                Nodo atual = cabeca;
                while (atual!= null)
                {
                    if (atual.Valor == valor)
                        return true;
                    atual = atual.Proximo;
                }
                return false;
            }

            public int VerTopo()
            {
                if (cabeca == null)
                    return -1;
                return cabeca.Valor;
            }

            public void InserirOutraLista(ListaEncadeadaComDelegate outraLista)
            {
                if (outraLista.cabeca == null)
                {
                    Console.WriteLine("A outra lista está vazia.");
                    return;
                }

                Nodo atual = cabeca;

                // Caso a lista atual esteja vazia, basta copiar a outra lista
                if (atual == null)
                {
                    cabeca = outraLista.cabeca;
                    return;
                }

                // Navega até o final da lista atual
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }

                // Conecta o último nó da lista atual ao início da outra lista
                atual.Proximo = outraLista.cabeca;
            }

            
        }

        public static void Main()
        {
            // Criando duas listas encadeadas
            ListaEncadeadaComDelegate lista1 = new ListaEncadeadaComDelegate();
            ListaEncadeadaComDelegate lista2 = new ListaEncadeadaComDelegate();

            // Inserindo valores na primeira lista
            lista1.Inserir(10, 1);
            lista1.Inserir(20, 2);
            lista1.Inserir(30, 3);

            // Inserindo valores na segunda lista
            lista2.Inserir(40, 1);
            lista2.Inserir(50, 2);

            // Listando as listas antes da junção
            Console.WriteLine("Lista 1 antes de combinar:");
            lista1.Listar(valor => Console.WriteLine(valor));

            Console.WriteLine("\nLista 2:");
            lista2.Listar(valor => Console.WriteLine(valor));

            // Inserindo a segunda lista na primeira
            lista1.InserirOutraLista(lista2);

            // Listando a lista combinada
            Console.WriteLine("\nLista 1 após combinar com Lista 2:");
            lista1.Listar(valor => Console.WriteLine(valor));

        }
    }
}
