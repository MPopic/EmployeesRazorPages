using EmployeesRazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesRazorPages.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
