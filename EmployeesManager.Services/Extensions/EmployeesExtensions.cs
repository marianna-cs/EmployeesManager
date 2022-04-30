using EmployeesManager.Models;
using EmployeesManager.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Services.Extensions
{
    public static class EmployeesExtensions
    {
        public static decimal GetSallary(this IEnumerable<Employee> employees) 
        {
            return employees.Sum(em => PaymentsCalculator.Calculate(em.Salary, em.KPI_Ref.Rating));
        }
    }
}
