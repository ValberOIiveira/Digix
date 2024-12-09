namespace Aula_18_OO_ModificadoresdeAcesso
{
    public class Funcionario
    {
        //Acessivel de qualquer lugar
        public string Nome;

        //Acessivel apenas dentro da mesma classe
        private double Salario;

        //Acessivel apenas dentro da mesma namespace
        protected string Cargo;

        public Funcionario(string nome, double salario, string cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        //Metodo acessivel de qualquer lugar
        public void ExibirDados()
        {
            //Acessando o atributo "Salario" que é privado
            System.Console.WriteLine($"Nome: {Nome}, Salario: {Salario}, Cargo: {Cargo}");
        }

        //Metodo acessivel apenas dentro da mesma classe e subclasses
        private void ExibirCargo()
        {
            System.Console.WriteLine($"Cargo: {Cargo}");
        }
        

        //Metodo acessivel apenas dentro da mesma namespace
        protected void AumentarSalario(double porcentagem)
        {
            Salario += (Salario * porcentagem) / 100;
        }
        

        
    }
}