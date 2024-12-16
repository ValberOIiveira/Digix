namespace Aula_19_OO_Interface.Zoo
{
    public class Formiga : Animal
    {
        public Formiga(int pernas) : base(pernas)
        {
            Pernas = pernas;
        }

        public override void Come()
        {
            base.Come();
        }


    }
}