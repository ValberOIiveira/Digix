namespace Aula_19_OO_Relacoes.Composicao
{
    public class Computador
    {
        private Processador processador;

        public Computador()
        {
            processador = new Processador();
        }

        void Iniciar()
        {
            System.Console.WriteLine("Iniciando");
            processador.processar();
        }
    }
}