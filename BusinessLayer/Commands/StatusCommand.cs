using Model.Entities;
using Model.FluentEntities;
using System.Linq;

namespace BusinessLayer.Commands
{
    public class StatusCommand
    {
        private readonly ContextFluent _context;

        public StatusCommand(ContextFluent context)
        {
            this._context = context;
        }

        public int Add(Status s)
        {
            _context.Statuses.Add(s);
            return _context.SaveChanges();
        }

        public void Update(Status s)
        {
            Status upd = _context.Statuses.FirstOrDefault(sta => sta.Id == s.Id);
            if (upd != null)
            {
                upd.Label = s.Label;
            }
            _context.SaveChanges();
        }

        public void Delete(int statusId)
        {
            Status del = _context.Statuses.FirstOrDefault(sta => sta.Id == statusId);
            if (del != null)
            {
                _context.Statuses.Remove(del);
            }
            _context.SaveChanges();
        }
    }
}
