namespace Friziorski_Salon.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int HairdresserId { get; set; }
        public Hairdresser Hairdressers { get; set; }
        public string UserId { get; set; }
        public User Users { get; set; }
        public int ServiceId { get; set; }
        public Service Services { get; set; }
        public DateTime RegisterOn { get; set; }    
    }
}
