using EmployeesManager.Models;
using EmployeesManager.Repository;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesManager.Services
{
    public class DepartmentsService
    {
        private RepositoryDepartments _repositoryDepartments;
        public DepartmentsService(DatabaseContext context)
        {
            _repositoryDepartments = new RepositoryDepartments(context);
        }

        public List<Department> GetDepartments()
        {
            return _repositoryDepartments.GetAllList().ToList();
        }
        public List<string> GetNamesDepartments()
        {
            var departments = GetDepartments();
            var names = new List<string>();
            foreach (var department in departments)
            {
                names.Add(department.Name);
            }
            return names;
        }

        public Department GetDepartmentById(int id)
        {
            return _repositoryDepartments.GetById(id);
        }
        public Department GetDepartmentByName(string name)
        {
            return _repositoryDepartments.GetDepartmentByName(name);
        }

        public void Create(Department department)
        {
            _repositoryDepartments.Create(department);
        }

        public void Delete(Department departmet)
        {
            _repositoryDepartments.Delete(departmet);
        }

        public void Update(Department department)
        {
            _repositoryDepartments.Update(department);
        }

        public bool DepartmentExists(string name)
        {
            return _repositoryDepartments.DepartmentExists(name);
        }

        public bool IsContentEmployees(int id)
        {
            var department = _repositoryDepartments.GetContentDepartment(id);
            if(department.Employees.Count!=0)
            {
                return true;
            }
            return false;
        }
        public Department CreateIfNotExists(string nameDep)
        {
            if (DepartmentExists(nameDep))
            {
                return GetDepartmentByName(nameDep);
            }
            Department department = new Department()
            {
                Name = nameDep
            };
            Create(department);
            return GetDepartmentByName(nameDep);
        }
    }
}
