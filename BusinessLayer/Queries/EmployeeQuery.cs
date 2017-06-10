using Model.Entities;
using Model.FluentEntities;
using System.Linq;

namespace BusinessLayer.Queries
{
    public class EmployeeQuery
    {
        private readonly ContextFluent _context;

        public EmployeeQuery(ContextFluent context)
        {
            _context = context;
        }

        public IQueryable<Employee> GetAll()
        {
            return _context.Employees;
        }

        public Employee GetById(int employeeId)
        {
            return _context.Employees.FirstOrDefault(emp => emp.Id == employeeId);
        }
    }
}
