namespace Aula_19_OO_Interface
{
    public interface IPagamento
    {
        //Implicitamente é um metodo abstrato e publico
        void RealizarPagamento(double valor);
        void ExibirComprovante();
    }
}