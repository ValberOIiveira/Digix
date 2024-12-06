namespace Aula_15_OO
{
    public class Limpeza
    {
        
        public string Nome;

        public double Preco;

        public int Quantidade;

        public Limpeza()
        {
            Nome = "Produto de Limpeza Genérico";
            Preco = 0;
            Quantidade = 0;
        }


        public Limpeza(string nome, double preco, int quantidade)
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