namespace ListaDeExercicios02_01.Exercicio02
{
    public class Predio : Edificacao
    {
        public string nome;

        public int numAndares;

        public int apPorAndar;

        public Predio(double metragemTotal, string endereco, Engenheiro responsavel, List<UnidadeResidencial> unidades, string nome, int numAndares, int apPorAndar) : base(metragemTotal, endereco, responsavel, unidades)
        {
            this.nome = nome;
            this.numAndares = numAndares;
            this.apPorAndar = apPorAndar;
        }

        public override string descricaoDoImovel()
        {
            return $"Prédio '{Nome}' localizado em {Endereco}, com metragem total de {MetragemTotal}m². " +
                   $"Possui {NumAndares} andares, com {ApPorAndar} apartamentos por andar. " +
                   $"Responsável pela obra: {Responsavel.Nome} (CREA: {Responsavel.Crea}).";
        }



        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
            }
        }

        public int NumAndares
        {
            get => numAndares;
            set
            {
                numAndares = value;
            }
        }

        public int ApPorAndar
        {
            get => apPorAndar;
            set
            {
                apPorAndar = value;
            }
        }
    }




}