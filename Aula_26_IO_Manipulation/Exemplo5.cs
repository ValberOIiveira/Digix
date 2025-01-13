namespace Aula_26_IO_Manipulation
{
    public class Exemplo5
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\valberoliveira\Desktop\Teste";

            try
            {
                IEnumerable<string> pastas = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                System.Console.WriteLine("Pastas:");

                foreach (var pasta in pastas)
                {
                    System.Console.WriteLine(pasta);
                }

                Directory.CreateDirectory(path + @"\Teste2");
                Directory.Delete(path + @"", true);

                bool existe = Directory.Exists(path + @"\Nova");
                System.Console.WriteLine("Pasta nova existe: " + existe);
            }
            catch (IOException e)
            {
                
                System.Console.WriteLine("Ocorreu um erro " + e.Message); 
                
            }
        }
    }
}