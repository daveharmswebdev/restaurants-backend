using Microsoft.EntityFrameworkCore;
using restaurants_backend.entities;

namespace restaurants_backend.Data
{
    public class DbInitializer
    {
        public static void InitDb(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            SeedData(scope.ServiceProvider.GetService<RestaurantsDbContext>());
        }

        private static void SeedData(RestaurantsDbContext context)
        {
            context.Database.Migrate();

            if (context.Staff.Any())
            {
                return;
            }

            var staff = new List<Staff>
            {
                new() { FirstName = "John", LastName = "Doe", HourlyWage = 10, FullTime = true },
                new() { FirstName = "Jane", LastName = "Smith", HourlyWage = 10.25, FullTime = false, MiddleName = "Eva" },
                new() { FirstName = "Bob", LastName = "Johnson", HourlyWage = 10.5, FullTime = true },
                new() { FirstName = "Alice", LastName = "Williams", HourlyWage = 10.75, FullTime = false, MiddleName = "Grace" },
                new() { FirstName = "Charlie", LastName = "Brown", HourlyWage = 11, FullTime = true },
                new() { FirstName = "Eva", LastName = "Davis", HourlyWage = 11.25, FullTime = false, MiddleName = "Jane" },
                new() { FirstName = "William", LastName = "Miller", HourlyWage = 11.5, FullTime = true },
                new() { FirstName = "Grace", LastName = "Moore", HourlyWage = 11.75, FullTime = false, MiddleName = "Robert" },
                new() { FirstName = "Michael", LastName = "Taylor", HourlyWage = 12, FullTime = true },
                new() { FirstName = "Olivia", LastName = "Anderson", HourlyWage = 12.25, FullTime = false, MiddleName = "Daniel" },
                new() { FirstName = "Daniel", LastName = "White", HourlyWage = 12.5, FullTime = true },
                new() { FirstName = "Sophia", LastName = "Martin", HourlyWage = 12.75, FullTime = false, MiddleName = "David" },
                new() { FirstName = "James", LastName = "Hill", HourlyWage = 13, FullTime = true },
                new() { FirstName = "Emma", LastName = "Carter", HourlyWage = 13.25, FullTime = false, MiddleName = "Taylor" },
                new() { FirstName = "Ava", LastName = "Baker", HourlyWage = 13.5, FullTime = true },
                new() { FirstName = "Benjamin", LastName = "Adams", HourlyWage = 13.75, FullTime = false, MiddleName = "Morgan" },
                new() { FirstName = "Mia", LastName = "Gonzalez", HourlyWage = 14, FullTime = true },
                new() { FirstName = "Logan", LastName = "Hall", HourlyWage = 14.25, FullTime = false, MiddleName = "Lee" },
                new() { FirstName = "Evelyn", LastName = "Garcia", HourlyWage = 14.5, FullTime = true },
                new() { FirstName = "Liam", LastName = "Russell", HourlyWage = 14.75, FullTime = false, MiddleName = "Scott" },
                new() { FirstName = "Aiden", LastName = "Lopez", HourlyWage = 15, FullTime = true }
            };

            context.AddRange(staff);

            context.SaveChanges();
        }
    }
}