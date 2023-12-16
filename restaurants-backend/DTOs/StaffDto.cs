namespace restaurants_backend.DTOs
{
    public class StaffDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public bool FullTime { get; set; }
    }
}