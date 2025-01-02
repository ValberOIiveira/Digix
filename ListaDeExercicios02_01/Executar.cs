namespace ListaDeExercicios02_01.Exercicio02
{
    public class Executar
    {
        static void Main(string[] args)
        {
            //! Exercicio 3
            // Moto moto = new Moto(125, valorDiaria: 100, impostoLocacao: 10);
            // Console.WriteLine("Valor de locação da moto: R$ " + moto.CalcularValorLocacao());
            
            // Caminhao caminhao = new Caminhao(numeroDeEixos: 3, valorDiaria: 150, impostoLocacao: 20);
            // Console.WriteLine("Valor de locação do caminhão: R$ " + caminhao.CalcularValorLocacao());

            // Furgao furgao = new Furgao(numeroDeEixos: 2, valorDiaria: 200, impostoLocacao: 30);
            // Console.WriteLine("Valor de locação do furgão: R$ " + furgao.CalcularValorLocacao());


            Engenheiro engenheiro = new Engenheiro("João Silva", "123.456.789-00", 12345);

            // Criando algumas pessoas para as unidades residenciais
            Pessoa proprietario1 = new Pessoa("Carlos Souza", "987.654.321-00");
            Pessoa proprietario2 = new Pessoa("Ana Costa", "321.654.987-00");

            // Criando algumas unidades residenciais
            List<UnidadeResidencial> unidades = new List<UnidadeResidencial>
            {
                new UnidadeResidencial(80.5, 2, 1, proprietario1),
                new UnidadeResidencial(75.0, 2, 1, proprietario2)
            };

            // Criando objetos de cada tipo de edificação
            Casa casa = new Casa(150, "Rua A, 123", engenheiro, unidades, true);
            CasaSobrado casaSobrado = new CasaSobrado(200, "Rua B, 456", engenheiro, unidades, false, 2);
            CasaTerrea casaTerrea = new CasaTerrea(100, "Rua C, 789", engenheiro, unidades, true, true);
            Predio predio = new Predio(1000, "Avenida D, 101", engenheiro, unidades, "Edifício Central", 10, 4);

            // Chamando o método descricaoDoImovel de cada edificação e exibindo a descrição
            Console.WriteLine(casa.descricaoDoImovel());
            Console.WriteLine();
            Console.WriteLine(casaSobrado.descricaoDoImovel());
            Console.WriteLine();
            Console.WriteLine(casaTerrea.descricaoDoImovel());
            Console.WriteLine();
            Console.WriteLine(predio.descricaoDoImovel());
        }
    }
}