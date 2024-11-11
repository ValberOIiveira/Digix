namespace bebida
{
    public class Bebida
    {

        public string Nome { get; private set; }
        public double Preco { get; private set; }

        public Bebida(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }
}