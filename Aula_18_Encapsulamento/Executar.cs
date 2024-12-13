using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Aula_18_Encapsulamento
{
    public class Executar
    {
        static void Main(string[] args)
        {
           Type t =  typeof(Produto);
           System.Console.WriteLine(t.Name);  

           System.Console.WriteLine("Propriedades: ");
           foreach (PropertyInfo prop in t.GetProperties())
           {
              System.Console.WriteLine(prop.Name);
           }

        }
    }
}