using System;
using System.Collections.Generic;

namespace AulaDeOO
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        // Função para adicionar produto à lista
        public static void AdicionarProduto(List<Produto> produtos, Produto produto)
        {
            produtos.Add(produto);
        }

        // Função para mostrar os produtos
        public static void MostrarProdutos(List<Produto> produtos)
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }

        // Sobrescrita do ToString() para exibir informações do produto
        public override string ToString()
        {
            return $"Nome: {Nome}, Preço: {Preco:C2}";
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Lista de produtos
            List<Produto> produtos = new List<Produto>();

            // Criando produtos
            Produto p1 = new Produto("Cachorro Quente", 15.00);
            Produto p2 = new Produto("Refrigerante", 5.00);
            Produto p3 = new Produto("Pastel", 7.50);

            // Adicionando produtos à lista
            Produto.AdicionarProduto(produtos, p1);
            Produto.AdicionarProduto(produtos, p2);
            Produto.AdicionarProduto(produtos, p3);

            // Exibindo os produtos
            Produto.MostrarProdutos(produtos);
        }
    }
}
