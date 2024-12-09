using System.Security.Cryptography;

namespace Aula_18_OO
{
    public  abstract class Forma
    {
        public string Nome;

        public Forma(string nome)
        {
            Nome = nome;
        }

        //Métodos abstratos não possuel corpo e devem ser implementados em classes filhas
        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();

        public override string ToString()
        {
            return $"Nome: {Nome}, ��rea: {CalcularArea()}, Perímetro: {CalcularPerimetro()}";
        } 
    }
};
