using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Models
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        [ForeignKey("Department")]
        public int Departmant_Id { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Position")]
        public int Position_Id { get; set; }
        public Position Position { get; set; }
        public decimal Salary { get; set; }
        public DictKPI KPI_Ref { get; set; }

        [NotMapped]
        public string FullName{get{ return $"{Name} {LastName} {MiddleName}"; } }
    }
}
