using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CustomerServiceSystem.Models.Entities
{
    internal class CaseEntity
    {
        [Key]

        public int Id { get; set; }
        public DateTime CaseReg { get; set; } = DateTime.Now;

        [Column(TypeName = "nvarchar(250)")]
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        [StringLength(10)]
        public string Status { get; set; } = null!;
        
        [Column(TypeName = "nvarchar(150)")]
        public string? Comment { get; set; }

        public ICollection<CustomerEntity> Customers { get; set; } = new HashSet<CustomerEntity>();

    }
}
