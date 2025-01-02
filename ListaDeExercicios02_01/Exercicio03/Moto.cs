using ListaDeExercicios02_01.Exercicio03;

namespace ListaDeExercicios02_01
{
    public class Moto : Veiculo
    {
        public int cilindrada { get; set; } = 125;

        public Moto(int cilindrada, double valorDiaria, double impostoLocacao) : base(valorDiaria, impostoLocacao)
        {
            this.cilindrada = cilindrada;
        }

        public override double CalcularValorLocacao()
        {
            return impostoLocacao * valorDiaria + 20*cilindrada;
        }
        
    }
}