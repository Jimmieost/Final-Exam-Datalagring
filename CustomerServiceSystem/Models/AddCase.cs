

namespace CustomerServiceSystem.Models
{
    internal class AddCase
    {
        public string Description { get; set; } = null!;
        public string Status { get; set; } = "Ej påbörjad";
        public int CustomerId { get; set; }
        public string Title { get; set; } = null!;
    }
}
