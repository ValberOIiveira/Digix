namespace Aula_19_OO_Interface.Zoo
{
    public class Animal
    {
       public int Pernas { get; set; } 

       public Animal(int pernas)
       {
           Pernas = pernas;
       }

       public virtual void Caminha()
       {
         Console.WriteLine("Caminhando...");
       }

       public virtual void Come()
       {
         Console.WriteLine("Comendo...");
       }
    }
}