namespace Friziorski_Salon.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Service> Services { get; set; }
        public DateTime RegisterOn { get; set; }    
    }
}
