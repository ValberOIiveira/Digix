using System;
using System.Collections.Generic;
using DesafioEnum;

namespace DesafioEnumExecucao
{
    class Executar
    {
        static void Main(string[] args)
        {
            // Criando empregados com diferentes tipos, regiões e status de licença
            Empregado empregado1 = new Empregado("Carlos", 3000, 240, 1, TiposEmpregados.Vendedor, Regioes.Sul, StatusLicenca.Aprovada);
            Empregado empregado2 = new Empregado("Ana", 2500, 240, 0, TiposEmpregados.GerenteVendas, Regioes.Norte, StatusLicenca.Pendente);
            Empregado empregado3 = new Empregado("Mariana", 5000, 240, 2, TiposEmpregados.GerenteProducao, Regioes.Sul, StatusLicenca.Rejeitada);
            Empregado empregado4 = new Empregado("João", 3500, 240, 3, TiposEmpregados.Vendedor, Regioes.Sul, StatusLicenca.Aprovada);

            // Adicionando empregados à lista
            List<Empregado> empregados = new List<Empregado> { empregado1, empregado2, empregado3, empregado4 };

            // Exibindo empregados com tipo, região e status de licença
            Console.WriteLine("Lista de Empregados:");

            foreach (var emp in empregados)
            {
                Console.WriteLine($"Nome: {emp.sName}");
                Console.WriteLine($"Tipo de Empregado: {emp.TipoEmpregado}");
                Console.WriteLine($"Região: {emp.regioes}");
                Console.WriteLine($"Status de Licença: {emp.StatusLicenca}");
                Console.WriteLine($"Salário: {emp.getSalario()}\n");
            }

            Console.WriteLine("Execução concluída!");
        }
    }
}
