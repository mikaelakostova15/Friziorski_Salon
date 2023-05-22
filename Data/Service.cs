using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Resources;

namespace Friziorski_Salon.Data
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public DateTime RegisterOn { get; set; } 
        public ICollection<Reservation> Reservations { get; set; }
    }
}
