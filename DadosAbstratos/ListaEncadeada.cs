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
            private Nodo ?cabeca;

            // Delegate para ações sobre os elementos
            public delegate void FuncaoComDelegate(int valor);

            // Método para inserir um valor na lista
             public void Inserir(int valor)
            {
                Nodo novoNodo = new Nodo(valor);
                if (cabeca == null)
                {
                    cabeca = novoNodo;
                }
                else
                {
                    Nodo atual = cabeca;
                    while (atual.Proximo != null)
                    {
                        atual = atual.Proximo;
                    }
                    atual.Proximo = novoNodo;
                }
            }

            // Método para remover um valor da lista
            public void Remover(int valor)
            {
                if (cabeca == null) return;

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
                    funcao(atual.Valor);  // Aplica a função ao valor de cada nó
                    atual = atual.Proximo;
                }
            }

            // Método para verificar se a lista está vazia
            public bool EstaVazia()
            {
                return cabeca == null;
            }
        }

        public static void Main()
        {
            // Criando uma lista encadeada
            ListaEncadeadaComDelegate lista = new ListaEncadeadaComDelegate();

            // Inserindo valores na lista
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Inserir(40);

            // Listando os elementos da lista
            Console.WriteLine("Listando todos os valores:");
            lista.Listar(valor => Console.WriteLine(valor));

            // Removendo um valor da lista
            lista.Remover(20);

            // Listando novamente os elementos
            Console.WriteLine("\nApós remoção do valor 20:");
            lista.Listar(valor => Console.WriteLine(valor));

            // Verificando se a lista está vazia
            Console.WriteLine("\nA lista está vazia? " + (lista.EstaVazia() ? "Sim" : "Não"));
        }
    }
}
