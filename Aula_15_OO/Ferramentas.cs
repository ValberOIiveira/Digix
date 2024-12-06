namespace Aula_15_OO
{


    public record Ferramentas (string Nome, double Preco, int Quantidade)
    {
        public double CalcularEstoque()
        {
            return Preco * Quantidade;
        }
    }
    // public class Ferramentas
    // {
        
    //     public string Nome;

    //     public double Preco;

    //     public int Quantidade;

    //     public Ferramentas()
    //     {
    //         Nome = "Ferramenta Genérica";
    //         Preco = 0;
    //         Quantidade = 0;
    //     }


    //     public Ferramentas(string nome, double preco, int quantidade)
    //     {
    //         this.Nome = nome;
    //         this.Preco = preco;
    //         this.Quantidade = quantidade;
    //     }

    //     public double CalcularEstoque()
    //     {
    //         return Preco * Quantidade;
    //     }
    // }
}