using Domain.Enums;

namespace Domain.Entities
{
    public class Purpose
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } = string.Empty;
        public Units? Units { get; set; }
        public decimal? ExpensePerUnit { get; set; } = null!;
        public DateTime AddedOn { get; set; } = DateTime.Now;
    }
}
