using Microsoft.EntityFrameworkCore;
using MVCtask2.Models;

namespace MVCtask2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=MVC_Department_CRUD;trusted_connection=true;trustServerCertificate=true;");
        }
    }
}
