namespace ListaDeExercicios02_01.Exercicio02
{
    public class Casa : Edificacao
    {
        public bool condominio;


        public Casa(double metragemTotal, string endereco, Engenheiro responsavel, List<UnidadeResidencial> unidades, bool condominio) : base(metragemTotal, endereco, responsavel, unidades)
        {
            this.condominio = condominio;
        }

        public override string descricaoDoImovel()
{
    string descricaoCondominio = condominio ? "Está em um condomínio." : "Não está em um condomínio.";
    return $"Casa localizada em {Endereco}, com metragem total de {MetragemTotal}m². {descricaoCondominio} " +
           $"Responsável pela obra: {Responsavel.Nome} (CREA: {Responsavel.Crea}).";
}


        public bool Condominio
        {
            get => condominio;
            set
            {
                condominio = value;
            }
        }
    }


}