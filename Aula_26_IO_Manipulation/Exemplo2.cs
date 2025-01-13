namespace Aula_26_IO_Manipulation
{
    public class Exemplo2
    {
        static void Exe2()
        {
            string initialPath = @"C:\Users\valberoliveira\Desktop\Exemplo.txt";
            //criar, abrir, ou manipular arquivos
            FileStream fs = null;
            // facilita a leitura de arquivos de texto
            StreamReader sr = null;

            try
            {
                //Abre o arquivo
                fs = new FileStream(initialPath, FileMode.Open);

                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                System.Console.WriteLine(line);

                while (line != null)
                {
                    line = sr.ReadLine();
                    System.Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu um error: " + e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }

        }
    }

}
