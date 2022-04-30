using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EmployeesManager.Services.Helpers
{
    public class FileWriter
    {
        private string _path;

        public FileWriter(string path)
        {
            _path = path ?? throw new ArgumentNullException(nameof(path));
        }

        public void FileWrite(List<EmployeesInfo> employees)
        {
           
           
            var sorted = employees.Select(em => new DataReport(em)).OrderBy(em => em.Department).ToList();

            using (var sr = new StreamWriter(_path, true))
            {
                foreach (var em in sorted)
                {
                    sr.WriteLine(em.ToString());
                }

            }
        }


    }

    class DataReport
    {
        public DataReport()
        {

        }
        public DataReport(EmployeesInfo ei)
        {
            FullName = ei.FullName;
            Department=ei.Department;
            Position=ei.Position;
            Sallary=ei.Sallary;
            Rating=ei.Rating;
            Premium=ei.Premium;
        }

        public string FullName { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public decimal Sallary { get; set; }
        public string Rating { get; set; }
        public decimal Premium { get; set; }

        public override string ToString()
        {
            return $"{FullName} | {Department} | {Position} | {Sallary} | {Rating} | {Premium}";
        }
    }

}
