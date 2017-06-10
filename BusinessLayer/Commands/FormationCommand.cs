using Model.Entities;
using Model.FluentEntities;
using System.Linq;

namespace BusinessLayer.Commands
{
    public class FormationCommand
    {
        private readonly ContextFluent _context;

        public FormationCommand(ContextFluent context)
        {
            this._context = context;
        }

        public int Add(Formation f)
        {
            _context.Formations.Add(f);
            return _context.SaveChanges();
        }

        public void Update(Formation f)
        {
            Formation upd = _context.Formations.FirstOrDefault(form => form.Id == f.Id);
            if (upd != null)
            {
                upd.Title = f.Title;
                upd.Date = f.Date;
                upd.EmployeeId = f.EmployeeId;
            }
            _context.SaveChanges();
        }

        public void Delete(int formationId)
        {
            Formation del = _context.Formations.FirstOrDefault(form => form.Id == formationId);
            if (del != null)
            {
                _context.Formations.Remove(del);
            }
            _context.SaveChanges();
        }
    }
}
