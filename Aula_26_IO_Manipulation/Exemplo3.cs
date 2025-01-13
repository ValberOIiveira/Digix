namespace Aula_26_IO_Manipulation
{
    public class Exemplo3
    {

        static void Exe3()
        {
            string initialPath = @"C:\Users\valberoliveira\Desktop\Exemplo.txt";

            try
            {
                using (FileStream fs = new FileStream(initialPath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        System.Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {

                System.Console.WriteLine("Ocorreu o erro " + e.Message);

            }
        }

    }
}