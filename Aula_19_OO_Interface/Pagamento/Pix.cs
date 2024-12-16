using System.Security.Cryptography.X509Certificates;

namespace Aula_19_OO_Interface
{
    public class Pix : IPagamento
    {
        public string? ChavePix { get; set; }
        public string? NomeTitular { get; set; }
        public string? CPF { get; set; }
        public double Valor { get; set; }

        public DateTime DataPagamento { get; set; }

        public Pix(string chavePix, string nomeTitular, string cpf, double valor, DateTime dataPagamento)
        {
            ChavePix = chavePix;
            NomeTitular = nomeTitular;
            CPF = cpf;
            Valor = valor;
            DataPagamento = dataPagamento;
        }

        public void RealizarPagamento(double valor)
        {
            Valor = valor;
            Console.WriteLine($"Pagando PIX com chave {ChavePix}, para o titular {NomeTitular} de {Valor} reais.");
        }

        public void ExibirComprovante()
        {
            Console.WriteLine($"Comprovante de pagamento PIX gerado para o titular {NomeTitular}.");
            Console.WriteLine($"Chave Pix: {ChavePix}");
        }


    }
}