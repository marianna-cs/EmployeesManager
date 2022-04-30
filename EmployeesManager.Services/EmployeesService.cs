using EmployeesManager.Models;
using EmployeesManager.Repository;
using EmployeesManager.Services.Extensions;
using EmployeesManager.Services.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesManager.Services
{
    public class EmployeesService
    {
        private RepositoryEmployees _repositoryEmployees;
        public EmployeesService(DatabaseContext context)
        {
            _repositoryEmployees = new RepositoryEmployees(context);
        }

        public void Create(Employee employee)
        {
            _repositoryEmployees.Create(employee);
        }
        public void Update(Employee employee)
        {
            _repositoryEmployees.Update(employee);
        }
        public void Delete(Employee employee)
        {
            _repositoryEmployees.Delete(employee);
        }

        public Employee GetById(int id)
        {
            return _repositoryEmployees.GetById(id);
        }


        public decimal GetSumSallary()
        {
            var employees = _repositoryEmployees.GetAllList();
            var summ = employees.GetSallary();

            return summ;
        }

        public decimal GetSumSallaryByList(List<Employee> employees)
        {
            var summ = employees.GetSallary();
            return summ;

        }

        public List<Employee> GetEmployeesWithFK()
        {
            return _repositoryEmployees.GetEmployeesWithFK().ToList();
        }

        public List<EmployeesInfo> GetEmployeesInfo()
        {
            var employeesInfo = new List<EmployeesInfo>();
            PremiumCalculator calculation = new PremiumCalculator();
            var employees = GetEmployeesWithFK();
            foreach (var employee in employees)
            {
                var test = employee.FullName;
                EmployeesInfo info = new EmployeesInfo()
                {
                    Id = employee.Id,
                    FullName = employee.FullName,
                    Department = employee.Department.Name,
                    Position = employee.Position.Name,
                    Sallary = employee.Salary,
                    Rating = employee.KPI_Ref.KPI,
                    Premium = calculation.Calculate(employee.Salary, employee.KPI_Ref.Rating)
                };
                employeesInfo.Add(info);
            }
            return employeesInfo;
        }
    }

    public class EmployeesInfo
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public decimal Sallary { get; set; }
        public string Rating { get; set; }
        public decimal Premium { get; set; }

    }


}
