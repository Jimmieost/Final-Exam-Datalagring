using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CustomerServiceSystem.Models
{
    internal class Case
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string NotHandledStatus { get; set; } = null!;    
        public string OngoingStatus { get; set; } = null!;      
        public string DoneStatus { get; set; } = null!;
        public string? Comment { get; set; }
    }
}
