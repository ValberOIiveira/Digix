using ListaDeExercicios02_01.Exercicio03;

namespace ListaDeExercicios02_01
{
    public class Carro : Veiculo
    {

        public string categoria { get; set; }

        public Carro(string categoria, double valorDiaria, double impostoLocacao) : base(valorDiaria, impostoLocacao)
        {
            this.categoria = categoria;
        }

        public override double CalcularValorLocacao()
        {
            return impostoLocacao * valorDiaria + 100;
        }
    }
}