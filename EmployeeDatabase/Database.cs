using EmployeeDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDatabase
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(
                    @"Data Source=JULIAZAVR\SQLEXPRESS;Initial Catalog=EmployeeDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }

            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Employee> Employees { set; get; }
    }
}