using bebida;
using cliente;

public class Bar
{
    private List<Bebida> cardapio;



    public Bar()
    {
        cardapio = new List<Bebida>();
    }

    public void AdicionarBebida(Bebida bebida)
    {
        cardapio.Add(bebida);
    }

    public void FazerPedido(Cliente cliente)
    {
        Pedido pedido = new Pedido(cliente);
        foreach (Bebida bebida in cardapio)
        {
            pedido.AdicionarBebida(bebida); 
        }

        Console.WriteLine($"Pedido de {cliente.Nome}:");
        foreach (var bebida in pedido.Bebidas)
        {
            Console.WriteLine($"- {bebida.Nome} - R${bebida.Preco:F2}");
        }

        Console.WriteLine($"Total do pedido: R${pedido.CalcularTotal():F2}");
    }
}