namespace Enum_Composicao
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public string getName()
        {
            return Name;
        }
        public void setName(string name)
        {
            Name = name;
        }

        public string getEmail()
        {
            return Email;
        }

        public void setEmail(string email)
        {
            Email = email;
        }

        public DateTime getBirthDate()
        {
            return BirthDate;
        }

        public void setBirthDate(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
    }
}