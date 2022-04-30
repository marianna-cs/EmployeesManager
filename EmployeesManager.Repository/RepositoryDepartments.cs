using EmployeesManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EmployeesManager.Repository
{
    public class RepositoryDepartments : Repository<Department>
    {
        public RepositoryDepartments(DatabaseContext context) : base(context)
        {

        }

        public bool DepartmentExists(string name)
        {
            return _context.Departments.Any(x => x.Name == name);
        }
        public Department GetDepartmentByName(string name)
        {
            return _context.Departments.FirstOrDefault(d => d.Name == name);
        }

        public Department GetContentDepartment(int id)
        {
            var test = _context.Departments.Include(x => x.Employees).FirstOrDefault(c => c.Id == id);
            return _context.Departments.Include(x => x.Employees).FirstOrDefault(c=> c.Id == id);
        }
    }
}
