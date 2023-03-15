namespace CustomerServiceSystem.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public string Description { get; set; } = null!;    
        public Case CaseId { get; set; } = new Case();

      
    }
}
