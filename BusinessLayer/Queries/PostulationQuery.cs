using Model.Entities;
using Model.FluentEntities;
using System.Linq;

namespace BusinessLayer.Queries
{
    public class PostulationQuery
    {
        private readonly ContextFluent _context;

        public PostulationQuery(ContextFluent context)
        {
            _context = context;
        }

        public IQueryable<Postulation> GetAll()
        {
            return _context.Postulations;
        }

        public IQueryable<Postulation> GetByEmployee(Employee e)
        {
            return _context.Postulations.Where(pos => pos.EmployeeId == e.Id);
        }

        public IQueryable<Postulation> GetByOffer(Offer o)
        {
            return _context.Postulations.Where(pos => pos.OfferId == o.Id);
        }

        public IQueryable<Postulation> GetByEmployeeAndOffer(Employee e, Offer o)
        {
            return _context.Postulations.Where(pos => pos.EmployeeId == e.Id && pos.OfferId == o.Id);
        }
    }
}
