using EmployeesManager.Models;
using EmployeesManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesManager.Services
{
    public class KPIService
    {
        KPIRepository _kpiRepository;
        public KPIService(DatabaseContext context)
        {
            _kpiRepository = new KPIRepository(context);
        }

        public List<DictKPI> GetDictKPIs()
        {
            return _kpiRepository.GetAllList().ToList();
        }

        public List<string> GetKPIs()
        {
            var dictKPIs = GetDictKPIs();
            var KPIs = new List<string>();
            foreach (var dictKPI in dictKPIs)
            {
                KPIs.Add(dictKPI.KPI);
            }
            return KPIs;
        }
        public DictKPI GetKPIFromStr(string kpi_kode)
        {
            return _kpiRepository.GetKPIFromStr(kpi_kode);
        }
    }
}
