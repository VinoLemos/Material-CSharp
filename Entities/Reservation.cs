using ExcecoesPersonalizadas.Exceptions;

namespace ExcecoesPersonalizadas.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Reservation error! Check-out date must be after Check-in date!");
            }
            
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            //Variável recebe a diferença de uma data para a outra, converte de double para 
            //int através de casting e retorna na função
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room"
            + ", check-in: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", check-out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " nights.";
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkOut <= checkIn)
            {
                throw new DomainException("Reservation error! Check-out date must be after Check-in date!");
            }
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation error! Update dates must be future dates!");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}