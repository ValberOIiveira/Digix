namespace ExercicioClasseAbstrata2
{
    public class Executar
    {
        public static void Main()
        {
            // Criando um objeto Livro
            Livro livro1 = new Livro(1, 29.90, "J.K. Rowling", 9780747532743);
            Console.WriteLine("Livro 1:");
            Console.WriteLine(livro1.ToString());
            Console.WriteLine($"Novo Preço do Livro: {livro1.AtualizarPreco()}\n");

            // Criando um objeto CompactDisc
            CompactDisc cd1 = new CompactDisc(2, 49.90, "The Beatles", "Apple Records");
            Console.WriteLine("Compact Disc 1:");
            Console.WriteLine(cd1.ToString());
            Console.WriteLine($"Novo Preço do Compact Disc: {cd1.AtualizarPreco()}\n");

            // Alterando atributos com os métodos Set
            livro1.SetAutor("George R.R. Martin");
            livro1.SetISBN(9780553103540);
            cd1.SetArtista("Pink Floyd");
            cd1.SetGravadora("Columbia");

            // Exibindo os objetos com os novos valores
            Console.WriteLine("Após atualizar os dados:");
            Console.WriteLine(livro1.ToString());
            Console.WriteLine(cd1.ToString());

            Console.ReadKey();
        }
    }
}