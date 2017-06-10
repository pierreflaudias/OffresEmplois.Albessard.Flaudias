using Model.FluentEntities;
using System.Linq;
using Model.Entities;

namespace BusinessLayer.Commands
{
    public class EmployeeCommand
    {
        private readonly ContextFluent _context;

        public EmployeeCommand(ContextFluent context)
        {
            this._context = context;
        }

        public int Add(Employee e)
        {
            _context.Employees.Add(e);
            return _context.SaveChanges();
        }

        public void Update(Employee e)
        {
            Employee upd = _context.Employees.FirstOrDefault(emp => emp.Id == e.Id);
            if (upd != null)
            {
                upd.BirthDate = e.BirthDate;
                upd.Biography = e.Biography;
                upd.FirstName = e.FirstName;
                upd.Name = e.Name;
                upd.Seniority = e.Seniority;
            }
            _context.SaveChanges();
        }

        public void Delete(int employeeId)
        {
            Employee del = _context.Employees.FirstOrDefault(emp => emp.Id == employeeId);
            if (del != null)
            {
                _context.Employees.Remove(del);
            }
            _context.SaveChanges();
        }
    }
}
