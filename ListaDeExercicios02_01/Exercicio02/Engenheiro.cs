namespace ListaDeExercicios02_01.Exercicio02
{
    public class Engenheiro : Pessoa
    {
        public int crea;

        public Engenheiro(string nome, string cpf, int crea) : base(nome, cpf)
        {
            this.crea = crea;
        }
        public int Crea
        {
            get => crea;
            set
            {
                crea = value;
            }
        }


    }


}