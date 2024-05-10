using Domain.Enums;

namespace Domain.Entities
{
    public class Decoration
    {
        public int Id { get; set; }
        public string? Description { get; set; } = string.Empty;
        public int MaterialId { get; set; }
        public Material? Material { get; set; }
        public Units? Units { get; set; }
        public decimal? ExpensePerUnit { get; set; } = null!;
    }
}
