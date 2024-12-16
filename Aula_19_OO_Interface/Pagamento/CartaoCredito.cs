namespace Aula_19_OO_Interface
{
    public class CartaoCredito : IPagamento, IAnuidade
    {
        public string NumeroCartao { get; set; }
        public DateTime DataVencimento { get; set; }
        public double ValorAnuidade { get; set; }


        public CartaoCredito(string numeroCartao, DateTime dataVencimento, double valorAnuidade)
        {
            NumeroCartao = numeroCartao;
            DataVencimento = dataVencimento;
            ValorAnuidade = valorAnuidade;
        }

        public void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento realizado com cartão de crédito: {NumeroCartao} - Valor: {valor}");
        }

        public void ExibirComprovante()
        {
            DateTime agora = DateTime.Now;  
            System.Console.WriteLine($"Comprovante de pagamento com o cartão de crédito: {NumeroCartao} no dia {agora.ToShortDateString()} às {agora.ToShortTimeString()}");
        }


        public DateTime CalcularDataVencimento()
        {
            return DateTime.Now.AddYears(1);
        }

        public double CalcularValorAnuidade()
        {
            return 100;
        }
    }
}