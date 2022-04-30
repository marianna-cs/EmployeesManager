using EmployeesManager.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EmployeesManager.Repository
{
    public class RepositoryEmployees : Repository<Employee>
    {
        public RepositoryEmployees(DatabaseContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetEmployeesWithFK()
        {
            return _context.Employees.Include(d => d.Department).Include(p => p.Position).Include(r => r.KPI_Ref).ToList();
        }


    }
}
