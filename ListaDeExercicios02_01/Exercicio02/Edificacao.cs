namespace ListaDeExercicios02_01.Exercicio02
{
    public abstract class Edificacao
    {
        public double metragemTotal;
        public string endereco;

        public Engenheiro responsavel;

        public List<UnidadeResidencial> unidades;

        public Edificacao(double metragemTotal, string endereco, Engenheiro responsavel, List<UnidadeResidencial> unidades)
        {
            this.metragemTotal = metragemTotal;
            this.endereco = endereco;
            this.responsavel = responsavel;
            this.unidades = unidades;
        }

        public abstract string descricaoDoImovel();

        public double MetragemTotal
        {
            get => metragemTotal;
            set
            {
                metragemTotal = value;
            }
        }

        public string Endereco
        {
            get => endereco;
            set
            {
                endereco = value;
            }
        }

        public Engenheiro Responsavel
        {
            get => responsavel;
            set
            {
                responsavel = value;
            }
        }

        public List<UnidadeResidencial> Unidades
        {
            get => unidades;
            set
            {
                unidades = value;
            }
        }




    }




}