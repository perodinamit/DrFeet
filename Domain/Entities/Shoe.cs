using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Shoe
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = null;
        public DateTime AddedOn { get; set; } = DateTime.Now;

        public decimal? Price { get; set; } = decimal.Zero;

        public byte[]? ImageData { get; set; }

        public int TopId { get; set; }
        public Top? Top { get; set; }

        public int ColorTypeId { get; set; }
        public ColorType? ColorType { get; set; }

        public int LiningId { get; set; }
        public Lining? Lining { get; set;}

        public int PurposeId { get; set; }
        public Purpose? Purpose { get; set; }

        public int SoleId { get; set; }
        public Sole? Sole { get; set;}

        public int? DecorationId { get; set; }
        public Decoration? Decoration { get; set; }
        public List<Calculation>? Calculations { get; set; }
    }
}
