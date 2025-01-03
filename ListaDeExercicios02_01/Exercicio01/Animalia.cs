namespace ListaDeExercicios02_01.Exercicio01
{
    public class Animalia : Taxonomia
    {
        public Animalia(string reino, string filo, string classe, string ordem, string familia, string genero, string especie) : base(reino, filo, classe, ordem, familia, genero, especie)
        {
            Reino = reino;
            Filo = filo;
            Classe = classe;
            Ordem = ordem;
            Familia = familia;
            Genero = genero;
            Especie = especie;
        }

        public override string GetTaxonomia()
        {
            return $"Reino: {Reino}, Filo: {Filo}, Classe: {Classe}, Ordem: {Ordem}, Familia: {Familia}, Genero: {Genero}, Especie: {Especie}";
        }
    }
}