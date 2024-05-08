namespace Domain.Entities
{
    public class Miscellaneous
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public DateTime AddedOn { get; set; } = DateTime.Now;
    }
}
