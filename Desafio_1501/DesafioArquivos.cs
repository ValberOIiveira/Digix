using System;
using System.IO;
using System.IO.Compression;
using System.Xml;
using System.Globalization;

namespace Desafio_1501
{
    public class DesafioArquivosWord
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o caminho completo do arquivo .docx:");
            string sourceFilePath = Console.ReadLine();

            
            string outputFilePath = Path.Combine(Directory.GetCurrentDirectory(), "summary.docx");

            try
            {
                
                string extractedText = ExtractTextFromDocx(sourceFilePath);

                
                string[] lines = extractedText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    writer.WriteLine("Resumo dos Dados:");
                    writer.WriteLine();

                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');

                        if (fields.Length != 3) continue; // Ignorar linhas inválidas

                        // Extrair os campos
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        // Calcular o total
                        double total = price * quantity;

                        // Escrever no arquivo de saída
                        writer.WriteLine($"{name}: {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }

                Console.WriteLine($"Arquivo 'summary.docx' gerado com sucesso no diretório: {Directory.GetCurrentDirectory()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }

        private static string ExtractTextFromDocx(string filePath)
        {
            string extractedText = string.Empty;

            using (ZipArchive archive = ZipFile.OpenRead(filePath))
            {
                // Localizar o arquivo XML principal que contém o texto
                ZipArchiveEntry documentXml = archive.GetEntry("word/document.xml");

                if (documentXml != null)
                {
                    using (Stream stream = documentXml.Open())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string xmlContent = reader.ReadToEnd();

                        // Carregar o conteúdo XML
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(xmlContent);

                        // Selecionar todos os nós de texto
                        XmlNodeList textNodes = xmlDoc.GetElementsByTagName("w:t");

                        foreach (XmlNode node in textNodes)
                        {
                            extractedText += node.InnerText + Environment.NewLine;
                        }
                    }
                }
            }

            return extractedText;
        }
    }
}
