using Model.Entities;
using Model.FluentEntities;
using System.Linq;

namespace BusinessLayer.Commands
{
    public class OfferCommand
    {
        private readonly ContextFluent _context;

        public OfferCommand(ContextFluent context)
        {
            this._context = context;
        }

        public int Add(Offer o)
        {
            _context.Offers.Add(o);
            return _context.SaveChanges();
        }

        public void Update(Offer o)
        {
            Offer upd = _context.Offers.FirstOrDefault(off => off.Id == o.Id);
            if (upd != null)
            {
                upd.Date = o.Date;
                upd.Description = o.Description;
                upd.Responsible = o.Responsible;
                upd.Salary = o.Salary;
                upd.StatusId = o.StatusId;
                upd.Title = o.Title;
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
