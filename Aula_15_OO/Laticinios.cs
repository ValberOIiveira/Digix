namespace Aula_15_OO
{
    public class Laticinios
    {
        
        public string Nome;

        public double Preco;

        public int Quantidade;

        public Laticinios()
        {
            Nome = "Laticinio Generico";
            Preco = 0;
            Quantidade = 0;
        }


        public Laticinios(string nome, double preco, int quantidade)
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