namespace restaurants_backend.DTOs
{
    public class UpdateStaffDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public double HourlyWage { get; set; }
        public bool FullTime { get; set; }
        public string? Notes { get; set; }
    }
}