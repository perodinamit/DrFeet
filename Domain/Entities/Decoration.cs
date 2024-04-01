namespace Domain.Entities
{
    public class Decoration
    {
        public int Id { get; set; }
        public string? Description { get; set; } = string.Empty;
        public int MaterialId { get; set; }
        public Material? Material { get; set; }
    }
}
