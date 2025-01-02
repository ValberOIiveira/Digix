namespace ListaDeExercicios02_01.Exercicio02
{
    public class CasaTerrea : Casa
    {
        public bool garagem;
        public bool temQuintal;
        private bool v;


        public CasaTerrea(double metragemTotal, string endereco, Engenheiro responsavel, List<UnidadeResidencial> unidades, bool condominio, bool garagem, bool temQuintal)
            : base(metragemTotal, endereco, responsavel, unidades, condominio)
        {
            this.garagem = garagem;
            this.temQuintal = temQuintal;
        }

        public CasaTerrea(double metragemTotal, string endereco, Engenheiro responsavel, List<UnidadeResidencial> unidades, bool condominio, bool v) : base(metragemTotal, endereco, responsavel, unidades, condominio)
        {
            this.v = v;
        }


        public override string descricaoDoImovel()
        {
            return $"Casa Térrea localizada em {Endereco}, com metragem total de {MetragemTotal}m². " +
                   $"Possui garagem: {(Garagem ? "Sim" : "Não")}, e quintal: {(TemQuintal ? "Sim" : "Não")}. " +
                   $"Está em um condomínio: {(Condominio ? "Sim" : "Não")}. " +
                   $"Responsável pela obra: {Responsavel.Nome} (CREA: {Responsavel.Crea}).";
        }


        public bool Garagem
        {
            get => garagem;
            set => garagem = value;
        }

        public bool TemQuintal
        {
            get => temQuintal;
            set => temQuintal = value;
        }
    }
}
