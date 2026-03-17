using EmployeeManagementAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.Data
{
    public class EmployeeTable : DbContext
    {
        public EmployeeTable(DbContextOptions<EmployeeTable> options) : base(options)
        {

        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
