namespace ListaDeExercicios02_01.Exercicio01
{
    public class Mosca : Homem
    {

        public string Reino;
        public string Filo;
        public string Classe;

        public string Ordem;
        public string Familia;
        public string Genero;
        public string Especie;

        public Mosca(string Reino, string Filo, string Classe,string Ordem, string Familia, string Genero, string Especie)
        {
            this.Reino = "Animalia";
            this.Filo = "Arthropoda";
            this.Classe = "Insecta";
            this.Ordem = "Diptera";
            this.Familia = "Muscidae";
            this.Genero = "Musca";
            this.Especie = "Musca domestica";
        }
    }
}