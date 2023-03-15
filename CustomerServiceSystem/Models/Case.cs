namespace CustomerServiceSystem.Models
{
    internal class Case
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string NotHandledStatus { get; set; } = null!;    
        public string? Comment { get; set; }
    }
}
