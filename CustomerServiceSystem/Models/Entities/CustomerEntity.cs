using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerServiceSystem.Models.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    internal class CustomerEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        [StringLength(50)]
        public string LastName { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        [Column(TypeName = "char(13)")]
        public string PhoneNumber { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int CaseId { get; set; }
        public CaseEntity Case { get; set; } = null!;

    }
}
