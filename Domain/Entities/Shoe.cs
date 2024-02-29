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

        public int ColorTypeId { get; set; }
        public ColorType ColorType { get; set; }

        public int LiningId { get; set; }
        public Lining Lining { get; set;}

        public int PurposeId { get; set; }
        public Purpose Purpose { get; set; }

        public int SoleId { get; set; }
        public Sole Sole { get; set;}
    }
}
