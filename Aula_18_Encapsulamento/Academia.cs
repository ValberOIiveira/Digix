namespace Aula_18_Encapsulamento
{
    public class Academia
    {
        public string Nome { get; set; }
        private double Mensalidade { get; set; }

        public Academia()
        {

        }

        public Academia(string nome, double mensalidade)
        {
            Nome = nome;
            Mensalidade = Mensalidade;
        }

        
    }
}