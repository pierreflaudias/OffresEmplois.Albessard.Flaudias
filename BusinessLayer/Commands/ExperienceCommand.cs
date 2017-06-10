using Model.Entities;
using Model.FluentEntities;
using System.Linq;

namespace BusinessLayer.Commands
{
    public class ExperienceCommand
    {
        private readonly ContextFluent _context;

        public ExperienceCommand(ContextFluent context)
        {
            this._context = context;
        }

        public int Add(Experience e)
        {
            _context.Experiences.Add(e);
            return _context.SaveChanges();
        }

        public void Update(Experience e)
        {
            Experience upd = _context.Experiences.FirstOrDefault(exp => exp.Id == e.Id);
            if (upd != null)
            {
                upd.Date = e.Date;
                upd.EmployeeId = e.EmployeeId;
                upd.Title = e.Title;
            }
            _context.SaveChanges();
        }

        public void Delete(int experienceID)
        {
            Experience del = _context.Experiences.FirstOrDefault(exp => exp.Id == experienceID);
            if (del != null)
            {
                _context.Experiences.Remove(del);
            }
            _context.SaveChanges();
        }
    }
}
