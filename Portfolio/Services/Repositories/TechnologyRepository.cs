using Portfolio.Data;
using Portfolio.Models;
using Portfolio.Services.Infrastructures;

namespace Portfolio.Services.Repositories
{
    public class TechnologyRepository : ITechnology
    {
        private ApplicationDbContext _context;

        public TechnologyRepository(ApplicationDbContext context) { _context = context; }
        public int Count()
        {
            return _context.Technologies.Count();
        }

        public void Delete(int id)
        {
            var technology = _context.Technologies.FirstOrDefault(t => t.Id == id);
            if (technology != null)
            {
                _context.Technologies.Remove(technology);
            }
        }

        /**
        public IEnumerable<Project> GetProjectsWithParticularTechnology()
        {
            throw new NotImplementedException();
        }
        **/
        public IEnumerable<Technology> GetTechnologies()
        {
            return _context.Technologies;
        }

        public Technology GetTechnology(int id)
        {
            var tech = _context.Technologies.FirstOrDefault(tech => tech.Id == id);
            return tech != null ? tech : null;
        }

        public void Insert(Technology technology)
        {
            _context.Technologies.Add(technology);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Technology technology)
        {
            _context.Technologies.Update(technology);
        }
    }
}
