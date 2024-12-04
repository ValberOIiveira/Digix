// namespace AulaDeOO
// {
//     public class Padaria
//     {
//         public string ?Nome { get; set; }
//         public double ?Preco { get; set; }
//         public string ?Categoria { get; set; } // Exemplo: "Bebida", "Doce", etc.
//         public DateTime DataDeValidade { get; set; }

//         private static List<Padaria> Produtos { get; set; } = new List<Padaria>();

//         public override string ToString()
//         {
//             return $"{Nome} - {Categoria}: R${Preco:F2}, Validade: {DataDeValidade:dd/MM/yyyy}";
//         }

//         public static void AdicionarProduto(Padaria produto)
//         {
//             Produtos.Add(produto);
//             Console.WriteLine($"Produto {produto.Nome} adicionado com sucesso!");
//         }

//         public static void ListarProdutos()
//         {
//             Console.WriteLine("Produtos disponíveis:");
//             foreach (var produto in Produtos)
//             {
//                 Console.WriteLine(produto);
//             }
//         }
//     }

//     public class Program
//     {
//         public static void Main()
//         {
//             var pao = new Padaria
//             {
//                 Nome = "Pão Francês",
//                 Preco = 0.50,
//                 Categoria = "Alimento",
//                 DataDeValidade = DateTime.Now.AddDays(2),
//             };

//             var cafe = new Padaria
//             {
//                 Nome = "Café Expresso",
//                 Preco = 4.00,
//                 Categoria = "Bebida",
//                 DataDeValidade = DateTime.Now.AddMonths(1),
//             };

//             // Adicionando produtos à lista
//             Padaria.AdicionarProduto(pao);
//             Padaria.AdicionarProduto(cafe);

//             // Listando produtos
//             Padaria.ListarProdutos();
//         }
//     }
// }
