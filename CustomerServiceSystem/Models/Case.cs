namespace CustomerServiceSystem.Models
{
    internal class Case
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string Title { get; set; } = null!;
        public int CustomerId { get; set; }
        public string Status { get; set; } = "Unhandled";
        public string? Comment { get; set; }
    }
}
