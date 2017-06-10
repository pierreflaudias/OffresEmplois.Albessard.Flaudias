using Model.Entities;
using Model.FluentEntities;
using System.Linq;

namespace BusinessLayer.Queries
{
    public class StatusQuery
    {
        private readonly ContextFluent _context;

        public StatusQuery(ContextFluent context)
        {
            _context = context;
        }

        public IQueryable<Status> GetAll()
        {
            return _context.Statuses;
        }

        public Status GetById(int statusId)
        {
            return _context.Statuses.FirstOrDefault(sta => sta.Id == statusId);
        }
    }
}
