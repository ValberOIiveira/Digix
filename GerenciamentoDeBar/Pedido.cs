using cliente;
using bebida;

public class Pedido
    {
        public Cliente Cliente { get; private set; }
        public List<Bebida> Bebidas { get; private set; }

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Bebidas = new List<Bebida>();
        }

        public void AdicionarBebida(Bebida bebida)
        {
            Bebidas.Add(bebida);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var bebida in Bebidas)
            {
                total += bebida.Preco;
            }
            return total;
        }
    }