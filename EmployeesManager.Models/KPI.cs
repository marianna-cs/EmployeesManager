using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManager.Models
{
    public class DictKPI : IEntity
    {
        public int Id { get; set; }

        [MaxLength(2)]
        public string KPI { get; set; }

        public decimal Rating { get; set; }
    }


}
