using Model.Entities;
using Model.FluentEntities;
using System.Linq;

namespace BusinessLayer.Queries
{
    public class ExperienceQuery
    {

        private readonly ContextFluent _context;

        public ExperienceQuery(ContextFluent context)
        {
            _context = context;
        }

        public IQueryable<Experience> GetAll()
        {
            return _context.Experiences;
        }

        public Experience GetById(int expId)
        {
            return _context.Experiences.FirstOrDefault(exp => exp.Id == expId);
        }
    }
}
