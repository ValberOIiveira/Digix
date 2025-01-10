namespace Desafio_2
{
     public class Endereco
    {
        // Utilizando propriedades auto-implementadas
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public Estado Estado { get; set; }
        public string CEP { get; set; }

        // Construtor
        public Endereco(string rua, string cidade, Estado estado, string cep)
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }
        public Endereco()
        {
            
        }

       
    }
}