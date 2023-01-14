using Portfolio.Data;
using Portfolio.Models;
using Portfolio.Services.Infrastructures;

namespace Portfolio.Services.Repositories
{
    public class ProjectRepository : IProject
    {
        private ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Projects.Count();
        }

        public void Delete(int id)
        {
            var project = _context.Projects.FirstOrDefault(p => p.Id == id);
            if (project != null)
            {
                _context.Projects.Remove(project);
            }
        }

        public Project GetProject(int id)
        {
            var project = _context.Projects.FirstOrDefault(p => p.Id == id);
            return project != null ? project : null;
        }

        public IEnumerable<Project> GetProjects()
        {
            return _context.Projects;
        }

        public void Insert(Project project)
        {
            _context.Projects.Add(project);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Project project)
        {
            _context.Projects.Update(project);
        }
    }
}
