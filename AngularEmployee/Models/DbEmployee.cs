using Microsoft.EntityFrameworkCore;

namespace AngularEmployee.Models
{
    public class DbEmployee:DbContext
    {
        public DbEmployee(DbContextOptions<DbEmployee> op):base(op) { }
        public DbSet<Employee> Employees { get; set;}
    }
}
