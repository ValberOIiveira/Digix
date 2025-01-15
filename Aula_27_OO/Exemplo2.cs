namespace Aula_27_OO
{
    public class Exemplo2
    {
        static void Exe2(string[] args)
        {

            string filePath = "dados.bin";

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int inteiro = reader.ReadInt32();
                double numeroReal = reader.ReadDouble();
                string texto = reader.ReadString();

                System.Console.WriteLine("Número int do arquivo" + inteiro);
                System.Console.WriteLine("Numero double do arquivo" + numeroReal);
                System.Console.WriteLine("Texto do arquivo" + texto);
            }
        }
    }
}