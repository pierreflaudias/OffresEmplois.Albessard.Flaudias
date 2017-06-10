using Model.Entities;
using Model.FluentEntities;
using System.Linq;

namespace BusinessLayer.Queries
{
    public class OfferQuery
    {

        private readonly ContextFluent _context;

        public OfferQuery(ContextFluent context)
        {
            _context = context;
        }

        public IQueryable<Offer> GetAll()
        {
            return _context.Offers;
        }

        public Offer GetById(int offerId)
        {
            return _context.Offers.FirstOrDefault(off => off.Id == offerId);
        }
    }
}
