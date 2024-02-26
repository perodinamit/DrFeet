namespace Domain.Entities
{
    public class Shoe
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } = null;
        public DateTime AddedOn { get; set; } = DateTime.Now;

        public int TopId { get; set; }
        public Top Top { get; set; }
    }
}
