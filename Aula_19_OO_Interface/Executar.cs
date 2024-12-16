namespace Aula_19_OO_Interface.Zoo
{
    public class Executar
    {
        static void Main(string[] args)
        {
             // Testando o Cachorro
            Console.WriteLine("Testando o Cachorro:");
            Cachorro cachorro = new Cachorro("Rex", 4);
            Console.WriteLine($"Nome do cachorro: {cachorro.GetNome()}");
            cachorro.Caminha();  // Método herdado de Animal
            cachorro.Come();    // Método herdado de Animal
            cachorro.Brinca();   // Método implementado da interface IAnimalDeEstimacao
            cachorro.SetNome("Max");
            Console.WriteLine($"Novo nome do cachorro: {cachorro.GetNome()}");

            Console.WriteLine();

            // Testando a Formiga
            Console.WriteLine("Testando a Formiga:");
            Formiga formiga = new Formiga(6);  // A formiga tem 6 pernas
            Console.WriteLine($"Formiga tem {formiga.Pernas} pernas.");
            formiga.Caminha();  // Método herdado de Animal
            formiga.Come();    // Método herdado de Animal

            Console.WriteLine();

            // Testando o Peixe
            Console.WriteLine("Testando o Peixe:");
            Peixe peixe = new Peixe("Nemo", 0); // O peixe não tem pernas
            Console.WriteLine($"Nome do peixe: {peixe.GetNome()}");
            peixe.Caminha();  // Método herdado de Animal
            peixe.Come();    // Método herdado de Animal
            peixe.Brinca();   // Método implementado da interface IAnimalDeEstimacao

            Console.WriteLine();
        }
    }
}