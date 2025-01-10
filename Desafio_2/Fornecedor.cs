namespace Desafio_2
{
    public class Fornecedor
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string CNPJ { get; set; }
        public bool Recorrente { get; set; }
        public double Desconto { get; set; }

        public double CalcularDesconto(double valor)
        {
            if (Recorrente)
            {
                return valor * Desconto;
            }
            return 0;
        }
    }
}