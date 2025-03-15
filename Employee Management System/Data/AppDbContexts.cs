using Employee_Management_System.Models.Emp_Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_System.Data
{
    public class AppDbContexts:DbContext
    {
        public AppDbContexts(DbContextOptions<AppDbContexts> options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<UserLogin> userlogin { get; set; }
    }
}
