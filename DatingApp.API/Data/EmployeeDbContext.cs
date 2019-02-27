using Microsoft.EntityFrameworkCore;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace DatingApp.API.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options):base(options)
        {
        }
        public DbSet<Employee> GetEmployee{get;set;}
    }
}