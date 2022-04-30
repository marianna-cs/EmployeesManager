using EmployeesManager.Models;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Repository
{
    public class RepositoryPositions : Repository<Position>
    {
        public RepositoryPositions(DatabaseContext context) : base(context)
        {
            _context = context;
        }
        public bool PositionExists(string name)
        {
            return _context.Positions.Any(x => x.Name == name);
        }

        public Position GetPositionByName(string name)
        {
            return _context.Positions.FirstOrDefault(d => d.Name == name);
        }
        public Position GetContentPosition(int id)
        {
            return _context.Positions.Include(x => x.Employees).FirstOrDefault(c => c.Id == id);
        }
    }
}
