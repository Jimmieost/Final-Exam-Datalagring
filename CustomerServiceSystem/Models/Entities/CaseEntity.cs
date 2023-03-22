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

        [StringLength(50)]
        public string Status { get; set; } = "Ej påbörjad";
        
        [Column(TypeName = "nvarchar(150)")]
        public string? Comment { get; set; }

        public int CustomerId { get; set; }
        public CustomerEntity Customer { get; set; } = null!;



    }
}
