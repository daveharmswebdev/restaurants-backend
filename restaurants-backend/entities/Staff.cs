using System.ComponentModel.DataAnnotations.Schema;

namespace restaurants_backend.entities
{
    [Table("Staff")]
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public double HourlyWage { get; set; }
        public bool FullTime { get; set; }
    }
}