using EmployeesManager.Models;
using EmployeesManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Services
{
    public class PositionsService
    {
        private RepositoryPositions _repositoryPositions;

        public PositionsService(DatabaseContext context)
        {
            _repositoryPositions = new RepositoryPositions(context);
        }

        public List<Position> GetPositions()
        {
            return _repositoryPositions.GetAllList().ToList();
        }

        public Position GetPositionById(int id)
        {
            return _repositoryPositions.GetById(id);
        }
        public List<string> GetNamesPositions()
        {
            var positions = GetPositions();
            var names = new List<string>();
            foreach (var position in positions)
            {
                names.Add(position.Name);
            }
            return names;
        }

        public Position GetPositionByName(string name)
        {
            return _repositoryPositions.GetPositionByName(name);
        }

        public Position GetById(int id)
        {
            return _repositoryPositions.GetById(id);
        }
        public void Create(Position position)
        {
            _repositoryPositions.Create(position);
        }

        public void Update(Position position)
        {
            _repositoryPositions.Update(position);
        }

        public void Delete(Position position)
        {
            _repositoryPositions.Delete(position);
        }
        public bool PositionExists(string name)
        {
            return _repositoryPositions.PositionExists(name);
        }

        public bool IsContentEmployees(int id)
        {
            var position = _repositoryPositions.GetContentPosition(id);
            if (position.Employees.Count != 0)
            {
                return true;
            }
            return false;
        }
        public Position CreateIfNotExists(string namePos)
        {
            if (PositionExists(namePos))
            {
                return GetPositionByName(namePos);
            }
            Position position = new Position()
            {
                Name = namePos
            };
            Create(position);
            return GetPositionByName(namePos);
        }
    }
}
