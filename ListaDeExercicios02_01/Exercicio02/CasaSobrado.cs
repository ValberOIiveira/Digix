namespace ListaDeExercicios02_01.Exercicio02
{
    public class CasaSobrado : Casa
    {

        public int numAndares;

        public CasaSobrado(double metragemTotal, string endereco, Engenheiro responsavel, List<UnidadeResidencial> unidades, bool condominio, int numAndares) : base(metragemTotal, endereco, responsavel, unidades, condominio)
        {
            this.numAndares = numAndares;
        }

        public override string descricaoDoImovel()
        {
            return $"Casa Sobrado localizada em {Endereco}, com metragem total de {MetragemTotal}m². " +
                   $"Possui {NumAndares} andares. " +
                   $"Está em um condomínio: {(Condominio ? "Sim" : "Não")}. " +
                   $"Responsável pela obra: {Responsavel.Nome} (CREA: {Responsavel.Crea}).";
        }

        public int NumAndares
        {
            get => numAndares;
            set
            {
                numAndares = value;
            }
        }
    }


}