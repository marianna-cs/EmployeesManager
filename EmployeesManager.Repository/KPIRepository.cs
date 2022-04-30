using EmployeesManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesManager.Repository
{
    public class KPIRepository : Repository<DictKPI>
    {
        public KPIRepository(DatabaseContext context) : base(context)
        {
            SeedKPIs(context);
        }

        public DictKPI GetKPIFromStr(string kpi_kode)
        {
            return _context.DictKPIs.FirstOrDefault(k => k.KPI == kpi_kode);
        }

        private void SeedKPIs(DatabaseContext context)
        {
            if (context.DictKPIs.Any())
            {
                return;
            }
            var kpis = new List<DictKPI>
                {
                    new DictKPI()
                    {
                        KPI = "A",
                        Rating = 20
                    },
                    new DictKPI()
                    {
                        KPI = "B",
                        Rating = 30
                    },
                    new DictKPI()
                    {
                        KPI = "C",
                        Rating = 40
                    }


                };
            context.DictKPIs.AddRange(kpis);
            context.SaveChanges();

        }
    }
}
