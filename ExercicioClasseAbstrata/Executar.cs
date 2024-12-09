namespace ExercicioClasseAbstrata
{
    public class Executar
    {
        static void Main(string[] args)
        {
            //Criando um objeto da classe Assalariado
            Assalariado assalariado = new Assalariado("João", "Silva", "123.456.789-00", 3000.00);
            Console.WriteLine("--- Assalariado ---");
            Console.WriteLine(assalariado);

            //Criando um objeto da classe Comissionado
            Comissionado comissionado = new Comissionado("Maria", "Oliveira", "987.654.321-00", 20000.00, 0.1);
            Console.WriteLine("\n--- Comissionado ---");
            Console.WriteLine(comissionado);

            //Criando um objeto da classe Horista
            Horista horista = new Horista("Pedro", "Santos", "555.444.333-22", 50.00, 160);
            Console.WriteLine("\n--- Horista ---");
            Console.WriteLine(horista);

            //Aguardando entrada para encerrar o programa
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}