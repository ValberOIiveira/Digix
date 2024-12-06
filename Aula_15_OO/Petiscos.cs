namespace Aula_15_OO
{
    public class Petiscos
    {
        public string Nome;

        public double Preco;

        public int Quantidade;

        public Petiscos()
        {
            Nome = "Petisco Genérico";
            Preco = 0;
            Quantidade = 0;
        }


        public Petiscos(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public double CalcularEstoque()
        {
            return Preco * Quantidade;
        }
    }
}
