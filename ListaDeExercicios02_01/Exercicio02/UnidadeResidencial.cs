namespace ListaDeExercicios02_01.Exercicio02
{
    public class UnidadeResidencial
    {
        public double metragemUnidade { get; set; }
        public int numQuartos { get; set; }
        public int numBanheiros { get; set; }
        public Pessoa proprietario { get; set; }

        public UnidadeResidencial(double metragemUnidade, int numQuartos, int numBanheiros, Pessoa proprietario)
        {
            this.metragemUnidade = metragemUnidade;
            this.numQuartos = numQuartos;
            this.numBanheiros = numBanheiros;
            this.proprietario = proprietario;
        }

        public double getMetragemUnidade()
        {
            return metragemUnidade;
        }

        public void setMetragemUnidade(double metragemUnidade)
        {
            this.metragemUnidade = metragemUnidade;
        }

        public int getNumQuartos()
        {
            return numQuartos;
        }

        public void setNumQuartos(int numQuartos)
        {
            this.numQuartos = numQuartos;
        }

        public int getNumBanheiros()
        {
            return numBanheiros;
        }

        public void setNumBanheiros(int numBanheiros)
        {
            this.numBanheiros = numBanheiros;
        }

        public Pessoa getProprietario()
        {
            return proprietario;
        }

        public void setProprietario(Pessoa proprietario)
        {
            this.proprietario = proprietario;
        }


    }
}