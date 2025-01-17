using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleApiExample
{
    class ConsumirJsonEmTxt
    {
        static async Task Main(string[] args)
        {
            // URL da API pública para piadas sobre esportes
            string url = "https://v2.jokeapi.dev/joke/Dark";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Enviando a requisição GET
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Garantindo que a requisição foi bem-sucedida
                    response.EnsureSuccessStatusCode();

                    // Lendo a resposta como string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Exibindo a resposta
                    Console.WriteLine("Piada sobre Esportes:");
                    Console.WriteLine(responseBody);
                }
                catch (HttpRequestException e)
                {
                    // Tratamento de erro
                    Console.WriteLine($"Request error: {e.Message}");
                }
            }
        }
    }
}
