using bebida;
using cliente;

namespace main{
    public class Program {
        public static void Main() {
            Bar bar = new Bar();

            // Adicionando bebidas ao cardápio
            bar.AdicionarBebida(new Bebida("Cerveja", 10.00));
            bar.AdicionarBebida(new Bebida("Caipirinha", 15.00));
            bar.AdicionarBebida(new Bebida("Refrigerante", 5.00));

            // Criando clientes
            Cliente cliente1 = new Cliente("Alice");
            Cliente cliente2 = new Cliente("Bob");

            // Fazendo pedidos
            Console.WriteLine("\n--- Pedidos ---\n");
            bar.FazerPedido(cliente1);
            bar.FazerPedido(cliente2);
        }
    }
}