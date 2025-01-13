using System.Security.Cryptography.X509Certificates;

namespace Aula_26_IO_Manipulation
{
    public class Exemplo1
    {
        // static void Main(string[] args)
        
            static void Exe1()
            {
                // File é uma classe estáticq que contém métodos
            string initialPath = @"C:\Users\valberoliveira\Desktop\Exemplo.txt";
            string finalPath = @"C:\Users\valberoliveira\Desktop\Exemplo2.txt";
            

            try
            {
                FileInfo fileInfo = new FileInfo(initialPath);
                fileInfo.CopyTo(finalPath);
                string [] line = File.ReadAllLines(initialPath);
                foreach (var item in line)
                {
                    System.Console.WriteLine(item);
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu o erro: " + e.Message);
                
            }

        }
            }
            
    }
