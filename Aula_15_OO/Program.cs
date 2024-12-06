namespace Aula_15_OO
{
    public class Program
    {
        public static void ExibirInformacoes(dynamic produto)
        {
            Console.WriteLine(produto.GetType().Name + ":");
            Console.WriteLine("Nome: " + produto.Nome);
            Console.WriteLine("Preço: R$ " + produto.Preco);
            Console.WriteLine("Quantidade: " + produto.Quantidade);
            Console.WriteLine("Valor total em estoque: R$ " + produto.CalcularEstoque());
            Console.WriteLine();
        }

        //Instanciando todas as classes
        public static void Main()
        {
            Carnes c = new Carnes("Picanha", 50.0, 10);
            Laticinios l = new Laticinios("Queijo", 12.5, 20);
            Ferramentas f = new Ferramentas("Martelo", 30.0, 15);
            Limpeza li = new Limpeza("Desinfetante", 5.5, 50);
            Petiscos p = new Petiscos("Biscoito", 3.0, 200);

            ExibirInformacoes(c);
            ExibirInformacoes(l);
            ExibirInformacoes(f);
            ExibirInformacoes(li);
            ExibirInformacoes(p);

            double maiorValor = Math.Max(
                c.CalcularEstoque(),
                Math.Max(
                    l.CalcularEstoque(), 
                    Math.Max(
                        f.CalcularEstoque(),
                        Math.Max(li.CalcularEstoque(), p.CalcularEstoque())
                    )
                )
            );

            Console.WriteLine("Maior valor em estoque: R$ " + maiorValor);
        }
    }
}
