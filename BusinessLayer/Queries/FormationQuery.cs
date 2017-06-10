using Model.Entities;
using Model.FluentEntities;
using System.Linq;

namespace BusinessLayer.Queries
{
    public class FormationQuery
    {
        private readonly ContextFluent _context;

        public FormationQuery(ContextFluent context)
        {
            _context = context;
        }

        public IQueryable<Formation> GetAll()
        {
            return _context.Formations;
        }

        public Formation GetById(int formationId)
        {
            return _context.Formations.FirstOrDefault(f => f.Id == formationId);
        }
    }
}
