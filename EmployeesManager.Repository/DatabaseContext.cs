using EmployeesManager.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace EmployeesManager.Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base(@"Data Source=(localdb)\mssqllocaldb;Database=Employees;Trusted_Connection=True;MultipleActiveResultSets=true")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<DictKPI> DictKPIs { get; set; }


        

    }
}
