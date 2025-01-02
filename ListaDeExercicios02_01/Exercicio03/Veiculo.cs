namespace ListaDeExercicios02_01.Exercicio03
{
    public class Veiculo
    {
        public double valorDiaria { get; set; }

        public double impostoLocacao { get; set; }

        public Veiculo(double valorDiaria, double impostoLocacao)
        {
            this.valorDiaria = valorDiaria;
            this.impostoLocacao = impostoLocacao;
        }

        public virtual double CalcularValorLocacao()
        {
            return impostoLocacao * valorDiaria;
        }
    }
}