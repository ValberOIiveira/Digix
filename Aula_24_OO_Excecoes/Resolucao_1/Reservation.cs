namespace Aula_24_OO_Excecoes.Resolucao_1
{
    public class Reservation
    {
        public int rumNumber { get; set; }
        public  DateTime CheckIn { get; set; }
        public  DateTime CheckOut { get; set; }

        public Reservation(int rumNumber, DateTime checkIn, DateTime checkOut)
        {
            this.rumNumber = rumNumber;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
        }
   
        public int Duration()
        {
            TimeSpan timeSpan =  CheckOut.Subtract(CheckIn);
            return (int)timeSpan.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room {rumNumber}, checkIn {CheckIn.ToString("dd/MM/yyyy")}, checkOut {CheckOut.ToString("dd/MM/yyyy")} + ";
        }
    }
}