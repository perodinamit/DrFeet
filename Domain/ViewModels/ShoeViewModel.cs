namespace Domain.ViewModels
{
    public class ShoeViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime AddedOn { get; set; }
        public string TopName { get; set; }

        public string LiningName { get; set; }
    }
}
