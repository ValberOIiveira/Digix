using ListaDeExercicios02_01.Exercicio03;

namespace ListaDeExercicios02_01
{
    public class Furgao : Veiculo
    {
        public int numeroDeEixos { get; set; }

        public Furgao(int numeroDeEixos, double valorDiaria, double impostoLocacao) : base(valorDiaria, impostoLocacao)
        {
            this.numeroDeEixos = numeroDeEixos;
        }

        public override double CalcularValorLocacao()
        {
            return impostoLocacao * valorDiaria + 75*numeroDeEixos;
        }
    }
}