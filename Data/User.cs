using Microsoft.AspNetCore.Identity;

namespace Friziorski_Salon.Data
{
    public class User:IdentityUser
    {
        public string FullName { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
