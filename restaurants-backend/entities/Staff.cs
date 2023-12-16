using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace restaurants_backend.entities
{
    [Table("Staff")]
    public class Staff
    {
        public int Id { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public double HourlyWage { get; set; }
        public bool FullTime { get; set; }
        
        [MaxLength] 
        public string? Notes { get; set; }
    }
}