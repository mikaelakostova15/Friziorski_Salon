namespace Friziorski_Salon.Data
{
    public class Hairdresser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public DateTime RegisterOn { get; set; }
    }
}
