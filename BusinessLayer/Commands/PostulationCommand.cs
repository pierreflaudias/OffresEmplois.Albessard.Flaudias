using Model.Entities;
using Model.FluentEntities;
using System.Linq;

namespace BusinessLayer.Commands
{
    public class PostulationCommand
    {
        private readonly ContextFluent _context;

        public PostulationCommand(ContextFluent context)
        {
            this._context = context;
        }

        public int Add(Postulation p)
        {
            _context.Postulations.Add(p);
            return _context.SaveChanges();
        }

        public void Update(Postulation p)
        {
            Postulation upd = _context.Postulations.FirstOrDefault(pos => pos.OfferId == p.OfferId && pos.EmployeeId == p.EmployeeId);
            if (upd != null)
            {
                upd.Date = p.Date;
                upd.EmployeeId = p.EmployeeId;
                upd.OfferId = p.OfferId;
                upd.Status = p.Status;
            }
            _context.SaveChanges();
        }

        public void Delete(int offerID)
        {
            Offer del = _context.Offers.FirstOrDefault(off => off.Id == offerID);
            if (del != null)
            {
                _context.Offers.Remove(del);
            }
            _context.SaveChanges();
        }
    }
}
