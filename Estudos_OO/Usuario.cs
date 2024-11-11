public class Usuario
{
    public string Nome { get; set;}


    public Usuario(string nome)
    {
        Nome = nome;
    }


    public void Saudacao()
    {
        Console.WriteLine(Nome);
    }
}