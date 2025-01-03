namespace ListaDeExercicios02_01.Exercicio01
{
    public class Taxonomia
    {
        protected string Reino;
        protected string Filo;
        protected string Classe;
        protected string Ordem;
        protected string Familia;
        protected string Genero;
        protected string Especie;

        public Taxonomia(string reino, string filo, string classe, string ordem, string familia, string genero, string especie)
        {
            Reino = reino;
            Filo = filo;
            Classe = classe;
            Ordem = ordem;
            Familia = familia;
            Genero = genero;
            Especie = especie;
        }

        public virtual string GetTaxonomia()
        {
            return $"Reino: {Reino}, Filo: {Filo}, Classe: {Classe}, Ordem: {Ordem}, Familia: {Familia}, Genero: {Genero}, Especie: {Especie}";
        }

    }
}