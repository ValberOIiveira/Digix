namespace DesafioEnum
{
    public class Pessoa
    {
        public string sName;

        public Pessoa()
        {

        }

        public Pessoa(string sName)
        {
            this.sName = sName;
        }

        public void setName(string sName)
        {
            this.sName = sName;
        }

        public string getName()
        {
            return sName;
        }
    }
}