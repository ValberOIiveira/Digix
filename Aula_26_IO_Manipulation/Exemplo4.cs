using System;
using System.IO;

namespace Aula_26_IO_Manipulation
{
    public class Exemplo4
    {
        static void Exe4()
        {
            // Caminho do arquivo original
            string initialPath = @"C:\Users\valberoliveira\Desktop\Exemplo.txt";
            // Caminho do arquivo de destino
            string finalPath = @"C:\Users\valberoliveira\Desktop\Exemplo2.txt";

            try
            {
                // Lê todas as linhas do arquivo original
                string[] lines = File.ReadAllLines(initialPath);

                // Usando StreamWriter para gravar no arquivo de destino
                using (StreamWriter sw = new StreamWriter(finalPath, true)) // O parâmetro 'true' indica que será em modo de adição (append)
                {
                    foreach (var line in lines)
                    {
                        // Escreve cada linha em maiúsculas no arquivo de destino
                        sw.WriteLine(line.ToUpper());
                    }
                }

                Console.WriteLine("Operação concluída com sucesso!");
            }
            catch (IOException e)
            {
                // Captura e exibe erros de entrada/saída
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
        }   
    }
}
