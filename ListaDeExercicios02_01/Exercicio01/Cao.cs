namespace ListaDeExercicios02_01.Exercicio01
{
    public class Cao : Homem
    {
        public string Reino  = "Animalia";
        public string Filo = "Chordata";
        public string Classe = "Mammalia";

        public string Ordem;
        public string Familia;
        public string Genero;
        public string Especie;

        public Homem(string Reino, string Filo, string Classe,string Ordem, string Familia, string Genero, string Especie)
        {
            this.Reino = Reino;
            this.Filo = Filo;
            this.Classe = Classe;
            this.Ordem = Ordem;
            this.Familia = Familia;
            this.Genero = Genero;
            this.Especie = Especie;
        }
    }
}