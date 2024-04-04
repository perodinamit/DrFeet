namespace Domain.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
      
        public string? Name { get; set; } = string.Empty;

        public string? Address { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; } = string.Empty;
        public string? Iban { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? ContactPerson { get; set; } = string.Empty;
        public DateTime AddedOn { get; set; } = DateTime.Now;
    }
}
