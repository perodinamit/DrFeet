namespace Domain.Entities
{
    public class Lining
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public DateTime AddedOn { get; set; } = DateTime.Now;

        public int? MaterialId { get; set; }
        public Material? Material { get; set; }
    }
}
